using DesktopVersion.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class AuthorizationsControl : UserControl
	{
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
				
				SessionClass.Instance().User = SessionClass.Instance().Context.Users.FirstOrDefault(u =>
					u.Username == textBoxUsername.Text &&
					u.Password == HashPass);
				var user = SessionClass.Instance().User;
				var form = SessionClass.Instance().Form;
				if (user == null)
				{
					MessageBox.Show("Неправильный логин или пароль");
					return;
				}
				form.labelName.Text = $"{User.S_Access[(int)user.AccessLVL]} | " +
					$"{user.Employee.Name} " +
					$"{user.Employee.Surname[0]}." +
					$"{user.Employee.Patronymic[0]}.";
				form.panelMain.Controls.Clear();
				form.panelMenu.Visible = true;
				form.labelTopPanel.Text = "Главное меню";

				switch (SessionClass.Instance().User.AccessLVL)
				{
					case User.E_Access.Administrator:
						form.buttonMenu3.Enabled = true;
						form.buttonMenu4.Enabled = true;
						break;
					case User.E_Access.Moderator:
						form.buttonMenu3.Enabled = true;
						form.buttonMenu4.Enabled = false;
						break;
					case User.E_Access.SimpleUser:
						form.buttonMenu3.Enabled = false;
						form.buttonMenu4.Enabled = false;
						break;
				}
				form.pictureBoxBackGround.Visible = true;

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
