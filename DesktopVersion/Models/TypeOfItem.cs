namespace DesktopVersion
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class TypeOfItem
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		public string Name { get; set; }

		public ICollection<Item> Items;

		public TypeOfItem()//Конструктор
		{
			Items = new List<Item>();
		}

	}
}