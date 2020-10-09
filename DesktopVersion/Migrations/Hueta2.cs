using MySql.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Threading;

namespace DesktopVersion.Migrations
{
	internal class Hueta2 : MySqlMigrationSqlGenerator
	{
		protected override MigrationStatement Generate(CreateIndexOperation op)
		{
			System.Globalization.CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
			try
			{
				Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");

				return base.Generate(op);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = cultureInfo;
			}
		}
	}
}