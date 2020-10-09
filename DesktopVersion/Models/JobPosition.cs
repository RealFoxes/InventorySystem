namespace DesktopVersion
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class JobPosition
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Name { get; set; }

		public ICollection<Employee> Employees;

		public JobPosition()
		{
			Employees = new List<Employee>();
		}

	}
}