namespace DesktopVersion
{
	partial class UsersControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
			System.Windows.Forms.Label labelSearch;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.labelAuthorizationsMain = new System.Windows.Forms.Label();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddUser = new System.Windows.Forms.Panel();
			this.textBoxUserLogin = new System.Windows.Forms.TextBox();
			this.buttonUserDelete = new System.Windows.Forms.Button();
			this.buttonUserAdd = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.comboBoxAccessLVL = new System.Windows.Forms.ComboBox();
			this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.panelEdit = new System.Windows.Forms.Panel();
			this.buttonClosePanelEdit = new System.Windows.Forms.Button();
			this.panelBackgroundEdit = new System.Windows.Forms.Panel();
			this.buttonOfficeConfirmEdit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxEditUserLogin = new System.Windows.Forms.TextBox();
			this.textBoxEditPassword = new System.Windows.Forms.TextBox();
			this.comboBoxEditAccessLVL = new System.Windows.Forms.ComboBox();
			this.comboBoxEditEmployees = new System.Windows.Forms.ComboBox();
			this.buttonEditShow = new Bunifu.Framework.UI.BunifuFlatButton();
			labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddUser.SuspendLayout();
			this.panelEdit.SuspendLayout();
			this.panelBackgroundEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelSearch
			// 
			labelSearch.AutoSize = true;
			labelSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelSearch.ForeColor = System.Drawing.Color.Firebrick;
			labelSearch.Location = new System.Drawing.Point(8, 25);
			labelSearch.Name = "labelSearch";
			labelSearch.Size = new System.Drawing.Size(76, 24);
			labelSearch.TabIndex = 23;
			labelSearch.Text = "Поиск";
			labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelAuthorizationsMain
			// 
			this.labelAuthorizationsMain.AutoSize = true;
			this.labelAuthorizationsMain.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.labelAuthorizationsMain.ForeColor = System.Drawing.Color.Firebrick;
			this.labelAuthorizationsMain.Location = new System.Drawing.Point(50, 0);
			this.labelAuthorizationsMain.Name = "labelAuthorizationsMain";
			this.labelAuthorizationsMain.Size = new System.Drawing.Size(179, 48);
			this.labelAuthorizationsMain.TabIndex = 5;
			this.labelAuthorizationsMain.Text = "Добавить новый\r\nаккаунт";
			this.labelAuthorizationsMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewMain
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewMain.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridViewMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3});
			this.dataGridViewMain.EnableHeadersVisualStyles = false;
			this.dataGridViewMain.HeaderBgColor = System.Drawing.Color.Firebrick;
			this.dataGridViewMain.HeaderForeColor = System.Drawing.Color.White;
			this.dataGridViewMain.Location = new System.Drawing.Point(10, 60);
			this.dataGridViewMain.Name = "dataGridViewMain";
			this.dataGridViewMain.ReadOnly = true;
			this.dataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewMain.RowHeadersVisible = false;
			this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewMain.Size = new System.Drawing.Size(1000, 750);
			this.dataGridViewMain.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Идентификатор";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Логин";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Шифр. Пароль";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Уровень доступа";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "ФИО Сотрудника";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// panelAddUser
			// 
			this.panelAddUser.Controls.Add(this.textBoxUserLogin);
			this.panelAddUser.Controls.Add(this.buttonUserDelete);
			this.panelAddUser.Controls.Add(this.buttonUserAdd);
			this.panelAddUser.Controls.Add(this.textBoxPassword);
			this.panelAddUser.Controls.Add(this.comboBoxAccessLVL);
			this.panelAddUser.Controls.Add(this.comboBoxEmployees);
			this.panelAddUser.Controls.Add(this.labelAuthorizationsMain);
			this.panelAddUser.Location = new System.Drawing.Point(1015, 10);
			this.panelAddUser.Name = "panelAddUser";
			this.panelAddUser.Size = new System.Drawing.Size(280, 800);
			this.panelAddUser.TabIndex = 1;
			// 
			// textBoxUserLogin
			// 
			this.textBoxUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxUserLogin.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxUserLogin.Location = new System.Drawing.Point(5, 157);
			this.textBoxUserLogin.MaxLength = 255;
			this.textBoxUserLogin.Multiline = true;
			this.textBoxUserLogin.Name = "textBoxUserLogin";
			this.textBoxUserLogin.Size = new System.Drawing.Size(271, 29);
			this.textBoxUserLogin.TabIndex = 16;
			this.textBoxUserLogin.Tag = "Логин";
			// 
			// buttonUserDelete
			// 
			this.buttonUserDelete.BackColor = System.Drawing.Color.Firebrick;
			this.buttonUserDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonUserDelete.ForeColor = System.Drawing.Color.White;
			this.buttonUserDelete.Location = new System.Drawing.Point(4, 745);
			this.buttonUserDelete.Name = "buttonUserDelete";
			this.buttonUserDelete.Size = new System.Drawing.Size(270, 52);
			this.buttonUserDelete.TabIndex = 15;
			this.buttonUserDelete.Text = "Удалить";
			this.buttonUserDelete.UseVisualStyleBackColor = false;
			this.buttonUserDelete.Click += new System.EventHandler(this.buttonUserDelete_Click);
			// 
			// buttonUserAdd
			// 
			this.buttonUserAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonUserAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonUserAdd.ForeColor = System.Drawing.Color.White;
			this.buttonUserAdd.Location = new System.Drawing.Point(4, 687);
			this.buttonUserAdd.Name = "buttonUserAdd";
			this.buttonUserAdd.Size = new System.Drawing.Size(270, 52);
			this.buttonUserAdd.TabIndex = 15;
			this.buttonUserAdd.Text = "Добавить";
			this.buttonUserAdd.UseVisualStyleBackColor = false;
			this.buttonUserAdd.Click += new System.EventHandler(this.buttonUserAdd_Click);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxPassword.Location = new System.Drawing.Point(4, 192);
			this.textBoxPassword.MaxLength = 255;
			this.textBoxPassword.Multiline = true;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(271, 29);
			this.textBoxPassword.TabIndex = 13;
			this.textBoxPassword.Tag = "Пароль";
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// comboBoxAccessLVL
			// 
			this.comboBoxAccessLVL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxAccessLVL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAccessLVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxAccessLVL.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxAccessLVL.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxAccessLVL.FormattingEnabled = true;
			this.comboBoxAccessLVL.Items.AddRange(new object[] {
            "Администратор",
            "Модератор",
            "Обычный пользователь"});
			this.comboBoxAccessLVL.Location = new System.Drawing.Point(4, 122);
			this.comboBoxAccessLVL.Name = "comboBoxAccessLVL";
			this.comboBoxAccessLVL.Size = new System.Drawing.Size(272, 29);
			this.comboBoxAccessLVL.TabIndex = 12;
			this.comboBoxAccessLVL.Tag = "Уровень доступа";
			// 
			// comboBoxEmployees
			// 
			this.comboBoxEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEmployees.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEmployees.FormattingEnabled = true;
			this.comboBoxEmployees.Location = new System.Drawing.Point(5, 86);
			this.comboBoxEmployees.Name = "comboBoxEmployees";
			this.comboBoxEmployees.Size = new System.Drawing.Size(272, 29);
			this.comboBoxEmployees.TabIndex = 12;
			this.comboBoxEmployees.Tag = "Сотрудник";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxSearch.Location = new System.Drawing.Point(90, 25);
			this.textBoxSearch.MaxLength = 255;
			this.textBoxSearch.Multiline = true;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(363, 29);
			this.textBoxSearch.TabIndex = 22;
			this.textBoxSearch.Tag = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// panelEdit
			// 
			this.panelEdit.BackColor = System.Drawing.Color.Firebrick;
			this.panelEdit.Controls.Add(this.buttonClosePanelEdit);
			this.panelEdit.Controls.Add(this.panelBackgroundEdit);
			this.panelEdit.Location = new System.Drawing.Point(685, 105);
			this.panelEdit.Name = "panelEdit";
			this.panelEdit.Size = new System.Drawing.Size(324, 412);
			this.panelEdit.TabIndex = 24;
			this.panelEdit.Visible = false;
			// 
			// buttonClosePanelEdit
			// 
			this.buttonClosePanelEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonClosePanelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClosePanelEdit.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClosePanelEdit.ForeColor = System.Drawing.Color.White;
			this.buttonClosePanelEdit.Location = new System.Drawing.Point(285, 3);
			this.buttonClosePanelEdit.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClosePanelEdit.Name = "buttonClosePanelEdit";
			this.buttonClosePanelEdit.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.buttonClosePanelEdit.Size = new System.Drawing.Size(33, 33);
			this.buttonClosePanelEdit.TabIndex = 17;
			this.buttonClosePanelEdit.Text = "X";
			this.buttonClosePanelEdit.UseVisualStyleBackColor = true;
			// 
			// panelBackgroundEdit
			// 
			this.panelBackgroundEdit.BackColor = System.Drawing.Color.White;
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditUserLogin);
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditPassword);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditAccessLVL);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditEmployees);
			this.panelBackgroundEdit.Controls.Add(this.buttonOfficeConfirmEdit);
			this.panelBackgroundEdit.Controls.Add(this.label1);
			this.panelBackgroundEdit.Location = new System.Drawing.Point(3, 39);
			this.panelBackgroundEdit.Name = "panelBackgroundEdit";
			this.panelBackgroundEdit.Size = new System.Drawing.Size(318, 370);
			this.panelBackgroundEdit.TabIndex = 0;
			// 
			// buttonOfficeConfirmEdit
			// 
			this.buttonOfficeConfirmEdit.BackColor = System.Drawing.Color.Firebrick;
			this.buttonOfficeConfirmEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonOfficeConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOfficeConfirmEdit.Font = new System.Drawing.Font("Century Gothic", 13.75F);
			this.buttonOfficeConfirmEdit.ForeColor = System.Drawing.Color.White;
			this.buttonOfficeConfirmEdit.Location = new System.Drawing.Point(3, 321);
			this.buttonOfficeConfirmEdit.Name = "buttonOfficeConfirmEdit";
			this.buttonOfficeConfirmEdit.Size = new System.Drawing.Size(312, 46);
			this.buttonOfficeConfirmEdit.TabIndex = 15;
			this.buttonOfficeConfirmEdit.Text = "Подтвердить изменение";
			this.buttonOfficeConfirmEdit.UseVisualStyleBackColor = false;
			this.buttonOfficeConfirmEdit.Click += new System.EventHandler(this.buttonOfficeConfirmEdit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 13.75F);
			this.label1.ForeColor = System.Drawing.Color.Firebrick;
			this.label1.Location = new System.Drawing.Point(102, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 22);
			this.label1.TabIndex = 5;
			this.label1.Text = "Изменение";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxEditUserLogin
			// 
			this.textBoxEditUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditUserLogin.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditUserLogin.Location = new System.Drawing.Point(27, 98);
			this.textBoxEditUserLogin.MaxLength = 255;
			this.textBoxEditUserLogin.Multiline = true;
			this.textBoxEditUserLogin.Name = "textBoxEditUserLogin";
			this.textBoxEditUserLogin.Size = new System.Drawing.Size(271, 29);
			this.textBoxEditUserLogin.TabIndex = 20;
			this.textBoxEditUserLogin.Tag = "Логин";
			// 
			// textBoxEditPassword
			// 
			this.textBoxEditPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditPassword.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditPassword.Location = new System.Drawing.Point(26, 133);
			this.textBoxEditPassword.MaxLength = 255;
			this.textBoxEditPassword.Multiline = true;
			this.textBoxEditPassword.Name = "textBoxEditPassword";
			this.textBoxEditPassword.Size = new System.Drawing.Size(271, 29);
			this.textBoxEditPassword.TabIndex = 19;
			this.textBoxEditPassword.Tag = "Пароль";
			this.textBoxEditPassword.UseSystemPasswordChar = true;
			// 
			// comboBoxEditAccessLVL
			// 
			this.comboBoxEditAccessLVL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditAccessLVL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditAccessLVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditAccessLVL.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditAccessLVL.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditAccessLVL.FormattingEnabled = true;
			this.comboBoxEditAccessLVL.Items.AddRange(new object[] {
            "Администратор",
            "Модератор",
            "Обычный пользователь"});
			this.comboBoxEditAccessLVL.Location = new System.Drawing.Point(26, 63);
			this.comboBoxEditAccessLVL.Name = "comboBoxEditAccessLVL";
			this.comboBoxEditAccessLVL.Size = new System.Drawing.Size(272, 29);
			this.comboBoxEditAccessLVL.TabIndex = 17;
			this.comboBoxEditAccessLVL.Tag = "Уровень доступа";
			// 
			// comboBoxEditEmployees
			// 
			this.comboBoxEditEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditEmployees.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditEmployees.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditEmployees.FormattingEnabled = true;
			this.comboBoxEditEmployees.Location = new System.Drawing.Point(27, 27);
			this.comboBoxEditEmployees.Name = "comboBoxEditEmployees";
			this.comboBoxEditEmployees.Size = new System.Drawing.Size(272, 29);
			this.comboBoxEditEmployees.TabIndex = 18;
			this.comboBoxEditEmployees.Tag = "Сотрудник";
			// 
			// buttonEditShow
			// 
			this.buttonEditShow.Activecolor = System.Drawing.Color.Brown;
			this.buttonEditShow.BackColor = System.Drawing.Color.Firebrick;
			this.buttonEditShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonEditShow.BorderRadius = 0;
			this.buttonEditShow.ButtonText = "Изменить";
			this.buttonEditShow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonEditShow.DisabledColor = System.Drawing.Color.Gray;
			this.buttonEditShow.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonEditShow.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonEditShow.Iconimage = null;
			this.buttonEditShow.Iconimage_right = null;
			this.buttonEditShow.Iconimage_right_Selected = null;
			this.buttonEditShow.Iconimage_Selected = null;
			this.buttonEditShow.IconMarginLeft = 0;
			this.buttonEditShow.IconMarginRight = 0;
			this.buttonEditShow.IconRightVisible = false;
			this.buttonEditShow.IconRightZoom = 0D;
			this.buttonEditShow.IconVisible = false;
			this.buttonEditShow.IconZoom = 70D;
			this.buttonEditShow.IsTab = false;
			this.buttonEditShow.Location = new System.Drawing.Point(819, 24);
			this.buttonEditShow.Margin = new System.Windows.Forms.Padding(5);
			this.buttonEditShow.Name = "buttonEditShow";
			this.buttonEditShow.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonEditShow.OnHovercolor = System.Drawing.Color.Brown;
			this.buttonEditShow.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonEditShow.selected = false;
			this.buttonEditShow.Size = new System.Drawing.Size(191, 34);
			this.buttonEditShow.TabIndex = 21;
			this.buttonEditShow.Text = "Изменить";
			this.buttonEditShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonEditShow.Textcolor = System.Drawing.Color.White;
			this.buttonEditShow.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonEditShow.Click += new System.EventHandler(this.buttonOfficeEditShow_Click);
			// 
			// UsersControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.buttonEditShow);
			this.Controls.Add(this.panelEdit);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddUser);
			this.Controls.Add(this.dataGridViewMain);
			this.DoubleBuffered = true;
			this.Name = "UsersControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddUser.ResumeLayout(false);
			this.panelAddUser.PerformLayout();
			this.panelEdit.ResumeLayout(false);
			this.panelBackgroundEdit.ResumeLayout(false);
			this.panelBackgroundEdit.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddUser;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonUserAdd;
		private System.Windows.Forms.Button buttonUserDelete;
		private System.Windows.Forms.TextBox textBoxUserLogin;
		private System.Windows.Forms.Label labelAuthorizationsMain;
		private System.Windows.Forms.ComboBox comboBoxAccessLVL;
		private System.Windows.Forms.ComboBox comboBoxEmployees;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Panel panelEdit;
		private System.Windows.Forms.Button buttonClosePanelEdit;
		private System.Windows.Forms.Button buttonOfficeConfirmEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxEditUserLogin;
		private System.Windows.Forms.TextBox textBoxEditPassword;
		private System.Windows.Forms.ComboBox comboBoxEditAccessLVL;
		private System.Windows.Forms.ComboBox comboBoxEditEmployees;
		private Bunifu.Framework.UI.BunifuFlatButton buttonEditShow;
		private System.Windows.Forms.Panel panelBackgroundEdit;
	}
}
