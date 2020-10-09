namespace DesktopVersion
{
	partial class ItemsControl
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
			System.Windows.Forms.Label labelAuthorizationsMain;
			System.Windows.Forms.Label labelSearch;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddItem = new System.Windows.Forms.Panel();
			this.textBoxItemName = new System.Windows.Forms.TextBox();
			this.buttonItemDelete = new System.Windows.Forms.Button();
			this.buttonItemAdd = new System.Windows.Forms.Button();
			this.buttonAddNewTypeOfItem = new Bunifu.Framework.UI.BunifuFlatButton();
			this.textBoxDetails = new System.Windows.Forms.TextBox();
			this.comboBoxTypeOfItem = new System.Windows.Forms.ComboBox();
			this.comboBoxOffices = new System.Windows.Forms.ComboBox();
			this.panelAddTypеOfItem = new System.Windows.Forms.Panel();
			this.TextBoxAddTypeOfItem = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.buttonAddTypeOfItemAdd = new System.Windows.Forms.Button();
			this.buttonAddTypeOfItemDelete = new System.Windows.Forms.Button();
			this.dataGridTypeOfItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonClosePanelAddTypeOfItem = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			labelAuthorizationsMain = new System.Windows.Forms.Label();
			labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddItem.SuspendLayout();
			this.panelAddTypеOfItem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfItem)).BeginInit();
			this.SuspendLayout();
			// 
			// labelAuthorizationsMain
			// 
			labelAuthorizationsMain.AutoSize = true;
			labelAuthorizationsMain.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelAuthorizationsMain.ForeColor = System.Drawing.Color.Firebrick;
			labelAuthorizationsMain.Location = new System.Drawing.Point(50, 0);
			labelAuthorizationsMain.Name = "labelAuthorizationsMain";
			labelAuthorizationsMain.Size = new System.Drawing.Size(179, 48);
			labelAuthorizationsMain.TabIndex = 5;
			labelAuthorizationsMain.Text = "Добавить новый\r\nпредмет";
			labelAuthorizationsMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Column2,
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
			this.Column4.HeaderText = "Тип предмета";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Наименование";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Доп. Информация ";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Наимен. Офиса ";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// panelAddItem
			// 
			this.panelAddItem.Controls.Add(this.textBoxItemName);
			this.panelAddItem.Controls.Add(this.buttonItemDelete);
			this.panelAddItem.Controls.Add(this.buttonItemAdd);
			this.panelAddItem.Controls.Add(this.buttonAddNewTypeOfItem);
			this.panelAddItem.Controls.Add(this.textBoxDetails);
			this.panelAddItem.Controls.Add(this.comboBoxTypeOfItem);
			this.panelAddItem.Controls.Add(this.comboBoxOffices);
			this.panelAddItem.Controls.Add(labelAuthorizationsMain);
			this.panelAddItem.Location = new System.Drawing.Point(1015, 10);
			this.panelAddItem.Name = "panelAddItem";
			this.panelAddItem.Size = new System.Drawing.Size(280, 800);
			this.panelAddItem.TabIndex = 1;
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
			this.textBoxItemName.TabIndex = 16;
			this.textBoxItemName.Tag = "Наименование";
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
			this.buttonItemAdd.TabIndex = 15;
			this.buttonItemAdd.Text = "Добавить";
			this.buttonItemAdd.UseVisualStyleBackColor = false;
			this.buttonItemAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
			// 
			// buttonAddNewTypeOfItem
			// 
			this.buttonAddNewTypeOfItem.Activecolor = System.Drawing.Color.Brown;
			this.buttonAddNewTypeOfItem.BackColor = System.Drawing.Color.Firebrick;
			this.buttonAddNewTypeOfItem.BackgroundImage = global::DesktopVersion.Properties.Resources.add;
			this.buttonAddNewTypeOfItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonAddNewTypeOfItem.BorderRadius = 0;
			this.buttonAddNewTypeOfItem.ButtonText = "";
			this.buttonAddNewTypeOfItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddNewTypeOfItem.DisabledColor = System.Drawing.Color.Gray;
			this.buttonAddNewTypeOfItem.Font = new System.Drawing.Font("Century Gothic", 8.75F);
			this.buttonAddNewTypeOfItem.Iconcolor = System.Drawing.Color.Transparent;
			this.buttonAddNewTypeOfItem.Iconimage = null;
			this.buttonAddNewTypeOfItem.Iconimage_right = null;
			this.buttonAddNewTypeOfItem.Iconimage_right_Selected = null;
			this.buttonAddNewTypeOfItem.Iconimage_Selected = null;
			this.buttonAddNewTypeOfItem.IconMarginLeft = 0;
			this.buttonAddNewTypeOfItem.IconMarginRight = 0;
			this.buttonAddNewTypeOfItem.IconRightVisible = false;
			this.buttonAddNewTypeOfItem.IconRightZoom = 0D;
			this.buttonAddNewTypeOfItem.IconVisible = false;
			this.buttonAddNewTypeOfItem.IconZoom = 1D;
			this.buttonAddNewTypeOfItem.IsTab = false;
			this.buttonAddNewTypeOfItem.Location = new System.Drawing.Point(5, 72);
			this.buttonAddNewTypeOfItem.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAddNewTypeOfItem.Name = "buttonAddNewTypeOfItem";
			this.buttonAddNewTypeOfItem.Normalcolor = System.Drawing.Color.Firebrick;
			this.buttonAddNewTypeOfItem.OnHovercolor = System.Drawing.Color.Brown;
			this.buttonAddNewTypeOfItem.OnHoverTextColor = System.Drawing.Color.White;
			this.buttonAddNewTypeOfItem.selected = false;
			this.buttonAddNewTypeOfItem.Size = new System.Drawing.Size(38, 25);
			this.buttonAddNewTypeOfItem.TabIndex = 14;
			this.buttonAddNewTypeOfItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonAddNewTypeOfItem.Textcolor = System.Drawing.Color.White;
			this.buttonAddNewTypeOfItem.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonAddNewTypeOfItem.Click += new System.EventHandler(this.buttonAddNewTypeOfItem_Click);
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
			this.textBoxDetails.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.textBoxDetails.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// comboBoxTypeOfItem
			// 
			this.comboBoxTypeOfItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxTypeOfItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxTypeOfItem.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxTypeOfItem.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxTypeOfItem.FormattingEnabled = true;
			this.comboBoxTypeOfItem.Location = new System.Drawing.Point(54, 70);
			this.comboBoxTypeOfItem.Name = "comboBoxTypeOfItem";
			this.comboBoxTypeOfItem.Size = new System.Drawing.Size(221, 29);
			this.comboBoxTypeOfItem.TabIndex = 12;
			this.comboBoxTypeOfItem.Tag = "Тип предмета";
			this.comboBoxTypeOfItem.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.comboBoxTypeOfItem.Leave += new System.EventHandler(this.LeaveFromElementsRight);
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
			this.comboBoxOffices.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.comboBoxOffices.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// panelAddTypеOfItem
			// 
			this.panelAddTypеOfItem.BackColor = System.Drawing.Color.Firebrick;
			this.panelAddTypеOfItem.Controls.Add(this.TextBoxAddTypeOfItem);
			this.panelAddTypеOfItem.Controls.Add(this.buttonAddTypeOfItemAdd);
			this.panelAddTypеOfItem.Controls.Add(this.buttonAddTypeOfItemDelete);
			this.panelAddTypеOfItem.Controls.Add(this.dataGridTypeOfItem);
			this.panelAddTypеOfItem.Controls.Add(this.buttonClosePanelAddTypeOfItem);
			this.panelAddTypеOfItem.Location = new System.Drawing.Point(559, 510);
			this.panelAddTypеOfItem.Name = "panelAddTypеOfItem";
			this.panelAddTypеOfItem.Size = new System.Drawing.Size(450, 300);
			this.panelAddTypеOfItem.TabIndex = 3;
			this.panelAddTypеOfItem.Visible = false;
			this.panelAddTypеOfItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAddTypеOfItem_MouseDown);
			this.panelAddTypеOfItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAddTypеOfItem_MouseMove);
			this.panelAddTypеOfItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAddTypеOfItem_MouseUp);
			// 
			// TextBoxAddTypeOfItem
			// 
			this.TextBoxAddTypeOfItem.BackColor = System.Drawing.Color.White;
			this.TextBoxAddTypeOfItem.BorderColorFocused = System.Drawing.Color.Firebrick;
			this.TextBoxAddTypeOfItem.BorderColorIdle = System.Drawing.Color.Firebrick;
			this.TextBoxAddTypeOfItem.BorderColorMouseHover = System.Drawing.Color.Firebrick;
			this.TextBoxAddTypeOfItem.BorderThickness = 1;
			this.TextBoxAddTypeOfItem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TextBoxAddTypeOfItem.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.TextBoxAddTypeOfItem.ForeColor = System.Drawing.Color.Gray;
			this.TextBoxAddTypeOfItem.isPassword = false;
			this.TextBoxAddTypeOfItem.Location = new System.Drawing.Point(17, 262);
			this.TextBoxAddTypeOfItem.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxAddTypeOfItem.Name = "TextBoxAddTypeOfItem";
			this.TextBoxAddTypeOfItem.Size = new System.Drawing.Size(197, 30);
			this.TextBoxAddTypeOfItem.TabIndex = 15;
			this.TextBoxAddTypeOfItem.Tag = "";
			this.TextBoxAddTypeOfItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// buttonAddTypeOfItemAdd
			// 
			this.buttonAddTypeOfItemAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddTypeOfItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTypeOfItemAdd.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddTypeOfItemAdd.ForeColor = System.Drawing.Color.White;
			this.buttonAddTypeOfItemAdd.Location = new System.Drawing.Point(221, 262);
			this.buttonAddTypeOfItemAdd.Name = "buttonAddTypeOfItemAdd";
			this.buttonAddTypeOfItemAdd.Size = new System.Drawing.Size(109, 30);
			this.buttonAddTypeOfItemAdd.TabIndex = 5;
			this.buttonAddTypeOfItemAdd.Text = "Добавить";
			this.buttonAddTypeOfItemAdd.UseVisualStyleBackColor = true;
			this.buttonAddTypeOfItemAdd.Click += new System.EventHandler(this.buttonAddTypeOfItemAdd_Click);
			// 
			// buttonAddTypeOfItemDelete
			// 
			this.buttonAddTypeOfItemDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAddTypeOfItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTypeOfItemDelete.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.buttonAddTypeOfItemDelete.ForeColor = System.Drawing.Color.White;
			this.buttonAddTypeOfItemDelete.Location = new System.Drawing.Point(332, 262);
			this.buttonAddTypeOfItemDelete.Name = "buttonAddTypeOfItemDelete";
			this.buttonAddTypeOfItemDelete.Size = new System.Drawing.Size(109, 30);
			this.buttonAddTypeOfItemDelete.TabIndex = 5;
			this.buttonAddTypeOfItemDelete.Text = "Удалить";
			this.buttonAddTypeOfItemDelete.UseVisualStyleBackColor = true;
			this.buttonAddTypeOfItemDelete.Click += new System.EventHandler(this.buttonAddTypeOfItemDelete_Click);
			// 
			// dataGridTypeOfItem
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridTypeOfItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridTypeOfItem.BackgroundColor = System.Drawing.Color.White;
			this.dataGridTypeOfItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridTypeOfItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridTypeOfItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Firebrick;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridTypeOfItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridTypeOfItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridTypeOfItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dataGridTypeOfItem.DoubleBuffered = true;
			this.dataGridTypeOfItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridTypeOfItem.EnableHeadersVisualStyles = false;
			this.dataGridTypeOfItem.GridColor = System.Drawing.Color.Firebrick;
			this.dataGridTypeOfItem.HeaderBgColor = System.Drawing.Color.White;
			this.dataGridTypeOfItem.HeaderForeColor = System.Drawing.Color.Firebrick;
			this.dataGridTypeOfItem.Location = new System.Drawing.Point(3, 29);
			this.dataGridTypeOfItem.MultiSelect = false;
			this.dataGridTypeOfItem.Name = "dataGridTypeOfItem";
			this.dataGridTypeOfItem.ReadOnly = true;
			this.dataGridTypeOfItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridTypeOfItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridTypeOfItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridTypeOfItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridTypeOfItem.ShowCellErrors = false;
			this.dataGridTypeOfItem.ShowCellToolTips = false;
			this.dataGridTypeOfItem.ShowEditingIcon = false;
			this.dataGridTypeOfItem.ShowRowErrors = false;
			this.dataGridTypeOfItem.Size = new System.Drawing.Size(444, 268);
			this.dataGridTypeOfItem.TabIndex = 4;
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
			this.dataGridViewTextBoxColumn2.HeaderText = "Тип предмета";
			this.dataGridViewTextBoxColumn2.MaxInputLength = 32;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// buttonClosePanelAddTypeOfItem
			// 
			this.buttonClosePanelAddTypeOfItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonClosePanelAddTypeOfItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClosePanelAddTypeOfItem.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClosePanelAddTypeOfItem.ForeColor = System.Drawing.Color.White;
			this.buttonClosePanelAddTypeOfItem.Location = new System.Drawing.Point(414, -2);
			this.buttonClosePanelAddTypeOfItem.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClosePanelAddTypeOfItem.Name = "buttonClosePanelAddTypeOfItem";
			this.buttonClosePanelAddTypeOfItem.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.buttonClosePanelAddTypeOfItem.Size = new System.Drawing.Size(33, 33);
			this.buttonClosePanelAddTypeOfItem.TabIndex = 5;
			this.buttonClosePanelAddTypeOfItem.Text = "X";
			this.buttonClosePanelAddTypeOfItem.UseVisualStyleBackColor = true;
			this.buttonClosePanelAddTypeOfItem.Click += new System.EventHandler(this.buttonClosePanelAddTypeOfItem_Click);
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
			this.textBoxSearch.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.textBoxSearch.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// ItemsControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddTypеOfItem);
			this.Controls.Add(this.panelAddItem);
			this.Controls.Add(this.dataGridViewMain);
			this.DoubleBuffered = true;
			this.Name = "ItemsControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddItem.ResumeLayout(false);
			this.panelAddItem.PerformLayout();
			this.panelAddTypеOfItem.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridTypeOfItem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddItem;
		private System.Windows.Forms.ComboBox comboBoxOffices;
		private System.Windows.Forms.ComboBox comboBoxTypeOfItem;
		private System.Windows.Forms.TextBox textBoxDetails;
		private Bunifu.Framework.UI.BunifuFlatButton buttonAddNewTypeOfItem;
		private System.Windows.Forms.Panel panelAddTypеOfItem;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridTypeOfItem;
		private System.Windows.Forms.Button buttonAddTypeOfItemDelete;
		private System.Windows.Forms.Button buttonClosePanelAddTypeOfItem;
		private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxAddTypeOfItem;
		private System.Windows.Forms.Button buttonAddTypeOfItemAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Button buttonItemAdd;
		private System.Windows.Forms.Button buttonItemDelete;
		private System.Windows.Forms.TextBox textBoxItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.TextBox textBoxSearch;
	}
}
