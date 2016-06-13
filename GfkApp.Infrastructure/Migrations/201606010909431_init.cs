namespace GfkApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tbl_users", "IsNeedChangePassword");
            DropColumn("dbo.tbl_users", "Expiration");
            DropColumn("dbo.tbl_users", "IsDisabled");
            DropColumn("dbo.tbl_users", "Phone");
            DropColumn("dbo.tbl_users", "IsDomain");
            DropColumn("dbo.tbl_users", "UpdateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_users", "UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tbl_users", "IsDomain", c => c.Boolean(nullable: false));
            AddColumn("dbo.tbl_users", "Phone", c => c.String());
            AddColumn("dbo.tbl_users", "IsDisabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.tbl_users", "Expiration", c => c.DateTime());
            AddColumn("dbo.tbl_users", "IsNeedChangePassword", c => c.Boolean(nullable: false));
        }
    }
}
