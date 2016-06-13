namespace GfkApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 38, unicode: false),
                        LoginName = c.String(),
                        Password = c.String(),
                        IsNeedChangePassword = c.Boolean(nullable: false),
                        Expiration = c.DateTime(),
                        IsDisabled = c.Boolean(nullable: false),
                        UserName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Address = c.String(),
                        IsDomain = c.Boolean(nullable: false),
                        IsSuper = c.Boolean(nullable: false),
                        Postcode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_users");
        }
    }
}
