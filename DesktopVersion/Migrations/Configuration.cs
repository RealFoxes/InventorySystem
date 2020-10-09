namespace DesktopVersion.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<DesktopVersion.MySQLModel>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
			SetSqlGenerator("MySql.Data.MySqlClient", new Hueta2());
		}
	}
}
