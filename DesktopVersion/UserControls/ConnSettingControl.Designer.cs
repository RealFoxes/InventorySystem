namespace DesktopVersion
{
	partial class ConnSettingControl
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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			this.textBoxHost = new System.Windows.Forms.TextBox();
			this.buttonTryConn = new System.Windows.Forms.Button();
			this.buttonSaveConn = new System.Windows.Forms.Button();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxNameOfBase = new System.Windows.Forms.TextBox();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonBack = new System.Windows.Forms.Button();
			label = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label.ForeColor = System.Drawing.Color.Firebrick;
			label.Location = new System.Drawing.Point(12, 91);
			label.Name = "label";
			label.Size = new System.Drawing.Size(59, 24);
			label.TabIndex = 20;
			label.Text = "Хост";
			label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label1.ForeColor = System.Drawing.Color.Firebrick;
			label1.Location = new System.Drawing.Point(12, 159);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(60, 24);
			label1.TabIndex = 20;
			label1.Text = "Порт";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label2.ForeColor = System.Drawing.Color.Firebrick;
			label2.Location = new System.Drawing.Point(12, 227);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(110, 24);
			label2.TabIndex = 20;
			label2.Text = "Имя базы";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label3.ForeColor = System.Drawing.Color.Firebrick;
			label3.Location = new System.Drawing.Point(12, 295);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(73, 24);
			label3.TabIndex = 20;
			label3.Text = "Логин";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			label4.ForeColor = System.Drawing.Color.Firebrick;
			label4.Location = new System.Drawing.Point(12, 363);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(88, 24);
			label4.TabIndex = 20;
			label4.Text = "Пароль";
			label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxHost
			// 
			this.textBoxHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxHost.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxHost.Location = new System.Drawing.Point(16, 118);
			this.textBoxHost.MaxLength = 255;
			this.textBoxHost.Multiline = true;
			this.textBoxHost.Name = "textBoxHost";
			this.textBoxHost.Size = new System.Drawing.Size(270, 38);
			this.textBoxHost.TabIndex = 19;
			this.textBoxHost.Tag = "Хост";
			this.textBoxHost.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
			// 
			// buttonTryConn
			// 
			this.buttonTryConn.BackColor = System.Drawing.Color.Firebrick;
			this.buttonTryConn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonTryConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTryConn.Font = new System.Drawing.Font("Century Gothic", 14.75F);
			this.buttonTryConn.ForeColor = System.Drawing.Color.White;
			this.buttonTryConn.Location = new System.Drawing.Point(16, 439);
			this.buttonTryConn.Name = "buttonTryConn";
			this.buttonTryConn.Size = new System.Drawing.Size(270, 52);
			this.buttonTryConn.TabIndex = 18;
			this.buttonTryConn.Text = "Проверить подключение";
			this.buttonTryConn.UseVisualStyleBackColor = false;
			this.buttonTryConn.Click += new System.EventHandler(this.buttonTryConn_Click);
			// 
			// buttonSaveConn
			// 
			this.buttonSaveConn.BackColor = System.Drawing.Color.Firebrick;
			this.buttonSaveConn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSaveConn.Enabled = false;
			this.buttonSaveConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveConn.Font = new System.Drawing.Font("Century Gothic", 14.75F);
			this.buttonSaveConn.ForeColor = System.Drawing.Color.White;
			this.buttonSaveConn.Location = new System.Drawing.Point(16, 497);
			this.buttonSaveConn.Name = "buttonSaveConn";
			this.buttonSaveConn.Size = new System.Drawing.Size(270, 52);
			this.buttonSaveConn.TabIndex = 18;
			this.buttonSaveConn.Text = "Сохранить";
			this.buttonSaveConn.UseVisualStyleBackColor = false;
			this.buttonSaveConn.Click += new System.EventHandler(this.buttonSaveConn_Click);
			// 
			// textBoxPort
			// 
			this.textBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxPort.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxPort.Location = new System.Drawing.Point(16, 186);
			this.textBoxPort.MaxLength = 255;
			this.textBoxPort.Multiline = true;
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(270, 38);
			this.textBoxPort.TabIndex = 19;
			this.textBoxPort.Tag = "Порт";
			this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
			// 
			// textBoxNameOfBase
			// 
			this.textBoxNameOfBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxNameOfBase.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxNameOfBase.Location = new System.Drawing.Point(16, 254);
			this.textBoxNameOfBase.MaxLength = 255;
			this.textBoxNameOfBase.Multiline = true;
			this.textBoxNameOfBase.Name = "textBoxNameOfBase";
			this.textBoxNameOfBase.Size = new System.Drawing.Size(270, 38);
			this.textBoxNameOfBase.TabIndex = 19;
			this.textBoxNameOfBase.Tag = "Хост";
			this.textBoxNameOfBase.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxLogin.Location = new System.Drawing.Point(16, 322);
			this.textBoxLogin.MaxLength = 255;
			this.textBoxLogin.Multiline = true;
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(270, 38);
			this.textBoxLogin.TabIndex = 19;
			this.textBoxLogin.Tag = "Логин";
			this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.textBoxPassword.Location = new System.Drawing.Point(16, 390);
			this.textBoxPassword.MaxLength = 255;
			this.textBoxPassword.Multiline = true;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(270, 38);
			this.textBoxPassword.TabIndex = 19;
			this.textBoxPassword.Tag = "Пароль";
			this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.Firebrick;
			this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 14.75F);
			this.buttonBack.ForeColor = System.Drawing.Color.White;
			this.buttonBack.Location = new System.Drawing.Point(16, 0);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(126, 52);
			this.buttonBack.TabIndex = 18;
			this.buttonBack.Text = "Назад";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// ConnSettingControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(label4);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(label3);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(label2);
			this.Controls.Add(this.textBoxNameOfBase);
			this.Controls.Add(label1);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(label);
			this.Controls.Add(this.textBoxHost);
			this.Controls.Add(this.buttonSaveConn);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonTryConn);
			this.Name = "ConnSettingControl";
			this.Size = new System.Drawing.Size(302, 552);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxHost;
		private System.Windows.Forms.Button buttonTryConn;
		private System.Windows.Forms.Button buttonSaveConn;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxNameOfBase;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonBack;
	}
}
