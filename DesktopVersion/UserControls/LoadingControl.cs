using DesktopVersion.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class LoadingControl : UserControl
	{
		public LoadingControl()
		{
			InitializeComponent();
		}

		private void LoadingControl_Load(object sender, EventArgs e)
		{
			if (ConnSettingControl.CheckConnection(ConnSettingControl.GetConnString()))
				UserControlController.Instance().ChangeControl(UserControlController.E_Control.AuthControl);
			else
			{
				MessageBox.Show("Не удалось подключится к базе проверьте настройки подключения");
				UserControlController.Instance().ChangeControl(UserControlController.E_Control.ConnSettingControl);
			}
		}
	}
}
