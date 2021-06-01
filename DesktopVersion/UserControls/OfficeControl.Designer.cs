namespace DesktopVersion
{
	partial class OfficeControl
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
			this.panelBackgroundEdit = new System.Windows.Forms.Panel();
			this.textBoxOfficeEditName = new System.Windows.Forms.TextBox();
			this.buttonOfficeConfirmEdit = new System.Windows.Forms.Button();
			this.textBoxOfficeEditAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddOffice = new System.Windows.Forms.Panel();
			this.textBoxOfficeName = new System.Windows.Forms.TextBox();
			this.buttonOfficeDelete = new System.Windows.Forms.Button();
			this.buttonExcel = new System.Windows.Forms.Button();
			this.buttonOfficeAdd = new System.Windows.Forms.Button();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.buttonEditShow = new Bunifu.Framework.UI.BunifuFlatButton();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.panelEdit = new System.Windows.Forms.Panel();
			this.buttonClosePanelEdit = new System.Windows.Forms.Button();
			labelSearch = new System.Windows.Forms.Label();
			this.panelBackgroundEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddOffice.SuspendLayout();
			this.panelEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelSearch
			// 
			labelSearch.AutoSize = true;
			labelSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			labelSearch.ForeColor = System.Drawing.Color.Firebrick;
			labelSearch.Location = new System.Drawing.Point(12, 25);
			labelSearch.Name = "labelSearch";
			labelSearch.Size = new System.Drawing.Size(76, 24);
			labelSearch.TabIndex = 19;
			labelSearch.Text = "Поиск";
			labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelBackgroundEdit
			// 
			this.panelBackgroundEdit.BackColor = System.Drawing.Color.White;
			this.panelBackgroundEdit.Controls.Add(this.textBoxOfficeEditName);
			this.panelBackgroundEdit.Controls.Add(this.buttonOfficeConfirmEdit);
			this.panelBackgroundEdit.Controls.Add(this.textBoxOfficeEditAddress);
			this.panelBackgroundEdit.Controls.Add(this.label1);
			this.panelBackgroundEdit.Location = new System.Drawing.Point(3, 39);
			this.panelBackgroundEdit.Name = "panelBackgroundEdit";
			this.panelBackgroundEdit.Size = new System.Drawing.Size(318, 370);
			this.panelBackgroundEdit.TabIndex = 0;
			// 
			// textBoxOfficeEditName
			// 
			this.textBoxOfficeEditName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxOfficeEditName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxOfficeEditName.Location = new System.Drawing.Point(23, 27);
			this.textBoxOfficeEditName.MaxLength = 255;
			this.textBoxOfficeEditName.Multiline = true;
			this.textBoxOfficeEditName.Name = "textBoxOfficeEditName";
			this.textBoxOfficeEditName.Size = new System.Drawing.Size(271, 29);
			this.textBoxOfficeEditName.TabIndex = 16;
			this.textBoxOfficeEditName.Tag = "Наименование";
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
			// textBoxOfficeEditAddress
			// 
			this.textBoxOfficeEditAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxOfficeEditAddress.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxOfficeEditAddress.Location = new System.Drawing.Point(23, 62);
			this.textBoxOfficeEditAddress.MaxLength = 255;
			this.textBoxOfficeEditAddress.Multiline = true;
			this.textBoxOfficeEditAddress.Name = "textBoxOfficeEditAddress";
			this.textBoxOfficeEditAddress.Size = new System.Drawing.Size(271, 75);
			this.textBoxOfficeEditAddress.TabIndex = 13;
			this.textBoxOfficeEditAddress.Tag = "Адрес";
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
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.label.ForeColor = System.Drawing.Color.Firebrick;
			this.label.Location = new System.Drawing.Point(50, 11);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(179, 48);
			this.label.TabIndex = 5;
			this.label.Text = "Добавить новый\r\nофис";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// Column1
			// 
			this.Column1.HeaderText = "Идентификатор";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Наименование";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Адрес";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// panelAddOffice
			// 
			this.panelAddOffice.Controls.Add(this.textBoxOfficeName);
			this.panelAddOffice.Controls.Add(this.buttonOfficeDelete);
			this.panelAddOffice.Controls.Add(this.buttonExcel);
			this.panelAddOffice.Controls.Add(this.buttonOfficeAdd);
			this.panelAddOffice.Controls.Add(this.textBoxAddress);
			this.panelAddOffice.Controls.Add(this.label);
			this.panelAddOffice.Location = new System.Drawing.Point(1015, 10);
			this.panelAddOffice.Name = "panelAddOffice";
			this.panelAddOffice.Size = new System.Drawing.Size(280, 800);
			this.panelAddOffice.TabIndex = 1;
			// 
			// textBoxOfficeName
			// 
			this.textBoxOfficeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxOfficeName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxOfficeName.Location = new System.Drawing.Point(3, 73);
			this.textBoxOfficeName.MaxLength = 255;
			this.textBoxOfficeName.Multiline = true;
			this.textBoxOfficeName.Name = "textBoxOfficeName";
			this.textBoxOfficeName.Size = new System.Drawing.Size(271, 29);
			this.textBoxOfficeName.TabIndex = 16;
			this.textBoxOfficeName.Tag = "Наименование";
			// 
			// buttonOfficeDelete
			// 
			this.buttonOfficeDelete.BackColor = System.Drawing.Color.Firebrick;
			this.buttonOfficeDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonOfficeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOfficeDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonOfficeDelete.ForeColor = System.Drawing.Color.White;
			this.buttonOfficeDelete.Location = new System.Drawing.Point(4, 745);
			this.buttonOfficeDelete.Name = "buttonOfficeDelete";
			this.buttonOfficeDelete.Size = new System.Drawing.Size(270, 52);
			this.buttonOfficeDelete.TabIndex = 15;
			this.buttonOfficeDelete.Text = "Удалить";
			this.buttonOfficeDelete.UseVisualStyleBackColor = false;
			this.buttonOfficeDelete.Click += new System.EventHandler(this.buttonOfficeDelete_Click);
			// 
			// buttonExcel
			// 
			this.buttonExcel.BackColor = System.Drawing.Color.Firebrick;
			this.buttonExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExcel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonExcel.ForeColor = System.Drawing.Color.White;
			this.buttonExcel.Location = new System.Drawing.Point(3, 629);
			this.buttonExcel.Name = "buttonExcel";
			this.buttonExcel.Size = new System.Drawing.Size(270, 52);
			this.buttonExcel.TabIndex = 15;
			this.buttonExcel.Text = "Вывод в Excel";
			this.buttonExcel.UseVisualStyleBackColor = false;
			this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
			// 
			// buttonOfficeAdd
			// 
			this.buttonOfficeAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonOfficeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonOfficeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOfficeAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonOfficeAdd.ForeColor = System.Drawing.Color.White;
			this.buttonOfficeAdd.Location = new System.Drawing.Point(4, 687);
			this.buttonOfficeAdd.Name = "buttonOfficeAdd";
			this.buttonOfficeAdd.Size = new System.Drawing.Size(270, 52);
			this.buttonOfficeAdd.TabIndex = 15;
			this.buttonOfficeAdd.Text = "Добавить";
			this.buttonOfficeAdd.UseVisualStyleBackColor = false;
			this.buttonOfficeAdd.Click += new System.EventHandler(this.buttonItemAdd_Click);
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxAddress.Location = new System.Drawing.Point(3, 108);
			this.textBoxAddress.MaxLength = 255;
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(271, 75);
			this.textBoxAddress.TabIndex = 13;
			this.textBoxAddress.Tag = "Адрес";
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
			this.buttonEditShow.TabIndex = 17;
			this.buttonEditShow.Text = "Изменить";
			this.buttonEditShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonEditShow.Textcolor = System.Drawing.Color.White;
			this.buttonEditShow.TextFont = new System.Drawing.Font("Century Gothic", 12.75F);
			this.buttonEditShow.Click += new System.EventHandler(this.buttonOfficeEditShow_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxSearch.Location = new System.Drawing.Point(94, 25);
			this.textBoxSearch.MaxLength = 255;
			this.textBoxSearch.Multiline = true;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(363, 29);
			this.textBoxSearch.TabIndex = 18;
			this.textBoxSearch.Tag = "";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// panelEdit
			// 
			this.panelEdit.BackColor = System.Drawing.Color.Firebrick;
			this.panelEdit.Controls.Add(this.buttonClosePanelEdit);
			this.panelEdit.Controls.Add(this.panelBackgroundEdit);
			this.panelEdit.Location = new System.Drawing.Point(685, 102);
			this.panelEdit.Name = "panelEdit";
			this.panelEdit.Size = new System.Drawing.Size(324, 412);
			this.panelEdit.TabIndex = 20;
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
			// OfficeControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.buttonEditShow);
			this.Controls.Add(this.panelEdit);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddOffice);
			this.Controls.Add(this.dataGridViewMain);
			this.Name = "OfficeControl";
			this.Size = new System.Drawing.Size(1300, 820);
			this.panelBackgroundEdit.ResumeLayout(false);
			this.panelBackgroundEdit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddOffice.ResumeLayout(false);
			this.panelAddOffice.PerformLayout();
			this.panelEdit.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewMain;
		private System.Windows.Forms.Panel panelAddOffice;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Button buttonOfficeAdd;
		private System.Windows.Forms.Button buttonOfficeDelete;
		private System.Windows.Forms.TextBox textBoxOfficeName;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.Panel panelEdit;
		private System.Windows.Forms.Button buttonOfficeConfirmEdit;
		private System.Windows.Forms.TextBox textBoxOfficeEditName;
		private System.Windows.Forms.TextBox textBoxOfficeEditAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonClosePanelEdit;
		private Bunifu.Framework.UI.BunifuFlatButton buttonEditShow;
		private System.Windows.Forms.Panel panelBackgroundEdit;
		private System.Windows.Forms.Button buttonExcel;
	}
}
