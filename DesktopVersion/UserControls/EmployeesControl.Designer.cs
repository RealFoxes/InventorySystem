namespace DesktopVersion
{
	partial class EmployeesControl
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
			System.Windows.Forms.Label labelRight1;
			System.Windows.Forms.Label labelRight2;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.Label labelSearch;
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddEmployee = new System.Windows.Forms.Panel();
			this.datepickerBirthday = new ns1.BunifuDatepicker();
			this.textBoxItemPatronymic = new System.Windows.Forms.TextBox();
			this.textBoxItemSurname = new System.Windows.Forms.TextBox();
			this.textBoxItemName = new System.Windows.Forms.TextBox();
			this.buttonItemDelete = new System.Windows.Forms.Button();
			this.buttonItemAdd = new System.Windows.Forms.Button();
			this.buttonAddNewJobPosition = new Bunifu.Framework.UI.BunifuFlatButton();
			this.comboBoxJobPosition = new System.Windows.Forms.ComboBox();
			this.comboBoxOffices = new System.Windows.Forms.ComboBox();
			this.panelAddJobPosition = new System.Windows.Forms.Panel();
			this.TextBoxAddJobPosition = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.buttonAddJobPositionAdd = new System.Windows.Forms.Button();
			this.buttonAddJobPositionDelete = new System.Windows.Forms.Button();
			this.dataGridJobPosition = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonClosePanelAddJobPosition = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			labelRight1 = new System.Windows.Forms.Label();
			labelRight2 = new System.Windows.Forms.Label();
			labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddEmployee.SuspendLayout();
			this.panelAddJobPosition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJobPosition)).BeginInit();
			this.SuspendLayout();
			// 
			// labelRight1
			// 
			labelRight1.AutoSize = true;
			labelRight1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelRight1.ForeColor = System.Drawing.Color.Firebrick;
			labelRight1.Location = new System.Drawing.Point(50, 0);
			labelRight1.Name = "labelRight1";
			labelRight1.Size = new System.Drawing.Size(188, 48);
			labelRight1.TabIndex = 5;
			labelRight1.Text = "Добавить нового\r\nсотрудника";
			labelRight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRight2
			// 
			labelRight2.AutoSize = true;
			labelRight2.Font = new System.Drawing.Font("Century Gothic", 10F);
			labelRight2.ForeColor = System.Drawing.Color.Firebrick;
			labelRight2.Location = new System.Drawing.Point(3, 235);
			labelRight2.Name = "labelRight2";
			labelRight2.Size = new System.Drawing.Size(122, 19);
			labelRight2.TabIndex = 5;
			labelRight2.Text = "Дата рождения:";
			labelRight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Отчество,
            this.Column6,
            this.Column3});
			this.dataGridViewMain.DoubleBuffered = true;
			this.dataGridViewMain.EnableHeadersVisualStyles = false;
			this.dataGridViewMain.HeaderBgColor = System.Drawing.Color.Firebrick;
			this.dataGridViewMain.HeaderForeColor = System.Drawing.Color.White;
			this.dataGridViewMain.Location = new System.Drawing.Point(10, 60);
			this.dataGridViewMain.Name = "dataGridViewMain";
			this.dataGridViewMain.ReadOnly = true;
			this.dataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewMain.RowHeadersVisible = false;
			this.dataGridViewMain.RowHeadersWidth = 100;
			this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewMain.Size = new System.Drawing.Size(1000, 750);
			this.dataGridViewMain.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Идентификатор";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Должность";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Имя";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Фамилия";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Отчество
			// 
			this.Отчество.HeaderText = "Отчество";
			this.Отчество.Name = "Отчество";
			this.Отчество.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Дата рождения";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Офис";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// panelAddEmployee
			// 
			this.panelAddEmployee.Controls.Add(this.datepickerBirthday);
			this.panelAddEmployee.Controls.Add(this.textBoxItemPatronymic);
			this.panelAddEmployee.Controls.Add(this.textBoxItemSurname);
			this.panelAddEmployee.Controls.Add(this.textBoxItemName);
			this.panelAddEmployee.Controls.Add(this.buttonItemDelete);
			this.panelAddEmployee.Controls.Add(this.buttonItemAdd);
			this.panelAddEmployee.Controls.Add(this.buttonAddNewJobPosition);
			this.panelAddEmployee.Controls.Add(this.comboBoxJobPosition);
			this.panelAddEmployee.Controls.Add(this.comboBoxOffices);
			this.panelAddEmployee.Controls.Add(labelRight2);
			this.panelAddEmployee.Controls.Add(labelRight1);
			this.panelAddEmployee.Location = new System.Drawing.Point(1015, 10);
			this.panelAddEmployee.Name = "panelAddEmployee";
			this.panelAddEmployee.Size = new System.Drawing.Size(280, 800);
			this.panelAddEmployee.TabIndex = 1;
			// 
			// datepickerBirthday
			// 
			this.datepickerBirthday.BackColor = System.Drawing.Color.Firebrick;
			this.datepickerBirthday.BorderRadius = 0;
			this.datepickerBirthday.ForeColor = System.Drawing.Color.White;
			this.datepickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.datepickerBirthday.FormatCustom = null;
			this.datepickerBirthday.Location = new System.Drawing.Point(6, 257);
			this.datepickerBirthday.Name = "datepickerBirthday";
			this.datepickerBirthday.Size = new System.Drawing.Size(271, 30);
			this.datepickerBirthday.TabIndex = 6;
			this.datepickerBirthday.Value = new System.DateTime(2020, 5, 20, 3, 6, 1, 333);
			// 
			// textBoxItemPatronymic
			// 
			this.textBoxItemPatronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxItemPatronymic.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxItemPatronymic.Location = new System.Drawing.Point(6, 206);
			this.textBoxItemPatronymic.MaxLength = 255;
			this.textBoxItemPatronymic.Multiline = true;
			this.textBoxItemPatronymic.Name = "textBoxItemPatronymic";
			this.textBoxItemPatronymic.Size = new System.Drawing.Size(271, 29);
			this.textBoxItemPatronymic.TabIndex = 5;
			this.textBoxItemPatronymic.Tag = "Отчество";
			this.textBoxItemPatronymic.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.textBoxItemPatronymic.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// textBoxItemSurname
			// 
			this.textBoxItemSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxItemSurname.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxItemSurname.Location = new System.Drawing.Point(6, 171);
			this.textBoxItemSurname.MaxLength = 255;
			this.textBoxItemSurname.Multiline = true;
			this.textBoxItemSurname.Name = "textBoxItemSurname";
			this.textBoxItemSurname.Size = new System.Drawing.Size(271, 29);
			this.textBoxItemSurname.TabIndex = 4;
			this.textBoxItemSurname.Tag = "Фамилия";
			this.textBoxItemSurname.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.textBoxItemSurname.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// textBoxItemName
			// 
			this.textBoxItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxItemName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxItemName.Location = new System.Drawing.Point(6, 136);
			this.textBoxItemName.MaxLength = 255;
			this.textBoxItemName.Multiline = true;
			this.textBoxItemName.Name = "textBoxItemName";
			this.textBoxItemName.Size = new System.Drawing.Size(271, 29);
			this.textBoxItemName.TabIndex = 3;
			this.textBoxItemName.Tag = "Имя";
			this.textBoxItemName.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.textBoxItemName.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// buttonItemDelete
			// 
			this.buttonItemDelete.BackColor = System.Drawing.Color.Firebrick;
			this.buttonItemDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonItemDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonItemDelete.ForeColor = System.Drawing.Color.White;
			this.buttonItemDelete.Location = new System.Drawing.Point(5, 467);
			this.buttonItemDelete.Name = "buttonItemDelete";
			this.buttonItemDelete.Size = new System.Drawing.Size(270, 52);
			this.buttonItemDelete.TabIndex = 15;
			this.buttonItemDelete.Text = "Удалить";
			this.buttonItemDelete.UseVisualStyleBackColor = false;
			this.buttonItemDelete.Click += new System.EventHandler(this.buttonItemDelete_Click);
			// 
			// buttonItemAdd
			// 
			this.buttonItemAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonItemAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonItemAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonItemAdd.ForeColor = System.Drawing.Color.White;
			this.buttonItemAdd.Location = new System.Drawing.Point(5, 409);
			this.buttonItemAdd.Name = "buttonItemAdd";
			this.buttonItemAdd.Size = new System.Drawing.Size(270, 52);
			this.buttonItemAdd.TabIndex = 7;
			this.buttonItemAdd.Text = "Добавить";
			this.buttonItemAdd.UseVisualStyleBackColor = false;
			this.buttonItemAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
			// 
			// buttonAddNewJobPosition
			// 
			this.buttonAddNewJobPosition.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
			this.buttonAddNewJobPosition.BackColor = System.Drawing.Color.Firebrick;
			this.buttonAddNewJobPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAddNewJobPosition.BorderRadius = 0;
			this.buttonAddNewJobPosition.ButtonText = "+";
			this.buttonAddNewJobPosition.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddNewJobPosition.DisabledColor = System.Drawing.Color.Gray;
			this.buttonAddNewJobPosition.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.buttonAddNewJobPosition.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonAddNewJobPosition.Iconimage = null;
			this.buttonAddNewJobPosition.Iconimage_right = null;
			this.buttonAddNewJobPosition.Iconimage_right_Selected = null;
			this.buttonAddNewJobPosition.Iconimage_Selected = null;
			this.buttonAddNewJobPosition.IconMarginLeft = 0;
			this.buttonAddNewJobPosition.IconMarginRight = 0;
			this.buttonAddNewJobPosition.IconRightVisible = false;
			this.buttonAddNewJobPosition.IconRightZoom = 0D;
			this.buttonAddNewJobPosition.IconVisible = false;
			this.buttonAddNewJobPosition.IconZoom = 1D;
			this.buttonAddNewJobPosition.IsTab = false;
			this.buttonAddNewJobPosition.Location = new System.Drawing.Point(5, 72);
			this.buttonAddNewJobPosition.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAddNewJobPosition.Name = "buttonAddNewJobPosition";
			this.buttonAddNewJobPosition.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonAddNewJobPosition.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
			this.buttonAddNewJobPosition.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonAddNewJobPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonAddNewJobPosition.selected = false;
			this.buttonAddNewJobPosition.Size = new System.Drawing.Size(38, 25);
			this.buttonAddNewJobPosition.TabIndex = 14;
			this.buttonAddNewJobPosition.Text = "+";
			this.buttonAddNewJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonAddNewJobPosition.Textcolor = System.Drawing.Color.White;
			this.buttonAddNewJobPosition.TextFont = new System.Drawing.Font("Century Gothic", 20F);
			this.buttonAddNewJobPosition.Click += new System.EventHandler(this.buttonAddNewJobPosition_Click);
			// 
			// comboBoxJobPosition
			// 
			this.comboBoxJobPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxJobPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxJobPosition.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxJobPosition.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxJobPosition.FormattingEnabled = true;
			this.comboBoxJobPosition.Location = new System.Drawing.Point(54, 70);
			this.comboBoxJobPosition.Name = "comboBoxJobPosition";
			this.comboBoxJobPosition.Size = new System.Drawing.Size(221, 29);
			this.comboBoxJobPosition.TabIndex = 1;
			this.comboBoxJobPosition.Tag = "Должность";
			this.comboBoxJobPosition.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.comboBoxJobPosition.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// comboBoxOffices
			// 
			this.comboBoxOffices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxOffices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxOffices.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxOffices.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxOffices.FormattingEnabled = true;
			this.comboBoxOffices.Location = new System.Drawing.Point(4, 103);
			this.comboBoxOffices.Name = "comboBoxOffices";
			this.comboBoxOffices.Size = new System.Drawing.Size(272, 29);
			this.comboBoxOffices.TabIndex = 2;
			this.comboBoxOffices.Tag = "Офис";
			this.comboBoxOffices.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.comboBoxOffices.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// panelAddJobPosition
			// 
			this.panelAddJobPosition.BackColor = System.Drawing.Color.Firebrick;
			this.panelAddJobPosition.Controls.Add(this.TextBoxAddJobPosition);
			this.panelAddJobPosition.Controls.Add(this.buttonAddJobPositionAdd);
			this.panelAddJobPosition.Controls.Add(this.buttonAddJobPositionDelete);
			this.panelAddJobPosition.Controls.Add(this.dataGridJobPosition);
			this.panelAddJobPosition.Controls.Add(this.buttonClosePanelAddJobPosition);
			this.panelAddJobPosition.Location = new System.Drawing.Point(559, 510);
			this.panelAddJobPosition.Name = "panelAddJobPosition";
			this.panelAddJobPosition.Size = new System.Drawing.Size(450, 300);
			this.panelAddJobPosition.TabIndex = 3;
			this.panelAddJobPosition.Visible = false;
			this.panelAddJobPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAddTypеOfItem_MouseDown);
			this.panelAddJobPosition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAddTypеOfItem_MouseMove);
			this.panelAddJobPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAddTypеOfItem_MouseUp);
			// 
			// TextBoxAddJobPosition
			// 
			this.TextBoxAddJobPosition.BackColor = System.Drawing.Color.White;
			this.TextBoxAddJobPosition.BorderColorFocused = System.Drawing.Color.Firebrick;
			this.TextBoxAddJobPosition.BorderColorIdle = System.Drawing.Color.Firebrick;
			this.TextBoxAddJobPosition.BorderColorMouseHover = System.Drawing.Color.Firebrick;
			this.TextBoxAddJobPosition.BorderThickness = 1;
			this.TextBoxAddJobPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextBoxAddJobPosition.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.TextBoxAddJobPosition.ForeColor = System.Drawing.Color.Gray;
			this.TextBoxAddJobPosition.isPassword = false;
			this.TextBoxAddJobPosition.Location = new System.Drawing.Point(17, 262);
			this.TextBoxAddJobPosition.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxAddJobPosition.Name = "TextBoxAddJobPosition";
			this.TextBoxAddJobPosition.Size = new System.Drawing.Size(197, 30);
			this.TextBoxAddJobPosition.TabIndex = 15;
			this.TextBoxAddJobPosition.Tag = "";
			this.TextBoxAddJobPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// buttonAddJobPositionAdd
			// 
			this.buttonAddJobPositionAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddJobPositionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddJobPositionAdd.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddJobPositionAdd.ForeColor = System.Drawing.Color.White;
			this.buttonAddJobPositionAdd.Location = new System.Drawing.Point(221, 262);
			this.buttonAddJobPositionAdd.Name = "buttonAddJobPositionAdd";
			this.buttonAddJobPositionAdd.Size = new System.Drawing.Size(109, 30);
			this.buttonAddJobPositionAdd.TabIndex = 5;
			this.buttonAddJobPositionAdd.Text = "Добавить";
			this.buttonAddJobPositionAdd.UseVisualStyleBackColor = true;
			this.buttonAddJobPositionAdd.Click += new System.EventHandler(this.buttonAddJobPositionAdd_Click);
			// 
			// buttonAddJobPositionDelete
			// 
			this.buttonAddJobPositionDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddJobPositionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddJobPositionDelete.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddJobPositionDelete.ForeColor = System.Drawing.Color.White;
			this.buttonAddJobPositionDelete.Location = new System.Drawing.Point(332, 262);
			this.buttonAddJobPositionDelete.Name = "buttonAddJobPositionDelete";
			this.buttonAddJobPositionDelete.Size = new System.Drawing.Size(109, 30);
			this.buttonAddJobPositionDelete.TabIndex = 5;
			this.buttonAddJobPositionDelete.Text = "Удалить";
			this.buttonAddJobPositionDelete.UseVisualStyleBackColor = true;
			this.buttonAddJobPositionDelete.Click += new System.EventHandler(this.buttonAddJobPositionDelete_Click);
			// 
			// dataGridJobPosition
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridJobPosition.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridJobPosition.BackgroundColor = System.Drawing.Color.White;
			this.dataGridJobPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridJobPosition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridJobPosition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridJobPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridJobPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridJobPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dataGridJobPosition.DoubleBuffered = true;
			this.dataGridJobPosition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridJobPosition.EnableHeadersVisualStyles = false;
			this.dataGridJobPosition.GridColor = System.Drawing.Color.Firebrick;
			this.dataGridJobPosition.HeaderBgColor = System.Drawing.Color.White;
			this.dataGridJobPosition.HeaderForeColor = System.Drawing.Color.Firebrick;
			this.dataGridJobPosition.Location = new System.Drawing.Point(3, 29);
			this.dataGridJobPosition.MultiSelect = false;
			this.dataGridJobPosition.Name = "dataGridJobPosition";
			this.dataGridJobPosition.ReadOnly = true;
			this.dataGridJobPosition.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridJobPosition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridJobPosition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridJobPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridJobPosition.ShowCellErrors = false;
			this.dataGridJobPosition.ShowCellToolTips = false;
			this.dataGridJobPosition.ShowEditingIcon = false;
			this.dataGridJobPosition.ShowRowErrors = false;
			this.dataGridJobPosition.Size = new System.Drawing.Size(444, 268);
			this.dataGridJobPosition.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.FillWeight = 110F;
			this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Должность";
			this.dataGridViewTextBoxColumn2.MaxInputLength = 32;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// buttonClosePanelAddJobPosition
			// 
			this.buttonClosePanelAddJobPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonClosePanelAddJobPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClosePanelAddJobPosition.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClosePanelAddJobPosition.ForeColor = System.Drawing.Color.White;
			this.buttonClosePanelAddJobPosition.Location = new System.Drawing.Point(414, -2);
			this.buttonClosePanelAddJobPosition.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClosePanelAddJobPosition.Name = "buttonClosePanelAddJobPosition";
			this.buttonClosePanelAddJobPosition.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.buttonClosePanelAddJobPosition.Size = new System.Drawing.Size(33, 33);
			this.buttonClosePanelAddJobPosition.TabIndex = 5;
			this.buttonClosePanelAddJobPosition.Text = "X";
			this.buttonClosePanelAddJobPosition.UseVisualStyleBackColor = true;
			this.buttonClosePanelAddJobPosition.Click += new System.EventHandler(this.buttonClosePanelAddJobPosition_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxSearch.Location = new System.Drawing.Point(93, 25);
			this.textBoxSearch.MaxLength = 255;
			this.textBoxSearch.Multiline = true;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(363, 29);
			this.textBoxSearch.TabIndex = 20;
			this.textBoxSearch.Tag = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// labelSearch
			// 
			labelSearch.AutoSize = true;
			labelSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelSearch.ForeColor = System.Drawing.Color.Firebrick;
			labelSearch.Location = new System.Drawing.Point(11, 25);
			labelSearch.Name = "labelSearch";
			labelSearch.Size = new System.Drawing.Size(76, 24);
			labelSearch.TabIndex = 21;
			labelSearch.Text = "Поиск";
			labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EmployeesControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddJobPosition);
			this.Controls.Add(this.panelAddEmployee);
			this.Controls.Add(this.dataGridViewMain);
			this.DoubleBuffered = true;
			this.Name = "EmployeesControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddEmployee.ResumeLayout(false);
			this.panelAddEmployee.PerformLayout();
			this.panelAddJobPosition.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJobPosition)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddEmployee;
		private System.Windows.Forms.ComboBox comboBoxOffices;
		private System.Windows.Forms.ComboBox comboBoxJobPosition;
		private Bunifu.Framework.UI.BunifuFlatButton buttonAddNewJobPosition;
		private System.Windows.Forms.Panel panelAddJobPosition;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridJobPosition;
		private System.Windows.Forms.Button buttonAddJobPositionDelete;
		private System.Windows.Forms.Button buttonClosePanelAddJobPosition;
		private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxAddJobPosition;
		private System.Windows.Forms.Button buttonAddJobPositionAdd;
		private System.Windows.Forms.Button buttonItemAdd;
		private System.Windows.Forms.Button buttonItemDelete;
		private System.Windows.Forms.TextBox textBoxItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private ns1.BunifuDatepicker datepickerBirthday;
		private System.Windows.Forms.TextBox textBoxItemPatronymic;
		private System.Windows.Forms.TextBox textBoxItemSurname;
		private System.Windows.Forms.TextBox textBoxSearch;
	}
}
