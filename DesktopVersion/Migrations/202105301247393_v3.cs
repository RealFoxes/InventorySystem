namespace DesktopVersion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Domen", c => c.String(nullable: false, unicode: false));
            AddColumn("dbo.Servers", "Ip", c => c.String(maxLength: 255, storeType: "nvarchar"));
            DropColumn("dbo.Servers", "DomenOrIp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servers", "DomenOrIp", c => c.String(maxLength: 255, storeType: "nvarchar"));
            DropColumn("dbo.Servers", "Ip");
            DropColumn("dbo.Orders", "Domen");
        }
    }
}
