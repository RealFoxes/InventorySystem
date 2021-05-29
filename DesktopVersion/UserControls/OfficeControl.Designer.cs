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
			this.label = new System.Windows.Forms.Label();
			this.dataGridViewMain = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelAddOffice = new System.Windows.Forms.Panel();
			this.textBoxOfficeName = new System.Windows.Forms.TextBox();
			this.buttonOfficeDelete = new System.Windows.Forms.Button();
			this.buttonOfficeAdd = new System.Windows.Forms.Button();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			labelSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.panelAddOffice.SuspendLayout();
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
			// buttonOfficeAdd
			// 
			this.buttonOfficeAdd.BackColor = System.Drawing.Color.Firebrick;
			this.buttonOfficeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonOfficeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOfficeAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.buttonOfficeAdd.ForeColor = System.Drawing.Color.White;
			this.buttonOfficeAdd.Location = new System.Drawing.Point(4, 691);
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
			// OfficeControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(labelSearch);
			this.Controls.Add(this.panelAddOffice);
			this.Controls.Add(this.dataGridViewMain);
			this.Name = "OfficeControl";
			this.Size = new System.Drawing.Size(1300, 820);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.panelAddOffice.ResumeLayout(false);
			this.panelAddOffice.PerformLayout();
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
	}
}
