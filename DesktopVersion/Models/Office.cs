namespace DesktopVersion
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Office
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Name { get; set; }
		[Required]
		[MaxLength(255)]
		public string Adress { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Chief { get; set; }

		public ICollection<Item> Items;
		public ICollection<Employee> Employees;
		public Office()
		{
			Items = new List<Item>();
			Employees = new List<Employee>();
		}
	}
}