using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure.Mapping
{
    public class UserRoleRefMap : EntityTypeConfiguration<UserRoleRef>
    {

        public UserRoleRefMap()
        {
            this.HasKey(t => t.Id).ToTable("tbl_UserRoleRef");

            this.Property(t => t.Id)
               .IsRequired().HasColumnType("varchar")
               .HasMaxLength(38).HasColumnName("Id");

            this.Property(t => t.UserId).IsRequired().HasColumnType("varchar")
               .HasMaxLength(38).HasColumnName("UserId");

            this.Property(t => t.RoleId).IsRequired().HasColumnType("varchar")
               .HasMaxLength(38).HasColumnName("RoleId");

            this.HasRequired(t => t.User).WithMany(t => t.UserRoleRef).HasForeignKey(t => t.UserId);

            this.HasRequired(t => t.Role).WithMany(t => t.UserRoleRef).HasForeignKey(t => t.RoleId);
        }
    }
}
