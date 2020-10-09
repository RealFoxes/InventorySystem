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

			Office office = new Office() { Name = "TestOffice", Chief = "TestBoss", Adress = "UtitsaPushkinaDom..." };
			context.Offices.Add(office);

			Employee employee = new Employee() { Name = "admin", Surname = "admin", Patronymic = "admin", JobPosition = jobPosition, Birthdate = DateTime.Now, Office = office };
			context.Employees.Add(employee);

			User user = new User() { AccessLVL = User.E_Access.Administrator, Employee = employee, Username = "Admin", Password = Utilities.GenerateHash("Admin") };
			context.Users.Add(user);

			TypeOfItem typeOfItem = new TypeOfItem() { Name = "ТестовыйТипПредмета" };
			context.TypeOfItems.Add(typeOfItem);

			Item item = new Item() { Details = "Тестовый данные о предмете", Name = "ТестовыйПредмет", Office = office, TypeItem = typeOfItem };
			context.Items.Add(item);

			base.Seed(context);

		}
	}
}
