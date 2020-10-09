using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class MainForm : Form
	{
		private bool dragging = false;
		private Point dragCursorPoint, dragFormPoint;
		public MainForm()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			SessionClass.init().Form = this;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#region DragByPanelTop
		private void panelTop_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = Location;
		}

		private void panelTop_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void panelTop_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		#endregion


		private void HideTextOnMenuButtons()
		{
			buttonMenu1.ButtonText = String.Empty;
			buttonMenu2.ButtonText = String.Empty;
			buttonMenu3.ButtonText = String.Empty;
			buttonMenu4.ButtonText = String.Empty;
			buttonMenu5.ButtonText = String.Empty;
		}

		private void ShowTextOnMenuButtons()//Умнее этого костыля ничего не придумал
		{
			buttonMenu1.ButtonText = "Предметы";
			buttonMenu2.ButtonText = "Сотрудники";
			buttonMenu3.ButtonText = "Офисы";
			buttonMenu4.ButtonText = "Пользователи";
			buttonMenu5.ButtonText = "Выйти";
		}

		private void buttonsMenu_Click(object sender, EventArgs e)//Открытие нужного контрола используя тэг кнопок
		{
			//panelMain.Visible = !panelMain.Visible;
			//MessageBox.Show("У вас нет доступа к добавлению новых пользоватлей. Пожалуйста свяжитесь с вашим администратором");
			pictureBoxBackGround.Visible = false;
			Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)sender;
			UserControlController.init().ChangeControl((UserControlController.E_Control)btn.Tag);
		}

		private void buttonMenu5_Click(object sender, EventArgs e)
		{
			pictureBoxBackGround.Visible = false;
			panelMain.Controls.Clear();
			panelMenu.Visible = false;
			labelName.Text = "";
			UserControlController.init().ChangeControl(UserControlController.E_Control.AuthControl);
		}

		private void timerMenu_Tick(object sender, EventArgs e)//Всегда активный таймер отвечающий за работу меню
		{
			if (panelMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
			{
				panelMenu.Width = 300;
				this.pictureBoxLogoInMenu.Image = Properties.Resources.varnoffLogoWhite;
				ShowTextOnMenuButtons();

			}
			else
			{
				panelMenu.Width = 67;
				HideTextOnMenuButtons();
				this.pictureBoxLogoInMenu.Image = Properties.Resources.varnoffLogoWhiteMini;
			}
		}
	}

}
