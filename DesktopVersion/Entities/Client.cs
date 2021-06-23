using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopVersion.Entities
{
	[Table("clients")]
	public class Client
	{
		[Key]
		public int Id { get; set; }
		[Required,Description("ФИО")]
		public string FullName { get; set; }
		[Required, Description("Номер телефона")]
		public string PhoneNumber { get; set; }
		public List<Order> Orders { get; set; }
		public Client()
		{
			Orders = new List<Order>();
		}
		public override string ToString()
		{
			return FullName;
		}
	}
}
