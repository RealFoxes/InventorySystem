using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class MainForm : Form
	{
		private bool dragging = false;
		private Point dragCursorPoint, dragFormPoint;
		//public clsResize FormResize;
		public MainForm()
		{
			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);
			SessionClass.Instance().Form = this;
			//this.AutoScaleMode = AutoScaleMode.Dpi;
			//FormResize = new clsResize(this);
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
			buttonMenu6.ButtonText = String.Empty;
			button7.ButtonText = String.Empty;
		}

		private void ShowTextOnMenuButtons()//Умнее этого костыля ничего не придумал
		{
			buttonMenu1.ButtonText = "Серверы";
			buttonMenu2.ButtonText = "Сотрудники";
			buttonMenu3.ButtonText = "Офисы";
			buttonMenu4.ButtonText = "Пользователи";
			buttonMenu5.ButtonText = "Выйти";
			buttonMenu6.ButtonText = "Заказы";
			button7.ButtonText = "Перейти на сайт";
		}

		private void buttonsMenu_Click(object sender, EventArgs e)//Открытие нужного контрола используя тэг кнопок
		{
			pictureBoxBackGround.Visible = false;
			Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)sender;
			UserControlController.Instance().ChangeControl((UserControlController.E_Control)btn.Tag);
		}

		private void buttonMenu5_Click(object sender, EventArgs e)
		{
			pictureBoxBackGround.Visible = false;
			panelMain.Controls.Clear();
			panelMenu.Visible = false;
			labelName.Text = "";
			UserControlController.Instance().ChangeControl(UserControlController.E_Control.AuthControl);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://varnoff-studio.ru/");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
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
