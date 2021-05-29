using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopVersion.Entities
{
	public class Office
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		[Description("Наименование")]
		public string Name { get; set; }
		[Required]
		[MaxLength(255)]
		[Description("Адрес")]
		public string Address { get; set; }

		public List<Server> Servers;
		public List<Employee> Employees;
		public Office()
		{
			Servers = new List<Server>();
			Employees = new List<Employee>();
		}

		public override string ToString()
		{
			return Name;
		}
	}
}