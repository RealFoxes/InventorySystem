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
			SessionClass.Instance().Context = new MySQLModel();
			SessionClass.Instance().Context.Database.Initialize(true);
			UserControlController.Instance().ChangeControl(UserControlController.E_Control.AuthControl);
		}
	}
}
