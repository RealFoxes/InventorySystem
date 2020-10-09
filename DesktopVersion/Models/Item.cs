namespace DesktopVersion
{
	using System.ComponentModel.DataAnnotations;

	public class Item
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public TypeOfItem TypeItem { get; set; }
		[MaxLength(255)]
		public string Name { get; set; }
		[Required]
		public Office Office { get; set; }
		[MaxLength(255)]
		public string Details { get; set; }
	}
}