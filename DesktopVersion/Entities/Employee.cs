using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopVersion.Entities
{
	[Table("employees")]
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		[Description("Имя")]
		public string Name { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		[Description("Фамилия")]
		public string Surname { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		[Description("Отчество")]
		public string Patronymic { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[Column(TypeName = "Date")]
		[Description("Дата рождения")]
		public DateTime Birthdate { get; set; }
		[Required]
		[Description("Должность")]
		public JobPosition JobPosition { get; set; }
		[Required]
		[Description("Офис")]
		public Office Office { get; set; }

		public List<User> Users;

		public Employee()
		{
			Users = new List<User>();
		}
		public override string ToString()
		{
			return Name;
		}
	}
}