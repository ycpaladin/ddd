namespace GfkApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbl_users", "LoginName", c => c.String(nullable: false, maxLength: 38));
            AlterColumn("dbo.tbl_users", "Password", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.tbl_users", "UserName", c => c.String(nullable: false, maxLength: 4));
            AlterColumn("dbo.tbl_users", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.tbl_users", "Mobile", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.tbl_users", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.tbl_users", "Postcode", c => c.String(nullable: false, maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_users", "Postcode", c => c.String());
            AlterColumn("dbo.tbl_users", "Address", c => c.String());
            AlterColumn("dbo.tbl_users", "Mobile", c => c.String());
            AlterColumn("dbo.tbl_users", "Email", c => c.String());
            AlterColumn("dbo.tbl_users", "UserName", c => c.String());
            AlterColumn("dbo.tbl_users", "Password", c => c.String());
            AlterColumn("dbo.tbl_users", "LoginName", c => c.String());
        }
    }
}
