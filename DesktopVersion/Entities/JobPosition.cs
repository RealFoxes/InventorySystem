using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopVersion.Entities
{
	[Table("jobpositions")]
	public class JobPosition
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		[Description("Наименование")]
		public string Name { get; set; }

		public List<Employee> Employees;

		public JobPosition()
		{
			Employees = new List<Employee>();
		}
		public override string ToString()
		{
			return Name;
		}
	}
}