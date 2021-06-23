using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopVersion.Entities
{
	[Table("typeofservers")]
	public class TypeOfServer
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[MaxLength(255)]
		[Description("Наименование")]
		public string Name { get; set; }

		public List<Server> Servers;

		public TypeOfServer()//Конструктор
		{
			Servers = new List<Server>();
		}

		public override string ToString()
		{
			return Name;
		}
	}
}