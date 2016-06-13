using GfkApp.Domain.Entity;
using GfkApp.Infrastructure.Interfaces;
//using GfkApp.Infrastructure.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure
{
    public class GfkAppContext : IdentityDbContext<IdentityUser>, IDbContext
    {
        public GfkAppContext()
            : base("name=GFKAPP")
        {

        }


        public DbSet<RefreshToken> RefreshToken { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Configurations.Add(new UserMap());

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
