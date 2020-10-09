namespace DesktopVersion
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Employee
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Name { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Surname { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Patronymic { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[Column(TypeName = "Date")]
		public DateTime Birthdate { get; set; }
		[Required]
		public JobPosition JobPosition { get; set; }
		[Required]
		public Office Office { get; set; }

		public ICollection<User> Users;

		public Employee()
		{
			Users = new List<User>();
		}

	}
}