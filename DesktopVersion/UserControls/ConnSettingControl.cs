using DesktopVersion.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class ConnSettingControl : UserControl
	{
		private MySqlConnectionStringBuilder builder;
		public ConnSettingControl()
		{
			InitializeComponent(); 
			var connectionString = ConfigurationManager.ConnectionStrings["MySQLModel"].ConnectionString;
			builder = new MySqlConnectionStringBuilder(connectionString);

			textBoxHost.Text = builder.Server;
			textBoxLogin.Text = builder.UserID;
			textBoxPassword.Text = builder.Password;
			textBoxNameOfBase.Text = builder.Database;
			textBoxPort.Text = builder.Port.ToString();
		}
		public static string GetConnString()
		{
			return ConfigurationManager.ConnectionStrings["MySQLModel"].ConnectionString;
		}
		public static bool CheckConnection(string connStr)
		{
			SessionClass.Instance().Context.Database.Connection.ConnectionString = connStr;

			return SessionClass.Instance().Context.Database.Exists();
		}
		private void SaveConfig(string connStr)
		{
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
			connectionStringsSection.ConnectionStrings["MySQLModel"].ConnectionString = connStr;
			config.Save();
			ConfigurationManager.RefreshSection("connectionStrings");
		}

		private void buttonTryConn_Click(object sender, EventArgs e)
		{
			builder.Server = textBoxHost.Text;
			builder.UserID = textBoxLogin.Text;
			builder.Password = textBoxPassword.Text;
			builder.Database = textBoxNameOfBase.Text;
			builder.Port = Convert.ToUInt32(textBoxPort.Text);
			bool isConnected = CheckConnection(builder.ToString());
			buttonSaveConn.Enabled = isConnected;

			if (isConnected)
				MessageBox.Show("Проверка прошла успешна!");
			else
				MessageBox.Show("Не удалось подключится!");
		}

		private void buttonSaveConn_Click(object sender, EventArgs e)
		{
			builder.Server = textBoxHost.Text;
			builder.UserID = textBoxLogin.Text;
			builder.Password = textBoxPassword.Text;
			builder.Database = textBoxNameOfBase.Text;
			builder.Port = Convert.ToUInt32(textBoxPort.Text);

			SaveConfig(builder.ToString());
			UserControlController.Instance().ChangeControl(UserControlController.E_Control.AuthControl);
		}

		private void textBoxPort_TextChanged(object sender, EventArgs e)
		{
			buttonSaveConn.Enabled = false;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			UserControlController.Instance().ChangeControl(UserControlController.E_Control.AuthControl);
		}
	}
}
