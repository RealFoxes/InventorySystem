using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class AuthorizationsControl : UserControl
	{
		private SessionClass Session = SessionClass.init();
		private MySQLModel Model = SessionClass.init().Model;

		public AuthorizationsControl()
		{
			InitializeComponent();
		}

		private void textBoxPassword_OnValueChanged(object sender, EventArgs e)
		{
			if (textBoxPassword.Text.Length < 1) textBoxPassword.isPassword = false;
			else textBoxPassword.isPassword = true;
		}

		private void buttonAuth_Click(object sender, EventArgs e)
		{

			try
			{
				var HashPass = Utilities.GenerateHash(textBoxPassword.Text);
				SessionClass.init().user = SessionClass.init().Model.Users
					.Where(u => u.Username == textBoxUserName.Text)
					.Where(p => p.Password == HashPass).First(); //Авторизация

				SessionClass.init().Form.labelName.Text = $"{User.S_Access[(int)SessionClass.init().user.AccessLVL]} | {SessionClass.init().user.Employee.Name.ToString()} {SessionClass.init().user.Employee.Surname.ToString()[0]}.{SessionClass.init().user.Employee.Patronymic.ToString()[0]}.";
				SessionClass.init().Form.panelMain.Controls.Clear();
				SessionClass.init().Form.panelMenu.Visible = true;
				SessionClass.init().Form.labelTopPanel.Text = "Главное меню";
				switch (SessionClass.init().user.AccessLVL)
				{
					case User.E_Access.Administrator:
						SessionClass.init().Form.buttonMenu3.Enabled = true;
						SessionClass.init().Form.buttonMenu4.Enabled = true;
						break;
					case User.E_Access.Moderator:
						SessionClass.init().Form.buttonMenu3.Enabled = true;
						SessionClass.init().Form.buttonMenu4.Enabled = false;
						break;
					case User.E_Access.SimpleUser:
						SessionClass.init().Form.buttonMenu3.Enabled = false;
						SessionClass.init().Form.buttonMenu4.Enabled = false;
						break;
				}
				SessionClass.init().Form.pictureBoxBackGround.Visible = true;

			}
			catch (Exception er)
			{
				MessageBox.Show("Ошбика авторизации\nОшбика: " + er.Message);
			}
		}

		private void lableNoAcc_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Обратитесь к администратору для проведения регистрации");
		}
	}
}
