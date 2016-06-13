using GfkApp.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace GfkApp.Web.Provider
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {

        //public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        //{
        //    string clientId;
        //    string clientSecret;
        //    context.TryGetFormCredentials(out clientId, out clientSecret);

        //    if (clientId == "kevin" && clientSecret == "Aa123456")
        //    {
        //        context.Validated(clientId);
        //    }
        //    return base.ValidateClientAuthentication(context);
        //}

        //public override Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        //{
        //    var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
        //    oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, "iOS App"));
        //    var ticket = new AuthenticationTicket(oAuthIdentity, new AuthenticationProperties());
        //    context.Validated(ticket);

        //    return base.GrantClientCredentials(context);
        //}

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            string clientId;
            string clientSecret;
            context.TryGetFormCredentials(out clientId, out clientSecret);
            context.Validated();
            return Task.FromResult<object>(null);
        }


        public async override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using (var _repo = new AuthRepository())
            {
                IdentityUser user = await _repo.FindUser(context.UserName, context.Password);

                if (user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
            identity.AddClaim(new Claim("sub", context.UserName));

            var props = new AuthenticationProperties(new Dictionary<string, string>
                {
                    { 
                        "as:client_id", context.ClientId ?? "gfkApp"
                    },
                    { 
                        "userName", context.UserName
                    }
                });

            var ticket = new AuthenticationTicket(identity, props);
            context.Validated(ticket);
        }


        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            return Task.FromResult<object>(null);
        }


        public async override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            var originalClient = context.Ticket.Properties.Dictionary["as:client_id"];
            var currentClient = context.ClientId;

            if (originalClient != currentClient)
            {
                context.Rejected();
                return;
            }

            var newId = new ClaimsIdentity(context.Ticket.Identity);
            newId.AddClaim(new Claim("newClaim", "refreshToken"));

            var newTicket = new AuthenticationTicket(newId, context.Ticket.Properties);
            context.Validated(newTicket);

            await base.GrantRefreshToken(context);
        }


        public async override Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        {

            //await Task.Run(() =>
            //{
            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);

            var props = new AuthenticationProperties(new Dictionary<string, string>
                {
                    { "as:client_id", context.ClientId }
                });
            var ticket = new AuthenticationTicket(oAuthIdentity, props);

            context.Validated(ticket);

            //});

            await base.GrantClientCredentials(context);

        }
    }
}