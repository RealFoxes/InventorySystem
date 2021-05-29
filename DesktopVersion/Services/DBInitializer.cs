using DesktopVersion.Entities;
using System;
using System.Data.Entity;

namespace DesktopVersion
{
	class DBInitializer : DropCreateDatabaseAlways<MySQLModel>
	{
		protected override void Seed(MySQLModel context)
		{
			// Заполняем тестовые данные и создаем пользователя для дальнейшей работы с прогой 
			JobPosition jobPosition = new JobPosition() { Name = "TestJobPos" };
			context.JobPositions.Add(jobPosition);

			Office office = new Office() { Name = "TestOffice", Address = "UtitsaPushkinaDom..." };
			context.Offices.Add(office);

			Employee employee = new Employee() { Name = "admin", Surname = "admin", Patronymic = "admin", JobPosition = jobPosition, Birthdate = DateTime.Now, Office = office };
			context.Employees.Add(employee);

			User user = new User() { AccessLVL = User.E_Access.Administrator, Employee = employee, Username = "Admin", Password = Utilities.GenerateHash("Admin") };
			context.Users.Add(user);

			TypeOfServer typeOfItem = new TypeOfServer() { Name = "ТестовыйТипСервера" };
			context.TypeOfServers.Add(typeOfItem);

			Server server = new Server() { Details = "Тестовый данные о сервере", Name = "ТестовыйСервер", Office = office, TypeOfServer = typeOfItem };
			context.Servers.Add(server);

			Client client = new Client() { FullName = "Тестовое имя клиента", PhoneNumber = "88005553535" };
			context.Clients.Add(client);
			Order order = new Order() { Client = client, Cost = 123, Currency = "$", DateTime = DateTime.Now, DateOfEnd = DateTime.Now.AddDays(31), Employee = employee, Server = server };
			context.Orders.Add(order);
			base.Seed(context);

		}
	}
}
