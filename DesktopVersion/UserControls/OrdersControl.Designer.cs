namespace DesktopVersion
{
	partial class OrdersControl
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
			System.Windows.Forms.Label labelSearch;
			System.Windows.Forms.Label labelPhoneNumber;
			System.Windows.Forms.Label labelFullName;
			System.Windows.Forms.Panel panelAddClientSpliter;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelAddClientBackGround = new System.Windows.Forms.Panel();
			this.TextBoxAddClientPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.TextBoxAddClientFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddOrder = new System.Windows.Forms.Panel();
			this.buttonExcel = new System.Windows.Forms.Button();
			this.dateTimePickerOrderEnd = new ns1.BunifuDatepicker();
			this.textBoxCost = new System.Windows.Forms.TextBox();
			this.buttonOrderDelete = new System.Windows.Forms.Button();
			this.textBoxDomen = new System.Windows.Forms.TextBox();
			this.buttonOrderAdd = new System.Windows.Forms.Button();
			this.buttonAddNewClient = new Bunifu.Framework.UI.BunifuFlatButton();
			this.comboBoxClients = new System.Windows.Forms.ComboBox();
			this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
			this.comboBoxServers = new System.Windows.Forms.ComboBox();
			this.panelAddClient = new System.Windows.Forms.Panel();
			this.buttonAddClientAdd = new System.Windows.Forms.Button();
			this.buttonAddClientDelete = new System.Windows.Forms.Button();
			this.dataGridClients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonClosePanelAddClient = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.panelEdit = new System.Windows.Forms.Panel();
			this.buttonClosePanelEdit = new System.Windows.Forms.Button();
			this.panelBackgroundEdit = new System.Windows.Forms.Panel();
			this.dateTimePickerEditOrderTime = new ns1.BunifuDatepicker();
			this.dateTimePickerEditOrderEnd = new ns1.BunifuDatepicker();
			this.buttonOfficeConfirmEdit = new System.Windows.Forms.Button();
			this.textBoxEditDomen = new System.Windows.Forms.TextBox();
			this.textBoxEditCost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxEditEmployee = new System.Windows.Forms.ComboBox();
			this.comboBoxEditClients = new System.Windows.Forms.ComboBox();
			this.comboBoxEditServers = new System.Windows.Forms.ComboBox();
			this.comboBoxEditCurrency = new System.Windows.Forms.ComboBox();
			this.buttonEditShow = new Bunifu.Framework.UI.BunifuFlatButton();
			this.comboBoxSearch = new System.Windows.Forms.ComboBox();
			labelRight1 = new System.Windows.Forms.Label();
			labelRight2 = new System.Windows.Forms.Label();
			labelSearch = new System.Windows.Forms.Label();
			labelPhoneNumber = new System.Windows.Forms.Label();
			labelFullName = new System.Windows.Forms.Label();
			panelAddClientSpliter = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			this.panelAddClientBackGround.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddOrder.SuspendLayout();
			this.panelAddClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
			this.panelEdit.SuspendLayout();
			this.panelBackgroundEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelRight1
			// 
			labelRight1.AutoSize = true;
			labelRight1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelRight1.ForeColor = System.Drawing.Color.Firebrick;
			labelRight1.Location = new System.Drawing.Point(20, 15);
			labelRight1.Name = "labelRight1";
			labelRight1.Size = new System.Drawing.Size(242, 24);
			labelRight1.TabIndex = 5;
			labelRight1.Text = "Добавить новый заказ";
			labelRight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRight2
			// 
			labelRight2.AutoSize = true;
			labelRight2.Font = new System.Drawing.Font("Century Gothic", 10F);
			labelRight2.ForeColor = System.Drawing.Color.Firebrick;
			labelRight2.Location = new System.Drawing.Point(3, 204);
			labelRight2.Name = "labelRight2";
			labelRight2.Size = new System.Drawing.Size(177, 19);
			labelRight2.TabIndex = 5;
			labelRight2.Text = "Дата окончания заказа:";
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
			// labelPhoneNumber
			// 
			labelPhoneNumber.AutoSize = true;
			labelPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 10F);
			labelPhoneNumber.ForeColor = System.Drawing.Color.Firebrick;
			labelPhoneNumber.Location = new System.Drawing.Point(436, 61);
			labelPhoneNumber.Name = "labelPhoneNumber";
			labelPhoneNumber.Size = new System.Drawing.Size(140, 19);
			labelPhoneNumber.TabIndex = 5;
			labelPhoneNumber.Text = "Номер телефона:";
			labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelFullName
			// 
			labelFullName.AutoSize = true;
			labelFullName.Font = new System.Drawing.Font("Century Gothic", 10F);
			labelFullName.ForeColor = System.Drawing.Color.Firebrick;
			labelFullName.Location = new System.Drawing.Point(436, 4);
			labelFullName.Name = "labelFullName";
			labelFullName.Size = new System.Drawing.Size(47, 19);
			labelFullName.TabIndex = 5;
			labelFullName.Text = "ФИО:";
			labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelAddClientSpliter
			// 
			panelAddClientSpliter.BackColor = System.Drawing.Color.Firebrick;
			panelAddClientSpliter.Location = new System.Drawing.Point(423, 25);
			panelAddClientSpliter.Name = "panelAddClientSpliter";
			panelAddClientSpliter.Size = new System.Drawing.Size(1, 270);
			panelAddClientSpliter.TabIndex = 16;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 10F);
			label2.ForeColor = System.Drawing.Color.Firebrick;
			label2.Location = new System.Drawing.Point(19, 204);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(177, 19);
			label2.TabIndex = 5;
			label2.Text = "Дата окончания заказа:";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Century Gothic", 10F);
			label3.ForeColor = System.Drawing.Color.Firebrick;
			label3.Location = new System.Drawing.Point(18, 259);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(101, 19);
			label3.TabIndex = 5;
			label3.Text = "Дата заказа:";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelAddClientBackGround
			// 
			this.panelAddClientBackGround.BackColor = System.Drawing.Color.White;
			this.panelAddClientBackGround.Controls.Add(this.TextBoxAddClientPhoneNumber);
			this.panelAddClientBackGround.Controls.Add(this.TextBoxAddClientFullName);
			this.panelAddClientBackGround.Controls.Add(labelPhoneNumber);
			this.panelAddClientBackGround.Controls.Add(labelFullName);
			this.panelAddClientBackGround.Location = new System.Drawing.Point(3, 29);
			this.panelAddClientBackGround.Name = "panelAddClientBackGround";
			this.panelAddClientBackGround.Size = new System.Drawing.Size(648, 266);
			this.panelAddClientBackGround.TabIndex = 16;
			// 
			// TextBoxAddClientPhoneNumber
			// 
			this.TextBoxAddClientPhoneNumber.BackColor = System.Drawing.Color.White;
			this.TextBoxAddClientPhoneNumber.BorderColorFocused = System.Drawing.Color.Firebrick;
			this.TextBoxAddClientPhoneNumber.BorderColorIdle = System.Drawing.Color.Firebrick;
			this.TextBoxAddClientPhoneNumber.BorderColorMouseHover = System.Drawing.Color.Firebrick;
			this.TextBoxAddClientPhoneNumber.BorderThickness = 1;
			this.TextBoxAddClientPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextBoxAddClientPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.TextBoxAddClientPhoneNumber.ForeColor = System.Drawing.Color.Gray;
			this.TextBoxAddClientPhoneNumber.isPassword = false;
			this.TextBoxAddClientPhoneNumber.Location = new System.Drawing.Point(436, 84);
			this.TextBoxAddClientPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxAddClientPhoneNumber.Name = "TextBoxAddClientPhoneNumber";
			this.TextBoxAddClientPhoneNumber.Size = new System.Drawing.Size(197, 30);
			this.TextBoxAddClientPhoneNumber.TabIndex = 15;
			this.TextBoxAddClientPhoneNumber.Tag = "";
			this.TextBoxAddClientPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// TextBoxAddClientFullName
			// 
			this.TextBoxAddClientFullName.BackColor = System.Drawing.Color.White;
			this.TextBoxAddClientFullName.BorderColorFocused = System.Drawing.Color.Firebrick;
			this.TextBoxAddClientFullName.BorderColorIdle = System.Drawing.Color.Firebrick;
			this.TextBoxAddClientFullName.BorderColorMouseHover = System.Drawing.Color.Firebrick;
			this.TextBoxAddClientFullName.BorderThickness = 1;
			this.TextBoxAddClientFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextBoxAddClientFullName.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.TextBoxAddClientFullName.ForeColor = System.Drawing.Color.Gray;
			this.TextBoxAddClientFullName.isPassword = false;
			this.TextBoxAddClientFullName.Location = new System.Drawing.Point(436, 27);
			this.TextBoxAddClientFullName.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxAddClientFullName.Name = "TextBoxAddClientFullName";
			this.TextBoxAddClientFullName.Size = new System.Drawing.Size(197, 30);
			this.TextBoxAddClientFullName.TabIndex = 15;
			this.TextBoxAddClientFullName.Tag = "";
			this.TextBoxAddClientFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Column,
            this.Column6,
            this.Column3,
            this.Column8});
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
			// Column4
			// 
			this.Column4.HeaderText = "Сотрудник";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Дата заказа";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Сервер";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column
			// 
			this.Column.HeaderText = "Дата окончания заказа";
			this.Column.Name = "Column";
			this.Column.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Цена";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Клиент";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Домен";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// panelAddOrder
			// 
			this.panelAddOrder.Controls.Add(this.buttonExcel);
			this.panelAddOrder.Controls.Add(this.dateTimePickerOrderEnd);
			this.panelAddOrder.Controls.Add(this.textBoxCost);
			this.panelAddOrder.Controls.Add(this.buttonOrderDelete);
			this.panelAddOrder.Controls.Add(this.textBoxDomen);
			this.panelAddOrder.Controls.Add(this.buttonOrderAdd);
			this.panelAddOrder.Controls.Add(this.buttonAddNewClient);
			this.panelAddOrder.Controls.Add(this.comboBoxClients);
			this.panelAddOrder.Controls.Add(this.comboBoxCurrency);
			this.panelAddOrder.Controls.Add(this.comboBoxServers);
			this.panelAddOrder.Controls.Add(labelRight2);
			this.panelAddOrder.Controls.Add(labelRight1);
			this.panelAddOrder.Location = new System.Drawing.Point(1015, 10);
			this.panelAddOrder.Name = "panelAddOrder";
			this.panelAddOrder.Size = new System.Drawing.Size(280, 800);
			this.panelAddOrder.TabIndex = 1;
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
			this.buttonExcel.TabIndex = 16;
			this.buttonExcel.Text = "Вывод в Excel";
			this.buttonExcel.UseVisualStyleBackColor = false;
			this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
			// 
			// dateTimePickerOrderEnd
			// 
			this.dateTimePickerOrderEnd.BackColor = System.Drawing.Color.Firebrick;
			this.dateTimePickerOrderEnd.BorderRadius = 0;
			this.dateTimePickerOrderEnd.ForeColor = System.Drawing.Color.White;
			this.dateTimePickerOrderEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dateTimePickerOrderEnd.FormatCustom = null;
			this.dateTimePickerOrderEnd.Location = new System.Drawing.Point(6, 226);
			this.dateTimePickerOrderEnd.Name = "dateTimePickerOrderEnd";
			this.dateTimePickerOrderEnd.Size = new System.Drawing.Size(271, 30);
			this.dateTimePickerOrderEnd.TabIndex = 6;
			this.dateTimePickerOrderEnd.Value = new System.DateTime(2020, 5, 20, 3, 6, 1, 333);
			// 
			// textBoxCost
			// 
			this.textBoxCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxCost.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxCost.Location = new System.Drawing.Point(6, 136);
			this.textBoxCost.MaxLength = 255;
			this.textBoxCost.Multiline = true;
			this.textBoxCost.Name = "textBoxCost";
			this.textBoxCost.Size = new System.Drawing.Size(208, 29);
			this.textBoxCost.TabIndex = 3;
			this.textBoxCost.Tag = "Цена";
			// 
			// buttonOrderDelete
			// 
			this.buttonOrderDelete.BackColor = System.Drawing.Color.Firebrick;
			this.buttonOrderDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonOrderDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOrderDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonOrderDelete.ForeColor = System.Drawing.Color.White;
			this.buttonOrderDelete.Location = new System.Drawing.Point(5, 740);
			this.buttonOrderDelete.Name = "buttonOrderDelete";
			this.buttonOrderDelete.Size = new System.Drawing.Size(270, 52);
			this.buttonOrderDelete.TabIndex = 15;
			this.buttonOrderDelete.Text = "Удалить";
			this.buttonOrderDelete.UseVisualStyleBackColor = false;
			this.buttonOrderDelete.Click += new System.EventHandler(this.buttonOrderDelete_Click);
			// 
			// textBoxDomen
			// 
			this.textBoxDomen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxDomen.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxDomen.Location = new System.Drawing.Point(6, 172);
			this.textBoxDomen.MaxLength = 255;
			this.textBoxDomen.Multiline = true;
			this.textBoxDomen.Name = "textBoxDomen";
			this.textBoxDomen.Size = new System.Drawing.Size(269, 29);
			this.textBoxDomen.TabIndex = 3;
			this.textBoxDomen.Tag = "Домен";
			// 
			// buttonOrderAdd
			// 
			this.buttonOrderAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonOrderAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOrderAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonOrderAdd.ForeColor = System.Drawing.Color.White;
			this.buttonOrderAdd.Location = new System.Drawing.Point(5, 682);
			this.buttonOrderAdd.Name = "buttonOrderAdd";
			this.buttonOrderAdd.Size = new System.Drawing.Size(270, 52);
			this.buttonOrderAdd.TabIndex = 7;
			this.buttonOrderAdd.Text = "Добавить";
			this.buttonOrderAdd.UseVisualStyleBackColor = false;
			this.buttonOrderAdd.Click += new System.EventHandler(this.buttonOrderAdd_Click);
			// 
			// buttonAddNewClient
			// 
			this.buttonAddNewClient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
			this.buttonAddNewClient.BackColor = System.Drawing.Color.Firebrick;
			this.buttonAddNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAddNewClient.BorderRadius = 0;
			this.buttonAddNewClient.ButtonText = "+";
			this.buttonAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddNewClient.DisabledColor = System.Drawing.Color.Gray;
			this.buttonAddNewClient.Font = new System.Drawing.Font("Times New Roman", 11F);
			this.buttonAddNewClient.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonAddNewClient.Iconimage = null;
			this.buttonAddNewClient.Iconimage_right = null;
			this.buttonAddNewClient.Iconimage_right_Selected = null;
			this.buttonAddNewClient.Iconimage_Selected = null;
			this.buttonAddNewClient.IconMarginLeft = 0;
			this.buttonAddNewClient.IconMarginRight = 0;
			this.buttonAddNewClient.IconRightVisible = false;
			this.buttonAddNewClient.IconRightZoom = 0D;
			this.buttonAddNewClient.IconVisible = false;
			this.buttonAddNewClient.IconZoom = 1D;
			this.buttonAddNewClient.IsTab = false;
			this.buttonAddNewClient.Location = new System.Drawing.Point(5, 72);
			this.buttonAddNewClient.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAddNewClient.Name = "buttonAddNewClient";
			this.buttonAddNewClient.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonAddNewClient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
			this.buttonAddNewClient.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonAddNewClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonAddNewClient.selected = false;
			this.buttonAddNewClient.Size = new System.Drawing.Size(38, 25);
			this.buttonAddNewClient.TabIndex = 14;
			this.buttonAddNewClient.Text = "+";
			this.buttonAddNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonAddNewClient.Textcolor = System.Drawing.Color.White;
			this.buttonAddNewClient.TextFont = new System.Drawing.Font("Century Gothic", 20F);
			// 
			// comboBoxClients
			// 
			this.comboBoxClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxClients.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxClients.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxClients.FormattingEnabled = true;
			this.comboBoxClients.Location = new System.Drawing.Point(54, 70);
			this.comboBoxClients.Name = "comboBoxClients";
			this.comboBoxClients.Size = new System.Drawing.Size(221, 29);
			this.comboBoxClients.TabIndex = 1;
			this.comboBoxClients.Tag = "Клиент";
			// 
			// comboBoxCurrency
			// 
			this.comboBoxCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxCurrency.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxCurrency.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxCurrency.FormattingEnabled = true;
			this.comboBoxCurrency.Items.AddRange(new object[] {
            "₽",
            "$",
            "€",
            "₿",
            "¥"});
			this.comboBoxCurrency.Location = new System.Drawing.Point(220, 136);
			this.comboBoxCurrency.Name = "comboBoxCurrency";
			this.comboBoxCurrency.Size = new System.Drawing.Size(55, 29);
			this.comboBoxCurrency.TabIndex = 2;
			this.comboBoxCurrency.Tag = "Сервер";
			// 
			// comboBoxServers
			// 
			this.comboBoxServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxServers.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxServers.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxServers.FormattingEnabled = true;
			this.comboBoxServers.Location = new System.Drawing.Point(5, 103);
			this.comboBoxServers.Name = "comboBoxServers";
			this.comboBoxServers.Size = new System.Drawing.Size(271, 29);
			this.comboBoxServers.TabIndex = 2;
			this.comboBoxServers.Tag = "Сервер";
			// 
			// panelAddClient
			// 
			this.panelAddClient.BackColor = System.Drawing.Color.Firebrick;
			this.panelAddClient.Controls.Add(panelAddClientSpliter);
			this.panelAddClient.Controls.Add(this.buttonAddClientAdd);
			this.panelAddClient.Controls.Add(this.buttonAddClientDelete);
			this.panelAddClient.Controls.Add(this.dataGridClients);
			this.panelAddClient.Controls.Add(this.buttonClosePanelAddClient);
			this.panelAddClient.Controls.Add(this.panelAddClientBackGround);
			this.panelAddClient.Location = new System.Drawing.Point(356, 438);
			this.panelAddClient.Name = "panelAddClient";
			this.panelAddClient.Size = new System.Drawing.Size(653, 298);
			this.panelAddClient.TabIndex = 3;
			this.panelAddClient.Visible = false;
			// 
			// buttonAddClientAdd
			// 
			this.buttonAddClientAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddClientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddClientAdd.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddClientAdd.ForeColor = System.Drawing.Color.White;
			this.buttonAddClientAdd.Location = new System.Drawing.Point(432, 254);
			this.buttonAddClientAdd.Name = "buttonAddClientAdd";
			this.buttonAddClientAdd.Size = new System.Drawing.Size(109, 30);
			this.buttonAddClientAdd.TabIndex = 5;
			this.buttonAddClientAdd.Text = "Добавить";
			this.buttonAddClientAdd.UseVisualStyleBackColor = true;
			this.buttonAddClientAdd.Click += new System.EventHandler(this.buttonAddClientAdd_Click);
			// 
			// buttonAddClientDelete
			// 
			this.buttonAddClientDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddClientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddClientDelete.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddClientDelete.ForeColor = System.Drawing.Color.White;
			this.buttonAddClientDelete.Location = new System.Drawing.Point(541, 254);
			this.buttonAddClientDelete.Name = "buttonAddClientDelete";
			this.buttonAddClientDelete.Size = new System.Drawing.Size(109, 30);
			this.buttonAddClientDelete.TabIndex = 5;
			this.buttonAddClientDelete.Text = "Удалить";
			this.buttonAddClientDelete.UseVisualStyleBackColor = true;
			this.buttonAddClientDelete.Click += new System.EventHandler(this.buttonAddClientDelete_Click);
			// 
			// dataGridClients
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridClients.BackgroundColor = System.Drawing.Color.White;
			this.dataGridClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column7});
			this.dataGridClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridClients.EnableHeadersVisualStyles = false;
			this.dataGridClients.GridColor = System.Drawing.Color.Firebrick;
			this.dataGridClients.HeaderBgColor = System.Drawing.Color.White;
			this.dataGridClients.HeaderForeColor = System.Drawing.Color.Firebrick;
			this.dataGridClients.Location = new System.Drawing.Point(3, 29);
			this.dataGridClients.MultiSelect = false;
			this.dataGridClients.Name = "dataGridClients";
			this.dataGridClients.ReadOnly = true;
			this.dataGridClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridClients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridClients.ShowCellErrors = false;
			this.dataGridClients.ShowCellToolTips = false;
			this.dataGridClients.ShowEditingIcon = false;
			this.dataGridClients.ShowRowErrors = false;
			this.dataGridClients.Size = new System.Drawing.Size(423, 266);
			this.dataGridClients.TabIndex = 4;
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
			this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
			this.dataGridViewTextBoxColumn2.MaxInputLength = 32;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Номер телефона";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// buttonClosePanelAddClient
			// 
			this.buttonClosePanelAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonClosePanelAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClosePanelAddClient.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClosePanelAddClient.ForeColor = System.Drawing.Color.White;
			this.buttonClosePanelAddClient.Location = new System.Drawing.Point(620, -2);
			this.buttonClosePanelAddClient.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClosePanelAddClient.Name = "buttonClosePanelAddClient";
			this.buttonClosePanelAddClient.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.buttonClosePanelAddClient.Size = new System.Drawing.Size(33, 33);
			this.buttonClosePanelAddClient.TabIndex = 5;
			this.buttonClosePanelAddClient.Text = "X";
			this.buttonClosePanelAddClient.UseVisualStyleBackColor = true;
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
			// 
			// panelEdit
			// 
			this.panelEdit.BackColor = System.Drawing.Color.Firebrick;
			this.panelEdit.Controls.Add(this.buttonClosePanelEdit);
			this.panelEdit.Controls.Add(this.panelBackgroundEdit);
			this.panelEdit.Location = new System.Drawing.Point(307, 228);
			this.panelEdit.Name = "panelEdit";
			this.panelEdit.Size = new System.Drawing.Size(324, 412);
			this.panelEdit.TabIndex = 22;
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
			this.panelBackgroundEdit.Controls.Add(this.dateTimePickerEditOrderTime);
			this.panelBackgroundEdit.Controls.Add(this.dateTimePickerEditOrderEnd);
			this.panelBackgroundEdit.Controls.Add(this.buttonOfficeConfirmEdit);
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditDomen);
			this.panelBackgroundEdit.Controls.Add(this.textBoxEditCost);
			this.panelBackgroundEdit.Controls.Add(this.label1);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditEmployee);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditClients);
			this.panelBackgroundEdit.Controls.Add(label3);
			this.panelBackgroundEdit.Controls.Add(label2);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditServers);
			this.panelBackgroundEdit.Controls.Add(this.comboBoxEditCurrency);
			this.panelBackgroundEdit.Location = new System.Drawing.Point(3, 39);
			this.panelBackgroundEdit.Name = "panelBackgroundEdit";
			this.panelBackgroundEdit.Size = new System.Drawing.Size(318, 370);
			this.panelBackgroundEdit.TabIndex = 0;
			// 
			// dateTimePickerEditOrderTime
			// 
			this.dateTimePickerEditOrderTime.BackColor = System.Drawing.Color.Firebrick;
			this.dateTimePickerEditOrderTime.BorderRadius = 0;
			this.dateTimePickerEditOrderTime.ForeColor = System.Drawing.Color.White;
			this.dateTimePickerEditOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dateTimePickerEditOrderTime.FormatCustom = null;
			this.dateTimePickerEditOrderTime.Location = new System.Drawing.Point(21, 281);
			this.dateTimePickerEditOrderTime.Name = "dateTimePickerEditOrderTime";
			this.dateTimePickerEditOrderTime.Size = new System.Drawing.Size(271, 30);
			this.dateTimePickerEditOrderTime.TabIndex = 6;
			this.dateTimePickerEditOrderTime.Value = new System.DateTime(2020, 5, 20, 3, 6, 1, 333);
			// 
			// dateTimePickerEditOrderEnd
			// 
			this.dateTimePickerEditOrderEnd.BackColor = System.Drawing.Color.Firebrick;
			this.dateTimePickerEditOrderEnd.BorderRadius = 0;
			this.dateTimePickerEditOrderEnd.ForeColor = System.Drawing.Color.White;
			this.dateTimePickerEditOrderEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dateTimePickerEditOrderEnd.FormatCustom = null;
			this.dateTimePickerEditOrderEnd.Location = new System.Drawing.Point(22, 226);
			this.dateTimePickerEditOrderEnd.Name = "dateTimePickerEditOrderEnd";
			this.dateTimePickerEditOrderEnd.Size = new System.Drawing.Size(271, 30);
			this.dateTimePickerEditOrderEnd.TabIndex = 6;
			this.dateTimePickerEditOrderEnd.Value = new System.DateTime(2020, 5, 20, 3, 6, 1, 333);
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
			// textBoxEditDomen
			// 
			this.textBoxEditDomen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditDomen.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditDomen.Location = new System.Drawing.Point(23, 174);
			this.textBoxEditDomen.MaxLength = 255;
			this.textBoxEditDomen.Multiline = true;
			this.textBoxEditDomen.Name = "textBoxEditDomen";
			this.textBoxEditDomen.Size = new System.Drawing.Size(269, 29);
			this.textBoxEditDomen.TabIndex = 3;
			this.textBoxEditDomen.Tag = "Домен";
			// 
			// textBoxEditCost
			// 
			this.textBoxEditCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxEditCost.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxEditCost.Location = new System.Drawing.Point(23, 140);
			this.textBoxEditCost.MaxLength = 255;
			this.textBoxEditCost.Multiline = true;
			this.textBoxEditCost.Name = "textBoxEditCost";
			this.textBoxEditCost.Size = new System.Drawing.Size(212, 29);
			this.textBoxEditCost.TabIndex = 3;
			this.textBoxEditCost.Tag = "Цена";
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
			// comboBoxEditEmployee
			// 
			this.comboBoxEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditEmployee.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditEmployee.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditEmployee.FormattingEnabled = true;
			this.comboBoxEditEmployee.Location = new System.Drawing.Point(23, 39);
			this.comboBoxEditEmployee.Name = "comboBoxEditEmployee";
			this.comboBoxEditEmployee.Size = new System.Drawing.Size(269, 29);
			this.comboBoxEditEmployee.TabIndex = 1;
			this.comboBoxEditEmployee.Tag = "Сотрудник";
			// 
			// comboBoxEditClients
			// 
			this.comboBoxEditClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditClients.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditClients.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditClients.FormattingEnabled = true;
			this.comboBoxEditClients.Location = new System.Drawing.Point(23, 74);
			this.comboBoxEditClients.Name = "comboBoxEditClients";
			this.comboBoxEditClients.Size = new System.Drawing.Size(269, 29);
			this.comboBoxEditClients.TabIndex = 1;
			this.comboBoxEditClients.Tag = "Клиент";
			// 
			// comboBoxEditServers
			// 
			this.comboBoxEditServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditServers.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditServers.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditServers.FormattingEnabled = true;
			this.comboBoxEditServers.Location = new System.Drawing.Point(23, 107);
			this.comboBoxEditServers.Name = "comboBoxEditServers";
			this.comboBoxEditServers.Size = new System.Drawing.Size(270, 29);
			this.comboBoxEditServers.TabIndex = 2;
			this.comboBoxEditServers.Tag = "Сервер";
			// 
			// comboBoxEditCurrency
			// 
			this.comboBoxEditCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEditCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEditCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEditCurrency.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEditCurrency.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEditCurrency.FormattingEnabled = true;
			this.comboBoxEditCurrency.Items.AddRange(new object[] {
            "₽",
            "$",
            "€",
            "₿",
            "¥"});
			this.comboBoxEditCurrency.Location = new System.Drawing.Point(241, 140);
			this.comboBoxEditCurrency.Name = "comboBoxEditCurrency";
			this.comboBoxEditCurrency.Size = new System.Drawing.Size(52, 29);
			this.comboBoxEditCurrency.TabIndex = 2;
			this.comboBoxEditCurrency.Tag = "Сервер";
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
			this.buttonEditShow.Location = new System.Drawing.Point(819, 25);
			this.buttonEditShow.Margin = new System.Windows.Forms.Padding(5);
			this.buttonEditShow.Name = "buttonEditShow";
			this.buttonEditShow.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonEditShow.OnHovercolor = System.Drawing.Color.Brown;
			this.buttonEditShow.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonEditShow.selected = false;
			this.buttonEditShow.Size = new System.Drawing.Size(191, 34);
			this.buttonEditShow.TabIndex = 18;
			this.buttonEditShow.Text = "Изменить";
			this.buttonEditShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonEditShow.Textcolor = System.Drawing.Color.White;
			this.buttonEditShow.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonEditShow.Click += new System.EventHandler(this.buttonEditShow_Click);
			// 
			// comboBoxSearch
			// 
			this.comboBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxSearch.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxSearch.FormattingEnabled = true;
			this.comboBoxSearch.Location = new System.Drawing.Point(462, 25);
			this.comboBoxSearch.Name = "comboBoxSearch";
			this.comboBoxSearch.Size = new System.Drawing.Size(221, 29);
			this.comboBoxSearch.TabIndex = 23;
			this.comboBoxSearch.Tag = "Тип сервера";
			// 
			// OrdersControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.comboBoxSearch);
			this.Controls.Add(this.buttonEditShow);
			this.Controls.Add(this.panelEdit);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddClient);
			this.Controls.Add(this.panelAddOrder);
			this.Controls.Add(this.dataGridViewMain);
			this.DoubleBuffered = true;
			this.Name = "OrdersControl";
			this.Size = new System.Drawing.Size(1300, 820);
			this.panelAddClientBackGround.ResumeLayout(false);
			this.panelAddClientBackGround.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddOrder.ResumeLayout(false);
			this.panelAddOrder.PerformLayout();
			this.panelAddClient.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
			this.panelEdit.ResumeLayout(false);
			this.panelBackgroundEdit.ResumeLayout(false);
			this.panelBackgroundEdit.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddOrder;
		private System.Windows.Forms.ComboBox comboBoxServers;
		private System.Windows.Forms.ComboBox comboBoxClients;
		private Bunifu.Framework.UI.BunifuFlatButton buttonAddNewClient;
		private System.Windows.Forms.Panel panelAddClient;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridClients;
		private System.Windows.Forms.Button buttonAddClientDelete;
		private System.Windows.Forms.Button buttonClosePanelAddClient;
		private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxAddClientFullName;
		private System.Windows.Forms.Button buttonAddClientAdd;
		private System.Windows.Forms.Button buttonOrderAdd;
		private System.Windows.Forms.Button buttonOrderDelete;
		private System.Windows.Forms.TextBox textBoxCost;
		private ns1.BunifuDatepicker dateTimePickerOrderEnd;
		private System.Windows.Forms.TextBox textBoxSearch;
		private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxAddClientPhoneNumber;
		private System.Windows.Forms.ComboBox comboBoxCurrency;
		private System.Windows.Forms.Panel panelAddClientBackGround;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Panel panelEdit;
		private System.Windows.Forms.Button buttonClosePanelEdit;
		private System.Windows.Forms.Panel panelBackgroundEdit;
		private System.Windows.Forms.Button buttonOfficeConfirmEdit;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuFlatButton buttonEditShow;
		private ns1.BunifuDatepicker dateTimePickerEditOrderTime;
		private ns1.BunifuDatepicker dateTimePickerEditOrderEnd;
		private System.Windows.Forms.TextBox textBoxEditCost;
		private System.Windows.Forms.ComboBox comboBoxEditEmployee;
		private System.Windows.Forms.ComboBox comboBoxEditClients;
		private System.Windows.Forms.ComboBox comboBoxEditServers;
		private System.Windows.Forms.ComboBox comboBoxEditCurrency;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.TextBox textBoxDomen;
		private System.Windows.Forms.TextBox textBoxEditDomen;
		private System.Windows.Forms.Button buttonExcel;
		private System.Windows.Forms.ComboBox comboBoxSearch;
	}
}
