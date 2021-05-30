using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesktopVersion.Entities
{
	public class Order
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Description("Сотрудник")]
		public Employee Employee { get; set; }
		[Required]
		[Description("Дата заказа")]
		public DateTime DateTime { get; set; }
		[Required]
		[Description("Сервер")]
		public Server Server { get; set; }
		[Required]
		[Description("Домен")]
		public string Domen { get; set; }
		[Required]
		[Description("Дата окончания заказа")]
		public DateTime DateOfEnd { get; set; }
		[Required]
		[Description("Цена")]
		public decimal Cost { get; set; }
		[Required]
		[MaxLength(1)]
		[Description("Валюта")]
		public string Currency { get; set; }
		[Required]
		[Description("Клиент")]
		public Client Client { get; set; }
	}
}
