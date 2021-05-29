using DesktopVersion.Entities;
using MySql.Data.Entity;
using System.Data.Entity;

namespace DesktopVersion
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))] //Тип модели конфигурации
	public class MySQLModel : DbContext
	{
		public MySQLModel() : base("name=MySQLModel")
		{
			Database.SetInitializer(new DBInitializer());
		}

		public virtual DbSet<Client> Clients { get; set; }
		public virtual DbSet<Employee> Employees { get; set; }
		public virtual DbSet<JobPosition> JobPositions { get; set; }
		public virtual DbSet<Office> Offices { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<Server> Servers { get; set; }
		public virtual DbSet<TypeOfServer> TypeOfServers { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}