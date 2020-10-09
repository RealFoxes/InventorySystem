
// enable-migrations | add-migration <NameMigration> | update-database

namespace DesktopVersion
{
	using MySql.Data.Entity;
	using System.Data.Entity;

	//
	[DbConfigurationType(typeof(MySqlEFConfiguration))] //Тип модели конфигурации
	public class MySQLModel : DbContext
	{

		public MySQLModel() : base("name=MySQLModel")
		{
			Database.SetInitializer(new DBInitializer());
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Office> Offices { get; set; }
		public DbSet<TypeOfItem> TypeOfItems { get; set; }
		public DbSet<JobPosition> JobPositions { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<Employee> Employees { get; set; }
	}
}