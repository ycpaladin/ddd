using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            this.HasKey(t => t.Id).ToTable("tbl_Roles");

            this.Property(t => t.Id)
               .IsRequired().HasColumnType("varchar")
               .HasMaxLength(38).HasColumnName("Id");


            this.Property(t => t.RoleName).IsRequired().HasMaxLength(255).HasColumnName("RoleName");

        }
    }
}
