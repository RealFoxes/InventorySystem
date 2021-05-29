namespace DesktopVersion
{
	partial class ServersControl
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
			System.Windows.Forms.Label labelSearch;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panelAddServer = new System.Windows.Forms.Panel();
			this.textBoxServerName = new System.Windows.Forms.TextBox();
			this.buttonServerDelete = new System.Windows.Forms.Button();
			this.buttonServerAdd = new System.Windows.Forms.Button();
			this.buttonAddNewTypeOfServer = new Bunifu.Framework.UI.BunifuFlatButton();
			this.textBoxDetails = new System.Windows.Forms.TextBox();
			this.comboBoxTypeOfServer = new System.Windows.Forms.ComboBox();
			this.comboBoxOffices = new System.Windows.Forms.ComboBox();
			this.panelAddTypеOfServer = new System.Windows.Forms.Panel();
			this.textBoxAddTypeOfServer = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.buttonAddTypeOfServerAdd = new System.Windows.Forms.Button();
			this.buttonAddTypeOfServerDelete = new System.Windows.Forms.Button();
			this.dataGridTypeOfServer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonClosePanelAddTypeOfServer = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			label = new System.Windows.Forms.Label();
			labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddServer.SuspendLayout();
			this.panelAddTypеOfServer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfServer)).BeginInit();
			this.SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label.ForeColor = System.Drawing.Color.Firebrick;
			label.Location = new System.Drawing.Point(50, 0);
			label.Name = "label";
			label.Size = new System.Drawing.Size(179, 48);
			label.TabIndex = 5;
			label.Text = "Добавить новый\r\nсервер";
			label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSearch
			// 
			labelSearch.AutoSize = true;
			labelSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelSearch.ForeColor = System.Drawing.Color.Firebrick;
			labelSearch.Location = new System.Drawing.Point(9, 29);
			labelSearch.Name = "labelSearch";
			labelSearch.Size = new System.Drawing.Size(76, 24);
			labelSearch.TabIndex = 17;
			labelSearch.Text = "Поиск";
			labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Column3,
            this.Column2});
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
			// panelAddServer
			// 
			this.panelAddServer.Controls.Add(this.textBoxServerName);
			this.panelAddServer.Controls.Add(this.buttonServerDelete);
			this.panelAddServer.Controls.Add(this.buttonServerAdd);
			this.panelAddServer.Controls.Add(this.buttonAddNewTypeOfServer);
			this.panelAddServer.Controls.Add(this.textBoxDetails);
			this.panelAddServer.Controls.Add(this.comboBoxTypeOfServer);
			this.panelAddServer.Controls.Add(this.comboBoxOffices);
			this.panelAddServer.Controls.Add(label);
			this.panelAddServer.Location = new System.Drawing.Point(1015, 10);
			this.panelAddServer.Name = "panelAddServer";
			this.panelAddServer.Size = new System.Drawing.Size(280, 800);
			this.panelAddServer.TabIndex = 1;
			// 
			// textBoxServerName
			// 
			this.textBoxServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxServerName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxServerName.Location = new System.Drawing.Point(6, 136);
			this.textBoxServerName.MaxLength = 255;
			this.textBoxServerName.Multiline = true;
			this.textBoxServerName.Name = "textBoxServerName";
			this.textBoxServerName.Size = new System.Drawing.Size(271, 29);
			this.textBoxServerName.TabIndex = 16;
			this.textBoxServerName.Tag = "Наименование";
			// 
			// buttonServerDelete
			// 
			this.buttonServerDelete.BackColor = System.Drawing.Color.Firebrick;
			this.buttonServerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonServerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonServerDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonServerDelete.ForeColor = System.Drawing.Color.White;
			this.buttonServerDelete.Location = new System.Drawing.Point(5, 740);
			this.buttonServerDelete.Name = "buttonServerDelete";
			this.buttonServerDelete.Size = new System.Drawing.Size(270, 52);
			this.buttonServerDelete.TabIndex = 15;
			this.buttonServerDelete.Text = "Удалить";
			this.buttonServerDelete.UseVisualStyleBackColor = false;
			this.buttonServerDelete.Click += new System.EventHandler(this.buttonServerDelete_Click);
			// 
			// buttonServerAdd
			// 
			this.buttonServerAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonServerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonServerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonServerAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonServerAdd.ForeColor = System.Drawing.Color.White;
			this.buttonServerAdd.Location = new System.Drawing.Point(5, 682);
			this.buttonServerAdd.Name = "buttonServerAdd";
			this.buttonServerAdd.Size = new System.Drawing.Size(270, 52);
			this.buttonServerAdd.TabIndex = 15;
			this.buttonServerAdd.Text = "Добавить";
			this.buttonServerAdd.UseVisualStyleBackColor = false;
			this.buttonServerAdd.Click += new System.EventHandler(this.buttonServerAdd_Click);
			// 
			// buttonAddNewTypeOfServer
			// 
			this.buttonAddNewTypeOfServer.Activecolor = System.Drawing.Color.Brown;
			this.buttonAddNewTypeOfServer.BackColor = System.Drawing.Color.Firebrick;
			this.buttonAddNewTypeOfServer.BackgroundImage = global::DesktopVersion.Properties.Resources.add;
			this.buttonAddNewTypeOfServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAddNewTypeOfServer.BorderRadius = 0;
			this.buttonAddNewTypeOfServer.ButtonText = "";
			this.buttonAddNewTypeOfServer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddNewTypeOfServer.DisabledColor = System.Drawing.Color.Gray;
			this.buttonAddNewTypeOfServer.Font = new System.Drawing.Font("Century Gothic", 8.75F);
			this.buttonAddNewTypeOfServer.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonAddNewTypeOfServer.Iconimage = null;
			this.buttonAddNewTypeOfServer.Iconimage_right = null;
			this.buttonAddNewTypeOfServer.Iconimage_right_Selected = null;
			this.buttonAddNewTypeOfServer.Iconimage_Selected = null;
			this.buttonAddNewTypeOfServer.IconMarginLeft = 0;
			this.buttonAddNewTypeOfServer.IconMarginRight = 0;
			this.buttonAddNewTypeOfServer.IconRightVisible = false;
			this.buttonAddNewTypeOfServer.IconRightZoom = 0D;
			this.buttonAddNewTypeOfServer.IconVisible = false;
			this.buttonAddNewTypeOfServer.IconZoom = 1D;
			this.buttonAddNewTypeOfServer.IsTab = false;
			this.buttonAddNewTypeOfServer.Location = new System.Drawing.Point(5, 72);
			this.buttonAddNewTypeOfServer.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAddNewTypeOfServer.Name = "buttonAddNewTypeOfServer";
			this.buttonAddNewTypeOfServer.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonAddNewTypeOfServer.OnHovercolor = System.Drawing.Color.Brown;
			this.buttonAddNewTypeOfServer.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonAddNewTypeOfServer.selected = false;
			this.buttonAddNewTypeOfServer.Size = new System.Drawing.Size(38, 25);
			this.buttonAddNewTypeOfServer.TabIndex = 14;
			this.buttonAddNewTypeOfServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAddNewTypeOfServer.Textcolor = System.Drawing.Color.White;
			this.buttonAddNewTypeOfServer.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			// 
			// textBoxDetails
			// 
			this.textBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxDetails.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxDetails.Location = new System.Drawing.Point(6, 171);
			this.textBoxDetails.MaxLength = 255;
			this.textBoxDetails.Multiline = true;
			this.textBoxDetails.Name = "textBoxDetails";
			this.textBoxDetails.Size = new System.Drawing.Size(271, 232);
			this.textBoxDetails.TabIndex = 13;
			this.textBoxDetails.Tag = "Дополнительная информация";
			// 
			// comboBoxTypeOfServer
			// 
			this.comboBoxTypeOfServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxTypeOfServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxTypeOfServer.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxTypeOfServer.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxTypeOfServer.FormattingEnabled = true;
			this.comboBoxTypeOfServer.Location = new System.Drawing.Point(54, 70);
			this.comboBoxTypeOfServer.Name = "comboBoxTypeOfServer";
			this.comboBoxTypeOfServer.Size = new System.Drawing.Size(221, 29);
			this.comboBoxTypeOfServer.TabIndex = 12;
			this.comboBoxTypeOfServer.Tag = "Тип сервера";
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
			this.comboBoxOffices.TabIndex = 12;
			this.comboBoxOffices.Tag = "Офис";
			// 
			// panelAddTypеOfServer
			// 
			this.panelAddTypеOfServer.BackColor = System.Drawing.Color.Firebrick;
			this.panelAddTypеOfServer.Controls.Add(this.textBoxAddTypeOfServer);
			this.panelAddTypеOfServer.Controls.Add(this.buttonAddTypeOfServerAdd);
			this.panelAddTypеOfServer.Controls.Add(this.buttonAddTypeOfServerDelete);
			this.panelAddTypеOfServer.Controls.Add(this.dataGridTypeOfServer);
			this.panelAddTypеOfServer.Controls.Add(this.buttonClosePanelAddTypeOfServer);
			this.panelAddTypеOfServer.Location = new System.Drawing.Point(559, 510);
			this.panelAddTypеOfServer.Name = "panelAddTypеOfServer";
			this.panelAddTypеOfServer.Size = new System.Drawing.Size(450, 300);
			this.panelAddTypеOfServer.TabIndex = 3;
			this.panelAddTypеOfServer.Visible = false;
			// 
			// textBoxAddTypeOfServer
			// 
			this.textBoxAddTypeOfServer.BackColor = System.Drawing.Color.White;
			this.textBoxAddTypeOfServer.BorderColorFocused = System.Drawing.Color.Firebrick;
			this.textBoxAddTypeOfServer.BorderColorIdle = System.Drawing.Color.Firebrick;
			this.textBoxAddTypeOfServer.BorderColorMouseHover = System.Drawing.Color.Firebrick;
			this.textBoxAddTypeOfServer.BorderThickness = 1;
			this.textBoxAddTypeOfServer.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxAddTypeOfServer.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.textBoxAddTypeOfServer.ForeColor = System.Drawing.Color.Gray;
			this.textBoxAddTypeOfServer.isPassword = false;
			this.textBoxAddTypeOfServer.Location = new System.Drawing.Point(17, 262);
			this.textBoxAddTypeOfServer.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxAddTypeOfServer.Name = "textBoxAddTypeOfServer";
			this.textBoxAddTypeOfServer.Size = new System.Drawing.Size(197, 30);
			this.textBoxAddTypeOfServer.TabIndex = 15;
			this.textBoxAddTypeOfServer.Tag = "";
			this.textBoxAddTypeOfServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// buttonAddTypeOfServerAdd
			// 
			this.buttonAddTypeOfServerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddTypeOfServerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTypeOfServerAdd.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddTypeOfServerAdd.ForeColor = System.Drawing.Color.White;
			this.buttonAddTypeOfServerAdd.Location = new System.Drawing.Point(221, 262);
			this.buttonAddTypeOfServerAdd.Name = "buttonAddTypeOfServerAdd";
			this.buttonAddTypeOfServerAdd.Size = new System.Drawing.Size(109, 30);
			this.buttonAddTypeOfServerAdd.TabIndex = 5;
			this.buttonAddTypeOfServerAdd.Text = "Добавить";
			this.buttonAddTypeOfServerAdd.UseVisualStyleBackColor = true;
			this.buttonAddTypeOfServerAdd.Click += new System.EventHandler(this.buttonAddTypeOfServerAdd_Click);
			// 
			// buttonAddTypeOfServerDelete
			// 
			this.buttonAddTypeOfServerDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddTypeOfServerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTypeOfServerDelete.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddTypeOfServerDelete.ForeColor = System.Drawing.Color.White;
			this.buttonAddTypeOfServerDelete.Location = new System.Drawing.Point(332, 262);
			this.buttonAddTypeOfServerDelete.Name = "buttonAddTypeOfServerDelete";
			this.buttonAddTypeOfServerDelete.Size = new System.Drawing.Size(109, 30);
			this.buttonAddTypeOfServerDelete.TabIndex = 5;
			this.buttonAddTypeOfServerDelete.Text = "Удалить";
			this.buttonAddTypeOfServerDelete.UseVisualStyleBackColor = true;
			this.buttonAddTypeOfServerDelete.Click += new System.EventHandler(this.buttonAddTypeOfServerDelete_Click);
			// 
			// dataGridTypeOfServer
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridTypeOfServer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridTypeOfServer.BackgroundColor = System.Drawing.Color.White;
			this.dataGridTypeOfServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridTypeOfServer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridTypeOfServer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridTypeOfServer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridTypeOfServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridTypeOfServer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dataGridTypeOfServer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridTypeOfServer.EnableHeadersVisualStyles = false;
			this.dataGridTypeOfServer.GridColor = System.Drawing.Color.Firebrick;
			this.dataGridTypeOfServer.HeaderBgColor = System.Drawing.Color.White;
			this.dataGridTypeOfServer.HeaderForeColor = System.Drawing.Color.Firebrick;
			this.dataGridTypeOfServer.Location = new System.Drawing.Point(3, 29);
			this.dataGridTypeOfServer.MultiSelect = false;
			this.dataGridTypeOfServer.Name = "dataGridTypeOfServer";
			this.dataGridTypeOfServer.ReadOnly = true;
			this.dataGridTypeOfServer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridTypeOfServer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridTypeOfServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridTypeOfServer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridTypeOfServer.ShowCellErrors = false;
			this.dataGridTypeOfServer.ShowCellToolTips = false;
			this.dataGridTypeOfServer.ShowEditingIcon = false;
			this.dataGridTypeOfServer.ShowRowErrors = false;
			this.dataGridTypeOfServer.Size = new System.Drawing.Size(444, 268);
			this.dataGridTypeOfServer.TabIndex = 4;
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
			this.dataGridViewTextBoxColumn2.HeaderText = "Тип сервера";
			this.dataGridViewTextBoxColumn2.MaxInputLength = 32;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// buttonClosePanelAddTypeOfServer
			// 
			this.buttonClosePanelAddTypeOfServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonClosePanelAddTypeOfServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClosePanelAddTypeOfServer.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClosePanelAddTypeOfServer.ForeColor = System.Drawing.Color.White;
			this.buttonClosePanelAddTypeOfServer.Location = new System.Drawing.Point(414, -2);
			this.buttonClosePanelAddTypeOfServer.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClosePanelAddTypeOfServer.Name = "buttonClosePanelAddTypeOfServer";
			this.buttonClosePanelAddTypeOfServer.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.buttonClosePanelAddTypeOfServer.Size = new System.Drawing.Size(33, 33);
			this.buttonClosePanelAddTypeOfServer.TabIndex = 5;
			this.buttonClosePanelAddTypeOfServer.Text = "X";
			this.buttonClosePanelAddTypeOfServer.UseVisualStyleBackColor = true;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxSearch.Location = new System.Drawing.Point(91, 29);
			this.textBoxSearch.MaxLength = 255;
			this.textBoxSearch.Multiline = true;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(363, 29);
			this.textBoxSearch.TabIndex = 16;
			this.textBoxSearch.Tag = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
			this.Column4.HeaderText = "Тип сервера";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Наименование";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Наимен. Офиса ";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Доп. Информация ";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// ServersControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddTypеOfServer);
			this.Controls.Add(this.panelAddServer);
			this.Controls.Add(this.dataGridViewMain);
			this.DoubleBuffered = true;
			this.Name = "ServersControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddServer.ResumeLayout(false);
			this.panelAddServer.PerformLayout();
			this.panelAddTypеOfServer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfServer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddServer;
		private System.Windows.Forms.ComboBox comboBoxOffices;
		private System.Windows.Forms.ComboBox comboBoxTypeOfServer;
		private System.Windows.Forms.TextBox textBoxDetails;
		private Bunifu.Framework.UI.BunifuFlatButton buttonAddNewTypeOfServer;
		private System.Windows.Forms.Panel panelAddTypеOfServer;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridTypeOfServer;
		private System.Windows.Forms.Button buttonAddTypeOfServerDelete;
		private System.Windows.Forms.Button buttonClosePanelAddTypeOfServer;
		private Bunifu.Framework.UI.BunifuMetroTextbox textBoxAddTypeOfServer;
		private System.Windows.Forms.Button buttonAddTypeOfServerAdd;
		private System.Windows.Forms.Button buttonServerAdd;
		private System.Windows.Forms.Button buttonServerDelete;
		private System.Windows.Forms.TextBox textBoxServerName;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}
