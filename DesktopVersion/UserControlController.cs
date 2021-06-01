using System.Drawing;
using System.Windows.Forms;

namespace DesktopVersion
{
	class UserControlController
	{
		private MainForm Form;

		public enum E_Control
		{
			AuthControl,
			ServerControl,
			EmployeeContorl,
			OfficesContorl,
			UsersContorl,
			OrdersControl,
			LoadingControl,
			ConnSettingControl
		}

		private static UserControlController instance; 
		public static UserControlController Instance()     
		{                                              
			if (instance == null)                      
				instance = new UserControlController();
			return instance;                           
		}

		private UserControlController()
		{
			this.Form = new MainForm(); //Создаем Основную форму при этом изменив запуск программы в Program.cs
			Form.Show();
		}

		public void ChangeControl(E_Control E_Controls) //Основая функция класса позволяющая менять контролы
		{
			UserControl Control = new UserControl(); //Объявляем пустой юзерконтрол
			Form.panelMain.Controls.Clear(); //Очищаем панель в основной форме
			switch (E_Controls) //Проверяем принимаемы enum и записываем в пустой контрол наш контрол
			{
				case E_Control.AuthControl:
					Form.labelTopPanel.Text = "Авторизация";
					Control = new AuthorizationsControl();
					break;
				case E_Control.ServerControl:
					Form.labelTopPanel.Text = "Сервера";
					Control = new ServersControl();
					break;
				case E_Control.EmployeeContorl:
					Form.labelTopPanel.Text = "Учет сотрудников";
					Control = new EmployeesControl();
					break;
				case E_Control.OfficesContorl:
					Form.labelTopPanel.Text = "Офисы";
					Control = new OfficeControl();
					break;
				case E_Control.UsersContorl:
					Form.labelTopPanel.Text = "Учет пользователей";
					Control = new UsersControl();
					break;
				case E_Control.OrdersControl:
					Form.labelTopPanel.Text = "Заказы";
					Control = new OrdersControl();
					break;
				case E_Control.LoadingControl:
					Form.labelTopPanel.Text = "Мониторинг серверов и бугалтерия";
					Control = new LoadingControl();
					break;
				case E_Control.ConnSettingControl:
					Form.labelTopPanel.Text = "Настройка подключения";
					Control = new ConnSettingControl();
					break;

			}                      
			if  (  E_Controls == E_Control.AuthControl
				|| E_Controls == E_Control.LoadingControl
				|| E_Controls == E_Control.ConnSettingControl)
			{
				Form.panelMain.Dock = DockStyle.None;
				Form.panelMain.Width = Control.Width;
				Form.panelMain.Height = Control.Height;
				Form.panelMain.Controls.Add(Control);
				Form.panelMain.Location = new Point(Form.Width / 2 - Control.Width / 2, Form.Height / 2 - Control.Height / 2);//Центруем юзерКонтрол по центру
			}
			else
			{
				Form.panelMain.Dock = DockStyle.Fill;
				Form.panelMain.Controls.Add(Control);
			}
		}
	}
}
