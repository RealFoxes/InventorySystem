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
			ItemsControl,
			EmployeeContorl,
			OfficesContorl,
			UsersContorl
		}

		private static UserControlController instance; 
		public static UserControlController init()     
		{                                              
			if (instance == null)                      
				instance = new UserControlController();
			return instance;                           
		}

		private UserControlController()
		{
			this.Form = new MainForm();                 //Создаем Основную форму при этом изменив запуск программы в Program.cs
			Form.Show();
		}

		public void ChangeControl(E_Control E_Controls)//Основая функция класса позволяющая менять контролы
		{
			UserControl Control = new UserControl();   //Объявляем пустой юзерконтрол
			Form.panelMain.Controls.Clear();           //Очищаем панель в основной форме
			switch (E_Controls)
			{
				case E_Control.AuthControl:
					Form.labelTopPanel.Text = "Авторизация";
					Control = new AuthorizationsControl();
					break;
				case E_Control.ItemsControl:
					Form.labelTopPanel.Text = "Инвентаризация";
					Control = new ItemsControl();
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

			}                      //Проверяем принимаемы enum и записываем в пустой контрол наш контрол
			if (E_Controls == E_Control.AuthControl)
			{
				Form.panelMain.Dock = DockStyle.None;
				Form.panelMain.Width = Control.Width;
				Form.panelMain.Height = Control.Height;
				Form.panelMain.Controls.Add(Control);
				Form.panelMain.Location = new Point(Form.Width / 2 - Control.Width / 2, Form.Height / 2 - Control.Height / 2);//align center
			}
			else
			{
				Form.panelMain.Dock = DockStyle.Fill;
				Form.panelMain.Controls.Add(Control);
			}
		}
	}
}
