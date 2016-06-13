namespace GfkApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoleRefs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(maxLength: 38, unicode: false),
                        RoleId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .ForeignKey("dbo.tbl_Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoleRefs", "UserId", "dbo.tbl_Users");
            DropForeignKey("dbo.UserRoleRefs", "RoleId", "dbo.Roles");
            DropIndex("dbo.UserRoleRefs", new[] { "RoleId" });
            DropIndex("dbo.UserRoleRefs", new[] { "UserId" });
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoleRefs");
        }
    }
}
