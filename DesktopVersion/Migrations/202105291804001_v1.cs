namespace DesktopVersion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, unicode: false),
                        PhoneNumber = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false, precision: 0),
                        DateOfEnd = c.DateTime(nullable: false, precision: 0),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.String(nullable: false, maxLength: 1, storeType: "nvarchar"),
                        Client_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                        Server_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .ForeignKey("dbo.Servers", t => t.Server_Id, cascadeDelete: true)
                .Index(t => t.Client_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Server_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Surname = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Patronymic = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Birthdate = c.DateTime(nullable: false, storeType: "date"),
                        JobPosition_Id = c.Int(nullable: false),
                        Office_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobPositions", t => t.JobPosition_Id, cascadeDelete: true)
                .ForeignKey("dbo.Offices", t => t.Office_Id, cascadeDelete: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Surname, unique: true)
                .Index(t => t.Patronymic, unique: true)
                .Index(t => t.Birthdate, unique: true)
                .Index(t => t.JobPosition_Id)
                .Index(t => t.Office_Id);
            
            CreateTable(
                "dbo.JobPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Address = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Servers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255, storeType: "nvarchar"),
                        Details = c.String(maxLength: 255, storeType: "nvarchar"),
                        Office_Id = c.Int(nullable: false),
                        TypeOfServer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Offices", t => t.Office_Id, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfServers", t => t.TypeOfServer_Id, cascadeDelete: true)
                .Index(t => t.Office_Id)
                .Index(t => t.TypeOfServer_Id);
            
            CreateTable(
                "dbo.TypeOfServers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 16, storeType: "nvarchar"),
                        Password = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        AccessLVL = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Orders", "Server_Id", "dbo.Servers");
            DropForeignKey("dbo.Servers", "TypeOfServer_Id", "dbo.TypeOfServers");
            DropForeignKey("dbo.Servers", "Office_Id", "dbo.Offices");
            DropForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Office_Id", "dbo.Offices");
            DropForeignKey("dbo.Employees", "JobPosition_Id", "dbo.JobPositions");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Users", new[] { "Employee_Id" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.TypeOfServers", new[] { "Name" });
            DropIndex("dbo.Servers", new[] { "TypeOfServer_Id" });
            DropIndex("dbo.Servers", new[] { "Office_Id" });
            DropIndex("dbo.Offices", new[] { "Name" });
            DropIndex("dbo.JobPositions", new[] { "Name" });
            DropIndex("dbo.Employees", new[] { "Office_Id" });
            DropIndex("dbo.Employees", new[] { "JobPosition_Id" });
            DropIndex("dbo.Employees", new[] { "Birthdate" });
            DropIndex("dbo.Employees", new[] { "Patronymic" });
            DropIndex("dbo.Employees", new[] { "Surname" });
            DropIndex("dbo.Employees", new[] { "Name" });
            DropIndex("dbo.Orders", new[] { "Server_Id" });
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.TypeOfServers");
            DropTable("dbo.Servers");
            DropTable("dbo.Offices");
            DropTable("dbo.JobPositions");
            DropTable("dbo.Employees");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
        }
    }
}
