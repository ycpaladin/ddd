using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GfkApp.Web.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("GFKAPP")
        {



        }

        public DbSet<RefreshToken> RefreshToken { get; set; }
    }
}