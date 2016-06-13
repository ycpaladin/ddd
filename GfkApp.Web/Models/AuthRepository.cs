using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace GfkApp.Web.Models
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public async Task<bool> AddRefreshToken(RefreshToken token)
        {
            _ctx.RefreshToken.Add(token);
            var result = await _ctx.SaveChangesAsync();
            return result > 0;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }

        public async Task<RefreshToken> FindRefreshToken(string hashedTokenId)
        {
            var result =  await _ctx.RefreshToken.FirstOrDefaultAsync(t => t.Id == hashedTokenId);
            return result;
        }

        public async Task<bool> RemoveRefreshToken(string hashedTokenId)
        {
            var result = await _ctx.RefreshToken.FirstOrDefaultAsync(t => t.Id == hashedTokenId);
            _ctx.Entry(result).State = EntityState.Deleted;
            var x = await _ctx.SaveChangesAsync();
            return x > 0;
        }
    }
}