namespace DesktopVersion
{
	class SessionClass
	{
		private static SessionClass instance;
		public static SessionClass init()
		{
			if (instance == null)
				instance = new SessionClass();
			return instance;
		}

		public User user { get; set; }
		public MySQLModel Model { get; set; }
		public MainForm Form { get; set; }
	}
}
