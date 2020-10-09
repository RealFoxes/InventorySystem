using System;
using System.Windows.Forms;

namespace DesktopVersion
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			UserControlController.init().ChangeControl(UserControlController.E_Control.AuthControl); //Инициализируем класс и сразу же вызываем функцию
			SessionClass.init().Model = new MySQLModel();
			SessionClass.init().Model.Database.Initialize(false);
			Application.Run();//Убрали запуск формы по умолчанию
		}
	}
}
