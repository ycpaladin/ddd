using GfkApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GfkApp.Infrastructure.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {

        public UserMap()
        {
            this.HasKey(t => t.Id).ToTable("tbl_Users");

            this.Property(t => t.Id)
               .IsRequired().HasColumnType("varchar")
               .HasMaxLength(38).HasColumnName("Id");


            this.Property(t => t.LoginName).IsRequired().HasMaxLength(38).HasColumnName("LoginName");

            this.Property(t => t.Password).IsRequired().HasMaxLength(128).HasColumnName("Password");

            this.Property(t => t.UserName).IsRequired().HasMaxLength(4).HasColumnName("UserName");

            this.Property(t => t.Email).IsRequired().HasMaxLength(255).HasColumnName("Email");

            this.Property(t => t.Mobile).IsRequired().HasMaxLength(11).HasColumnName("Mobile");

            this.Property(t => t.Address).IsRequired().HasMaxLength(255).HasColumnName("Address");

            this.Property(t => t.Postcode).IsRequired().HasMaxLength(6).HasColumnName("Postcode");

            this.Property(t => t.CreatedDate).IsRequired().HasColumnName("CreatedDate");


            
        }
    }
}
