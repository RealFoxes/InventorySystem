namespace DesktopVersion.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class Hueta : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Employees",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
					surname = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
					patronymic = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
					birthdate = c.DateTime(nullable: false, storeType: "date"),
					JobPosition_Id = c.Int(nullable: false),
					Office_Id = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.JobPositions", t => t.JobPosition_Id, cascadeDelete: true)
				.ForeignKey("dbo.Offices", t => t.Office_Id, cascadeDelete: true)
				.Index(t => t.name, unique: true)
				.Index(t => t.surname, unique: true)
				.Index(t => t.patronymic, unique: true)
				.Index(t => t.birthdate, unique: true)
				.Index(t => t.JobPosition_Id)
				.Index(t => t.Office_Id);

			CreateTable(
				"dbo.JobPositions",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
				})
				.PrimaryKey(t => t.Id)
				.Index(t => t.name, unique: true);

			CreateTable(
				"dbo.Offices",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
					Adress = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
					chief = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
				})
				.PrimaryKey(t => t.Id)
				.Index(t => t.name, unique: true)
				.Index(t => t.chief, unique: true);

			CreateTable(
				"dbo.Items",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Name = c.String(maxLength: 255, storeType: "nvarchar"),
					Details = c.String(maxLength: 255, storeType: "nvarchar"),
					Office_Id = c.Int(nullable: false),
					TypeItem_Id = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Offices", t => t.Office_Id, cascadeDelete: true)
				.ForeignKey("dbo.TypeOfItems", t => t.TypeItem_Id, cascadeDelete: true)
				.Index(t => t.Office_Id)
				.Index(t => t.TypeItem_Id);

			CreateTable(
				"dbo.TypeOfItems",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
				})
				.PrimaryKey(t => t.Id)
				.Index(t => t.name, unique: true);

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
			DropForeignKey("dbo.Items", "TypeItem_Id", "dbo.TypeOfItems");
			DropForeignKey("dbo.Items", "Office_Id", "dbo.Offices");
			DropForeignKey("dbo.Employees", "Office_Id", "dbo.Offices");
			DropForeignKey("dbo.Employees", "JobPosition_Id", "dbo.JobPositions");
			DropIndex("dbo.Users", new[] { "Employee_Id" });
			DropIndex("dbo.Users", new[] { "Username" });
			DropIndex("dbo.TypeOfItems", new[] { "name" });
			DropIndex("dbo.Items", new[] { "TypeItem_Id" });
			DropIndex("dbo.Items", new[] { "Office_Id" });
			DropIndex("dbo.Offices", new[] { "chief" });
			DropIndex("dbo.Offices", new[] { "name" });
			DropIndex("dbo.JobPositions", new[] { "name" });
			DropIndex("dbo.Employees", new[] { "Office_Id" });
			DropIndex("dbo.Employees", new[] { "JobPosition_Id" });
			DropIndex("dbo.Employees", new[] { "birthdate" });
			DropIndex("dbo.Employees", new[] { "patronymic" });
			DropIndex("dbo.Employees", new[] { "surname" });
			DropIndex("dbo.Employees", new[] { "name" });
			DropTable("dbo.Users");
			DropTable("dbo.TypeOfItems");
			DropTable("dbo.Items");
			DropTable("dbo.Offices");
			DropTable("dbo.JobPositions");
			DropTable("dbo.Employees");
		}
	}
}
