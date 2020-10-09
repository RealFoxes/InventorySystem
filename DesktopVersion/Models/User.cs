//Язык регильаные старндарт > Дополнительные параметры > РАзделитель дробной чатси поставить .
//MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
//builder.Server = "localhost";
//builder.Port = 3306;
//builder.Database = "InventorySystem";
//builder.UserID = "root";
//builder.Password = "";
//builder.CharacterSet = "utf8";
//Console.WriteLine(builder.ConnectionString);// server=localhost;port=3306;database=InventorySystem;user id=root;password=;characterset=utf8

// enable-migrations | add-migration <NameMigration> | update-database

namespace DesktopVersion
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	#region MyClasses
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

		[Key]//Указать ключегово индекса Primery Key
		public int Id { get; set; }
		[Required]//Указатель Обязательного поля NOTNULL
		[Index(IsUnique = true)]//Указатель Уникальность / Без дубликатов
		[MaxLength(16)]//Указать на максимальную длину
		public string Username { get; set; }
		[Required]
		[MaxLength(32)]
		public string Password { get; set; }
		[Required]
		public E_Access AccessLVL { get; set; }
		[Required]
		public virtual Employee Employee { get; set; }
	}
	#endregion
}