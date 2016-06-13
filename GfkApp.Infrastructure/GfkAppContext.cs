using GfkApp.Domain.Entity;
using GfkApp.Infrastructure.Interfaces;
using GfkApp.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure
{
    public class GfkAppContext : DbContext, IDbContext
    {
        public GfkAppContext()
            : base("name=GFKAPP")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
