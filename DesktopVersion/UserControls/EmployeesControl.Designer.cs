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
			System.Windows.Forms.Label label;
			System.Windows.Forms.Label labelRight2;
			System.Windows.Forms.Label labelSearch;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddEmployee = new System.Windows.Forms.Panel();
			this.datepickerBirthday = new ns1.BunifuDatepicker();
			this.textBoxEmployeePatronymic = new System.Windows.Forms.TextBox();
			this.textBoxEmployeeSurname = new System.Windows.Forms.TextBox();
			this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
			this.buttonEmployeeDelete = new System.Windows.Forms.Button();
			this.buttonEmployeeAdd = new System.Windows.Forms.Button();
			this.buttonAddNewJobPosition = new Bunifu.Framework.UI.BunifuFlatButton();
			this.comboBoxJobPosition = new System.Windows.Forms.ComboBox();
			this.comboBoxOffices = new System.Windows.Forms.ComboBox();
			this.panelAddJobPosition = new System.Windows.Forms.Panel();
			this.textBoxAddJobPosition = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.buttonAddJobPositionAdd = new System.Windows.Forms.Button();
			this.buttonAddJobPositionDelete = new System.Windows.Forms.Button();
			this.dataGridJobPosition = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonClosePanelAddJobPosition = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.panelEdit = new System.Windows.Forms.Panel();
			this.buttonClosePanelEdit = new System.Windows.Forms.Button();
			this.panelBackgroundEdit = new System.Windows.Forms.Panel();
			this.datepickerEditBirthday = new ns1.BunifuDatepicker();
			this.buttonOfficeConfirmEdit = new System.Windows.Forms.Button();
			this.textBoxEditEmployeePatronymic = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxEditEmployeeSurname = new System.Windows.Forms.TextBox();
			this.comboBoxEditJobPosition = new System.Windows.Forms.ComboBox();
			this.textBoxEditEmployeeName = new System.Windows.Forms.TextBox();
			this.comboBoxEditOffices = new System.Windows.Forms.ComboBox();
			this.buttonEditShow = new Bunifu.Framework.UI.BunifuFlatButton();
			this.buttonExcel = new System.Windows.Forms.Button();
			label = new System.Windows.Forms.Label();
			labelRight2 = new System.Windows.Forms.Label();
			labelSearch = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddEmployee.SuspendLayout();
			this.panelAddJobPosition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridJobPosition)).BeginInit();
			this.panelEdit.SuspendLayout();
			this.panelBackgroundEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label.ForeColor = System.Drawing.Color.Firebrick;
			label.Location = new System.Drawing.Point(50, 0);
			label.Name = "label";
			label.Size = new System.Drawing.Size(188, 48);
			label.TabIndex = 5;
			label.Text = "Добавить нового\r\nсотрудника";
			label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 10F);
			label2.ForeColor = System.Drawing.Color.Firebrick;
			label2.Location = new System.Drawing.Point(25, 192);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(122, 19);
			label2.TabIndex = 5;
			label2.Text = "Дата рождения:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Column5,
            this.Column2,
            this.Отчество,
            this.Column6,
            this.Column4,
            this.Column3});
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
			this.Column1.Visible = false;
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
			// Column4
			// 
			this.Column4.HeaderText = "Должность";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Офис";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// panelAddEmployee
			// 
			this.panelAddEmployee.Controls.Add(this.buttonExcel);
			this.panelAddEmployee.Controls.Add(this.datepickerBirthday);
			this.panelAddEmployee.Controls.Add(this.textBoxEmployeePatronymic);
			this.panelAddEmployee.Controls.Add(this.textBoxEmployeeSurname);
			this.panelAddEmployee.Controls.Add(this.textBoxEmployeeName);
			this.panelAddEmployee.Controls.Add(this.buttonEmployeeDelete);
			this.panelAddEmployee.Controls.Add(this.buttonEmployeeAdd);
			this.panelAddEmployee.Controls.Add(this.buttonAddNewJobPosition);
			this.panelAddEmployee.Controls.Add(this.comboBoxJobPosition);
			this.panelAddEmployee.Controls.Add(this.comboBoxOffices);
			this.panelAddEmployee.Controls.Add(labelRight2);
			this.panelAddEmployee.Controls.Add(label);
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
			// textBoxEmployeePatronymic
			// 
			this.textBoxEmployeePatronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEmployeePatronymic.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEmployeePatronymic.Location = new System.Drawing.Point(6, 206);
			this.textBoxEmployeePatronymic.MaxLength = 255;
			this.textBoxEmployeePatronymic.Multiline = true;
			this.textBoxEmployeePatronymic.Name = "textBoxEmployeePatronymic";
			this.textBoxEmployeePatronymic.Size = new System.Drawing.Size(271, 29);
			this.textBoxEmployeePatronymic.TabIndex = 5;
			this.textBoxEmployeePatronymic.Tag = "Отчество";
			// 
			// textBoxEmployeeSurname
			// 
			this.textBoxEmployeeSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEmployeeSurname.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEmployeeSurname.Location = new System.Drawing.Point(6, 171);
			this.textBoxEmployeeSurname.MaxLength = 255;
			this.textBoxEmployeeSurname.Multiline = true;
			this.textBoxEmployeeSurname.Name = "textBoxEmployeeSurname";
			this.textBoxEmployeeSurname.Size = new System.Drawing.Size(271, 29);
			this.textBoxEmployeeSurname.TabIndex = 4;
			this.textBoxEmployeeSurname.Tag = "Фамилия";
			// 
			// textBoxEmployeeName
			// 
			this.textBoxEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEmployeeName.Location = new System.Drawing.Point(6, 136);
			this.textBoxEmployeeName.MaxLength = 255;
			this.textBoxEmployeeName.Multiline = true;
			this.textBoxEmployeeName.Name = "textBoxEmployeeName";
			this.textBoxEmployeeName.Size = new System.Drawing.Size(271, 29);
			this.textBoxEmployeeName.TabIndex = 3;
			this.textBoxEmployeeName.Tag = "Имя";
			// 
			// buttonEmployeeDelete
			// 
			this.buttonEmployeeDelete.BackColor = System.Drawing.Color.Firebrick;
			this.buttonEmployeeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonEmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEmployeeDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonEmployeeDelete.ForeColor = System.Drawing.Color.White;
			this.buttonEmployeeDelete.Location = new System.Drawing.Point(5, 740);
			this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
			this.buttonEmployeeDelete.Size = new System.Drawing.Size(270, 52);
			this.buttonEmployeeDelete.TabIndex = 15;
			this.buttonEmployeeDelete.Text = "Удалить";
			this.buttonEmployeeDelete.UseVisualStyleBackColor = false;
			this.buttonEmployeeDelete.Click += new System.EventHandler(this.buttonEmployeeDelete_Click);
			// 
			// buttonEmployeeAdd
			// 
			this.buttonEmployeeAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonEmployeeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEmployeeAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonEmployeeAdd.ForeColor = System.Drawing.Color.White;
			this.buttonEmployeeAdd.Location = new System.Drawing.Point(5, 682);
			this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
			this.buttonEmployeeAdd.Size = new System.Drawing.Size(270, 52);
			this.buttonEmployeeAdd.TabIndex = 7;
			this.buttonEmployeeAdd.Text = "Добавить";
			this.buttonEmployeeAdd.UseVisualStyleBackColor = false;
			this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
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
			// 
			// comboBoxJobPosition
			// 
			this.comboBoxJobPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxJobPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxJobPosition.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxJobPosition.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxJobPosition.FormattingEnabled = true;
			this.comboBoxJobPosition.Location = new System.Drawing.Point(54, 70);
			this.comboBoxJobPosition.Name = "comboBoxJobPosition";
			this.comboBoxJobPosition.Size = new System.Drawing.Size(221, 29);
			this.comboBoxJobPosition.TabIndex = 1;
			this.comboBoxJobPosition.Tag = "Должность";
			// 
			// comboBoxOffices
			// 
			this.comboBoxOffices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxOffices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOffices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxOffices.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxOffices.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxOffices.FormattingEnabled = true;
			this.comboBoxOffices.Location = new System.Drawing.Point(7, 103);
			this.comboBoxOffices.Name = "comboBoxOffices";
			this.comboBoxOffices.Size = new System.Drawing.Size(269, 29);
			this.comboBoxOffices.TabIndex = 2;
			this.comboBoxOffices.Tag = "Офис";
			// 
			// panelAddJobPosition
			// 
			this.panelAddJobPosition.BackColor = System.Drawing.Color.Firebrick;
			this.panelAddJobPosition.Controls.Add(this.textBoxAddJobPosition);
			this.panelAddJobPosition.Controls.Add(this.buttonAddJobPositionAdd);
			this.panelAddJobPosition.Controls.Add(this.buttonAddJobPositionDelete);
			this.panelAddJobPosition.Controls.Add(this.dataGridJobPosition);
			this.panelAddJobPosition.Controls.Add(this.buttonClosePanelAddJobPosition);
			this.panelAddJobPosition.Location = new System.Drawing.Point(559, 510);
			this.panelAddJobPosition.Name = "panelAddJobPosition";
			this.panelAddJobPosition.Size = new System.Drawing.Size(450, 300);
			this.panelAddJobPosition.TabIndex = 3;
			this.panelAddJobPosition.Visible = false;
			// 
			// textBoxAddJobPosition
			// 
			this.textBoxAddJobPosition.BackColor = System.Drawing.Color.White;
			this.textBoxAddJobPosition.BorderColorFocused = System.Drawing.Color.Firebrick;
			this.textBoxAddJobPosition.BorderColorIdle = System.Drawing.Color.Firebrick;
			this.textBoxAddJobPosition.BorderColorMouseHover = System.Drawing.Color.Firebrick;
			this.textBoxAddJobPosition.BorderThickness = 1;
			this.textBoxAddJobPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxAddJobPosition.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.textBoxAddJobPosition.ForeColor = System.Drawing.Color.Gray;
			this.textBoxAddJobPosition.isPassword = false;
			this.textBoxAddJobPosition.Location = new System.Drawing.Point(17, 262);
			this.textBoxAddJobPosition.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxAddJobPosition.Name = "textBoxAddJobPosition";
			this.textBoxAddJobPosition.Size = new System.Drawing.Size(197, 30);
			this.textBoxAddJobPosition.TabIndex = 15;
			this.textBoxAddJobPosition.Tag = "";
			this.textBoxAddJobPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.dataGridViewTextBoxColumn1.Visible = false;
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
			// panelEdit
			// 
			this.panelEdit.BackColor = System.Drawing.Color.Firebrick;
			this.panelEdit.Controls.Add(this.buttonClosePanelEdit);
			this.panelEdit.Controls.Add(this.panelBackgroundEdit);
			this.panelEdit.Location = new System.Drawing.Point(686, 104);
			this.panelEdit.Name = "panelEdit";
			this.panelEdit.Size = new System.Drawing.Size(324, 412);
			this.panelEdit.TabIndex = 25;
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
			this.panelBackgroundEdit.Controls.Add(this.datepickerEditBirthday);
			this.panelBackgroundEdit.Controls.Add(this.buttonOfficeConfirmEdit);
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditEmployeePatronymic);
			this.panelBackgroundEdit.Controls.Add(this.label1);
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditEmployeeSurname);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditJobPosition);
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditEmployeeName);
			this.panelBackgroundEdit.Controls.Add(label2);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditOffices);
			this.panelBackgroundEdit.Location = new System.Drawing.Point(3, 39);
			this.panelBackgroundEdit.Name = "panelBackgroundEdit";
			this.panelBackgroundEdit.Size = new System.Drawing.Size(318, 370);
			this.panelBackgroundEdit.TabIndex = 0;
			// 
			// datepickerEditBirthday
			// 
			this.datepickerEditBirthday.BackColor = System.Drawing.Color.Firebrick;
			this.datepickerEditBirthday.BorderRadius = 0;
			this.datepickerEditBirthday.ForeColor = System.Drawing.Color.White;
			this.datepickerEditBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.datepickerEditBirthday.FormatCustom = null;
			this.datepickerEditBirthday.Location = new System.Drawing.Point(28, 214);
			this.datepickerEditBirthday.Name = "datepickerEditBirthday";
			this.datepickerEditBirthday.Size = new System.Drawing.Size(271, 30);
			this.datepickerEditBirthday.TabIndex = 6;
			this.datepickerEditBirthday.Value = new System.DateTime(2020, 5, 20, 3, 6, 1, 333);
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
			this.buttonOfficeConfirmEdit.Text = "Потвердить изменение";
			this.buttonOfficeConfirmEdit.UseVisualStyleBackColor = false;
			this.buttonOfficeConfirmEdit.Click += new System.EventHandler(this.buttonOfficeConfirmEdit_Click);
			// 
			// textBoxEditEmployeePatronymic
			// 
			this.textBoxEditEmployeePatronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditEmployeePatronymic.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditEmployeePatronymic.Location = new System.Drawing.Point(28, 163);
			this.textBoxEditEmployeePatronymic.MaxLength = 255;
			this.textBoxEditEmployeePatronymic.Multiline = true;
			this.textBoxEditEmployeePatronymic.Name = "textBoxEditEmployeePatronymic";
			this.textBoxEditEmployeePatronymic.Size = new System.Drawing.Size(271, 29);
			this.textBoxEditEmployeePatronymic.TabIndex = 5;
			this.textBoxEditEmployeePatronymic.Tag = "Отчество";
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
			// textBoxEditEmployeeSurname
			// 
			this.textBoxEditEmployeeSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditEmployeeSurname.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditEmployeeSurname.Location = new System.Drawing.Point(28, 128);
			this.textBoxEditEmployeeSurname.MaxLength = 255;
			this.textBoxEditEmployeeSurname.Multiline = true;
			this.textBoxEditEmployeeSurname.Name = "textBoxEditEmployeeSurname";
			this.textBoxEditEmployeeSurname.Size = new System.Drawing.Size(271, 29);
			this.textBoxEditEmployeeSurname.TabIndex = 4;
			this.textBoxEditEmployeeSurname.Tag = "Фамилия";
			// 
			// comboBoxEditJobPosition
			// 
			this.comboBoxEditJobPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditJobPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditJobPosition.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditJobPosition.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditJobPosition.FormattingEnabled = true;
			this.comboBoxEditJobPosition.Location = new System.Drawing.Point(28, 27);
			this.comboBoxEditJobPosition.Name = "comboBoxEditJobPosition";
			this.comboBoxEditJobPosition.Size = new System.Drawing.Size(269, 29);
			this.comboBoxEditJobPosition.TabIndex = 1;
			this.comboBoxEditJobPosition.Tag = "Должность";
			// 
			// textBoxEditEmployeeName
			// 
			this.textBoxEditEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditEmployeeName.Location = new System.Drawing.Point(28, 93);
			this.textBoxEditEmployeeName.MaxLength = 255;
			this.textBoxEditEmployeeName.Multiline = true;
			this.textBoxEditEmployeeName.Name = "textBoxEditEmployeeName";
			this.textBoxEditEmployeeName.Size = new System.Drawing.Size(271, 29);
			this.textBoxEditEmployeeName.TabIndex = 3;
			this.textBoxEditEmployeeName.Tag = "Имя";
			// 
			// comboBoxEditOffices
			// 
			this.comboBoxEditOffices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditOffices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditOffices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditOffices.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditOffices.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditOffices.FormattingEnabled = true;
			this.comboBoxEditOffices.Location = new System.Drawing.Point(29, 60);
			this.comboBoxEditOffices.Name = "comboBoxEditOffices";
			this.comboBoxEditOffices.Size = new System.Drawing.Size(269, 29);
			this.comboBoxEditOffices.TabIndex = 2;
			this.comboBoxEditOffices.Tag = "Офис";
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
			this.buttonEditShow.TabIndex = 22;
			this.buttonEditShow.Text = "Изменить";
			this.buttonEditShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonEditShow.Textcolor = System.Drawing.Color.White;
			this.buttonEditShow.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonEditShow.Click += new System.EventHandler(this.buttonEditShow_Click);
			// 
			// buttonExcel
			// 
			this.buttonExcel.BackColor = System.Drawing.Color.Firebrick;
			this.buttonExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExcel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonExcel.ForeColor = System.Drawing.Color.White;
			this.buttonExcel.Location = new System.Drawing.Point(5, 624);
			this.buttonExcel.Name = "buttonExcel";
			this.buttonExcel.Size = new System.Drawing.Size(270, 52);
			this.buttonExcel.TabIndex = 17;
			this.buttonExcel.Text = "Вывод в Excel";
			this.buttonExcel.UseVisualStyleBackColor = false;
			this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
			// 
			// EmployeesControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.buttonEditShow);
			this.Controls.Add(this.panelEdit);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddJobPosition);
			this.Controls.Add(this.panelAddEmployee);
			this.Controls.Add(this.dataGridViewMain);
			this.Name = "EmployeesControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddEmployee.ResumeLayout(false);
			this.panelAddEmployee.PerformLayout();
			this.panelAddJobPosition.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridJobPosition)).EndInit();
			this.panelEdit.ResumeLayout(false);
			this.panelBackgroundEdit.ResumeLayout(false);
			this.panelBackgroundEdit.PerformLayout();
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
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxAddJobPosition;
		private System.Windows.Forms.Button buttonAddJobPositionAdd;
		private System.Windows.Forms.Button buttonEmployeeAdd;
		private System.Windows.Forms.Button buttonEmployeeDelete;
		private System.Windows.Forms.TextBox textBoxEmployeeName;
		private ns1.BunifuDatepicker datepickerBirthday;
		private System.Windows.Forms.TextBox textBoxEmployeePatronymic;
		private System.Windows.Forms.TextBox textBoxEmployeeSurname;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Panel panelEdit;
		private System.Windows.Forms.Button buttonClosePanelEdit;
		private System.Windows.Forms.Panel panelBackgroundEdit;
		private System.Windows.Forms.Button buttonOfficeConfirmEdit;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuFlatButton buttonEditShow;
		private ns1.BunifuDatepicker datepickerEditBirthday;
		private System.Windows.Forms.TextBox textBoxEditEmployeePatronymic;
		private System.Windows.Forms.TextBox textBoxEditEmployeeSurname;
		private System.Windows.Forms.ComboBox comboBoxEditJobPosition;
		private System.Windows.Forms.TextBox textBoxEditEmployeeName;
		private System.Windows.Forms.ComboBox comboBoxEditOffices;
		private System.Windows.Forms.Button buttonExcel;
	}
}
