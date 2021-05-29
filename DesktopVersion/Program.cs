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
			UserControlController.Instance().ChangeControl(UserControlController.E_Control.LoadingControl); //Инициализируем класс и сразу же вызываем функцию
			Application.Run();//Убрали запуск формы по умолчанию
		}
	}
}
