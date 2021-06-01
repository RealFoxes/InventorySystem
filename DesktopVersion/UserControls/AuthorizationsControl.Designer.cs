namespace DesktopVersion
{
	partial class AuthorizationsControl
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label labelAuthorizationsMain;
			System.Windows.Forms.Label lableNoAcc;
			this.textBoxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.buttonAuth = new Bunifu.Framework.UI.BunifuFlatButton();
			this.buttonConn = new System.Windows.Forms.Button();
			labelAuthorizationsMain = new System.Windows.Forms.Label();
			lableNoAcc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelAuthorizationsMain
			// 
			labelAuthorizationsMain.AutoSize = true;
			labelAuthorizationsMain.Font = new System.Drawing.Font("Century Gothic", 20.75F);
			labelAuthorizationsMain.ForeColor = System.Drawing.Color.Firebrick;
			labelAuthorizationsMain.Location = new System.Drawing.Point(2, 1);
			labelAuthorizationsMain.Name = "labelAuthorizationsMain";
			labelAuthorizationsMain.Size = new System.Drawing.Size(280, 34);
			labelAuthorizationsMain.TabIndex = 4;
			labelAuthorizationsMain.Text = "Войдите в систему";
			// 
			// lableNoAcc
			// 
			lableNoAcc.AutoSize = true;
			lableNoAcc.Font = new System.Drawing.Font("Century Gothic", 13.75F, System.Drawing.FontStyle.Underline);
			lableNoAcc.ForeColor = System.Drawing.Color.Firebrick;
			lableNoAcc.Location = new System.Drawing.Point(4, 249);
			lableNoAcc.Name = "lableNoAcc";
			lableNoAcc.Size = new System.Drawing.Size(206, 22);
			lableNoAcc.TabIndex = 4;
			lableNoAcc.Text = "Отсуствует аккаунт?";
			lableNoAcc.Click += new System.EventHandler(this.lableNoAcc_Click);
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 12.75F);
			this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBoxUsername.HintForeColor = System.Drawing.Color.Gray;
			this.textBoxUsername.HintText = "Логин";
			this.textBoxUsername.isPassword = false;
			this.textBoxUsername.LineFocusedColor = System.Drawing.Color.Firebrick;
			this.textBoxUsername.LineIdleColor = System.Drawing.Color.Firebrick;
			this.textBoxUsername.LineMouseHoverColor = System.Drawing.Color.Firebrick;
			this.textBoxUsername.LineThickness = 4;
			this.textBoxUsername.Location = new System.Drawing.Point(8, 66);
			this.textBoxUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(500, 50);
			this.textBoxUsername.TabIndex = 1;
			this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12.75F);
			this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBoxPassword.HintForeColor = System.Drawing.Color.Gray;
			this.textBoxPassword.HintText = "Пароль";
			this.textBoxPassword.isPassword = false;
			this.textBoxPassword.LineFocusedColor = System.Drawing.Color.Firebrick;
			this.textBoxPassword.LineIdleColor = System.Drawing.Color.Firebrick;
			this.textBoxPassword.LineMouseHoverColor = System.Drawing.Color.Firebrick;
			this.textBoxPassword.LineThickness = 4;
			this.textBoxPassword.Location = new System.Drawing.Point(8, 148);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(500, 50);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxPassword.OnValueChanged += new System.EventHandler(this.textBoxPassword_OnValueChanged);
			// 
			// buttonAuth
			// 
			this.buttonAuth.Activecolor = System.Drawing.Color.Brown;
			this.buttonAuth.BackColor = System.Drawing.Color.Firebrick;
			this.buttonAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAuth.BorderRadius = 0;
			this.buttonAuth.ButtonText = "   Авторизоваться";
			this.buttonAuth.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAuth.DisabledColor = System.Drawing.Color.Gray;
			this.buttonAuth.Font = new System.Drawing.Font("Century Gothic", 8.75F);
			this.buttonAuth.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonAuth.Iconimage = global::DesktopVersion.Properties.Resources.loginInIcon;
			this.buttonAuth.Iconimage_right = null;
			this.buttonAuth.Iconimage_right_Selected = null;
			this.buttonAuth.Iconimage_Selected = null;
			this.buttonAuth.IconMarginLeft = 0;
			this.buttonAuth.IconMarginRight = 0;
			this.buttonAuth.IconRightVisible = true;
			this.buttonAuth.IconRightZoom = 0D;
			this.buttonAuth.IconVisible = true;
			this.buttonAuth.IconZoom = 70D;
			this.buttonAuth.IsTab = false;
			this.buttonAuth.Location = new System.Drawing.Point(296, 217);
			this.buttonAuth.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAuth.Name = "buttonAuth";
			this.buttonAuth.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonAuth.OnHovercolor = System.Drawing.Color.Brown;
			this.buttonAuth.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonAuth.selected = false;
			this.buttonAuth.Size = new System.Drawing.Size(212, 54);
			this.buttonAuth.TabIndex = 5;
			this.buttonAuth.Text = "   Авторизоваться";
			this.buttonAuth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAuth.Textcolor = System.Drawing.Color.White;
			this.buttonAuth.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
			// 
			// buttonConn
			// 
			this.buttonConn.BackColor = System.Drawing.Color.Firebrick;
			this.buttonConn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConn.Font = new System.Drawing.Font("Century Gothic", 14.75F);
			this.buttonConn.ForeColor = System.Drawing.Color.White;
			this.buttonConn.Location = new System.Drawing.Point(238, 288);
			this.buttonConn.Name = "buttonConn";
			this.buttonConn.Size = new System.Drawing.Size(270, 52);
			this.buttonConn.TabIndex = 19;
			this.buttonConn.Text = "Настройка подключения";
			this.buttonConn.UseVisualStyleBackColor = false;
			this.buttonConn.Click += new System.EventHandler(this.buttonConn_Click);
			// 
			// AuthorizationsControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.buttonConn);
			this.Controls.Add(this.buttonAuth);
			this.Controls.Add(lableNoAcc);
			this.Controls.Add(labelAuthorizationsMain);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Name = "AuthorizationsControl";
			this.Size = new System.Drawing.Size(530, 343);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxUsername;
		private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
		private Bunifu.Framework.UI.BunifuFlatButton buttonAuth;
		private System.Windows.Forms.Button buttonConn;
	}
}
