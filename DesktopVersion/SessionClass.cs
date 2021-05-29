using DesktopVersion.Entities;

namespace DesktopVersion
{
	class SessionClass
	{
		private static SessionClass instance;
		public static SessionClass Instance()
		{
			if (instance == null)
				instance = new SessionClass();
			return instance;
		}
		public SessionClass()
		{
			Context = new MySQLModel();
		}
		public User User { get; set; }
		public MySQLModel Context { get; set; }
		public MainForm Form { get; set; }
	}
}
