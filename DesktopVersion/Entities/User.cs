using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesktopVersion.Entities
{
	[Table("users")]
	public class User
	{
		public static String[] S_Access = {
			"Администратор",
			"Модератор",
			"Обычный пользователь"
		};
		public enum E_Access
		{
			Administrator,
			Moderator,
			SimpleUser
		}

		[Key]
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]//Указатель Уникальность / Без дубликатов
		[MaxLength(16)]
		[Description("Логин")]
		public string Username { get; set; }
		[Required]
		[MaxLength(32)]
		[Description("Зашифр. пароль")]
		public string Password { get; set; }
		[Required, Description("Уровень привелегий")]
		public E_Access AccessLVL { get; set; }
		[Required, Description("Сотрудник")]
		public virtual Employee Employee { get; set; }
		public override string ToString()
		{
			return Username;
		}
	}
}