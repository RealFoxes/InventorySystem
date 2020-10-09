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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.Label labelSearch;
			this.labelAuthorizationsMain = new System.Windows.Forms.Label();
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
			this.textBoxDetails = new System.Windows.Forms.TextBox();
			this.comboBoxAccessLVL = new System.Windows.Forms.ComboBox();
			this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddItem.SuspendLayout();
			this.SuspendLayout();
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
			// panelAddItem
			// 
			this.panelAddItem.Controls.Add(this.textBoxItemName);
			this.panelAddItem.Controls.Add(this.buttonItemDelete);
			this.panelAddItem.Controls.Add(this.buttonItemAdd);
			this.panelAddItem.Controls.Add(this.textBoxDetails);
			this.panelAddItem.Controls.Add(this.comboBoxAccessLVL);
			this.panelAddItem.Controls.Add(this.comboBoxEmployees);
			this.panelAddItem.Controls.Add(this.labelAuthorizationsMain);
			this.panelAddItem.Location = new System.Drawing.Point(1015, 10);
			this.panelAddItem.Name = "panelAddItem";
			this.panelAddItem.Size = new System.Drawing.Size(280, 800);
			this.panelAddItem.TabIndex = 1;
			// 
			// textBoxItemName
			// 
			this.textBoxItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxItemName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxItemName.Location = new System.Drawing.Point(5, 157);
			this.textBoxItemName.MaxLength = 255;
			this.textBoxItemName.Multiline = true;
			this.textBoxItemName.Name = "textBoxItemName";
			this.textBoxItemName.Size = new System.Drawing.Size(271, 29);
			this.textBoxItemName.TabIndex = 16;
			this.textBoxItemName.Tag = "Логин";
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
			// textBoxDetails
			// 
			this.textBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxDetails.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxDetails.Location = new System.Drawing.Point(4, 192);
			this.textBoxDetails.MaxLength = 255;
			this.textBoxDetails.Multiline = true;
			this.textBoxDetails.Name = "textBoxDetails";
			this.textBoxDetails.Size = new System.Drawing.Size(271, 29);
			this.textBoxDetails.TabIndex = 13;
			this.textBoxDetails.Tag = "Пароль";
			this.textBoxDetails.UseSystemPasswordChar = true;
			this.textBoxDetails.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.textBoxDetails.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// comboBoxAccessLVL
			// 
			this.comboBoxAccessLVL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
			this.comboBoxAccessLVL.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.comboBoxAccessLVL.Leave += new System.EventHandler(this.LeaveFromElementsRight);
			// 
			// comboBoxEmployees
			// 
			this.comboBoxEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comboBoxEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.comboBoxEmployees.ForeColor = System.Drawing.Color.Gray;
			this.comboBoxEmployees.FormattingEnabled = true;
			this.comboBoxEmployees.Location = new System.Drawing.Point(5, 86);
			this.comboBoxEmployees.Name = "comboBoxEmployees";
			this.comboBoxEmployees.Size = new System.Drawing.Size(272, 29);
			this.comboBoxEmployees.TabIndex = 12;
			this.comboBoxEmployees.Tag = "Сотрудник";
			this.comboBoxEmployees.Enter += new System.EventHandler(this.EnterInElementsRight);
			this.comboBoxEmployees.Leave += new System.EventHandler(this.LeaveFromElementsRight);
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
			// UsersControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddItem);
			this.Controls.Add(this.dataGridViewMain);
			this.DoubleBuffered = true;
			this.Name = "UsersControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddItem.ResumeLayout(false);
			this.panelAddItem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddItem;
		private System.Windows.Forms.TextBox textBoxDetails;
		private System.Windows.Forms.Button buttonItemAdd;
		private System.Windows.Forms.Button buttonItemDelete;
		private System.Windows.Forms.TextBox textBoxItemName;
		private System.Windows.Forms.Label labelAuthorizationsMain;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.ComboBox comboBoxAccessLVL;
		private System.Windows.Forms.ComboBox comboBoxEmployees;
		private System.Windows.Forms.TextBox textBoxSearch;
	}
}
