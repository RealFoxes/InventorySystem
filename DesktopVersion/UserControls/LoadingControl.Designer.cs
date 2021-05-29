namespace DesktopVersion
{
	partial class LoadingControl
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
			System.Windows.Forms.Label label;
			label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new System.Drawing.Font("Century Gothic", 20.75F);
			label.ForeColor = System.Drawing.Color.Firebrick;
			label.Location = new System.Drawing.Point(3, 0);
			label.Name = "label";
			label.Size = new System.Drawing.Size(160, 34);
			label.TabIndex = 4;
			label.Text = "Загрузка...";
			// 
			// LoadingControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(label);
			this.Name = "LoadingControl";
			this.Size = new System.Drawing.Size(530, 292);
			this.Load += new System.EventHandler(this.LoadingControl_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
	}
}
