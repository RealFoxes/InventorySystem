using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesktopVersion.Entities
{
	public class Server
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Description("Тип сервера")]
		public TypeOfServer TypeOfServer { get; set; }
		[MaxLength(255)]
		[Description("Наименование")]
		public string Name { get; set; }
		[MaxLength(255)]
		[Description("IP")]
		public string Ip { get; set; }
		[Required]
		[Description("Офис")]
		public Office Office { get; set; }
		[MaxLength(255)]
		[Description("Детали")]
		public string Details { get; set; }
		public List<Order> Orders { get; set; }
		public Server()
		{
			Orders = new List<Order>();
		}
		public override string ToString()
		{
			return Name;
		}
	}
}