using DesktopVersion.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class UsersControl : UserControl
	{
		private MySQLModel context = SessionClass.Instance().Context;

		public UsersControl()
		{
			InitializeComponent();

			DragPanel dragPanel = new DragPanel(panelEdit, buttonClosePanelEdit, buttonEditShow);

			panelAddUser.SignOnEventControlsToShowHint();

			comboBoxEmployees.AddClearEntities<Employee>(context, "Surname");
			comboBoxEditEmployees.AddClearEntities<Employee>(context, "Surname");

			dataGridViewMain.AddClearRange(context.Users.ToList());
		}

		private void buttonUserAdd_Click(object sender, EventArgs e)
		{
			if (panelAddUser.CheckFullnessOfContols())
			{
				User user = new User();
				user.Username = textBoxUserLogin.Text;
				user.Password = Utilities.GenerateHash(textBoxPassword.Text);
				user.AccessLVL = (User.E_Access)comboBoxAccessLVL.SelectedIndex;
				user.Employee = (Employee)comboBoxEmployees.SelectedItem;
				context.Users.Add(user);
				context.SaveChanges();
				dataGridViewMain.AddClearRange(context.Users.ToList());
			}
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить пользователя?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					User user = (User)dataGridViewMain.SelectedRows[0].Tag;

					context.Users.Remove(user);
					context.SaveChanges();

					dataGridViewMain.AddClearRange(context.Users.ToList());
				}
			}
			else
				MessageBox.Show("Не выбран пользователь");
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<User> users = context.Users.ToList();
			dataGridViewMain.AddClearRange(users.Where(r => r.Username.StartsWith(textBoxSearch.Text)).ToList());

		}

		private void buttonOfficeEditShow_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count < 1)
			{
				MessageBox.Show("Не выбран пользователь");
				return;
			}
			User user = (User)dataGridViewMain.SelectedRows[0].Tag;
			textBoxEditUserLogin.Text = user.Username;
			comboBoxEditAccessLVL.SelectedIndex = (int)user.AccessLVL;
			comboBoxEditEmployees.SelectedItem = user.Employee;
			panelEdit.Tag = user;
		}

		private void buttonOfficeConfirmEdit_Click(object sender, EventArgs e)
		{
			if (panelBackgroundEdit.CheckFullnessOfContols())
			{
				User user = (User)panelEdit.Tag;
				user.Username = textBoxEditUserLogin.Text;
				user.AccessLVL = (User.E_Access)comboBoxEditAccessLVL.SelectedIndex;
				user.Employee = (Employee)comboBoxEditEmployees.SelectedItem;
				user.Password = Utilities.GenerateHash(textBoxEditPassword.Text);
				context.SaveChanges();
				dataGridViewMain.AddClearRange(context.Users.ToList());
				panelEdit.Visible = false;
			}
		}
	}
}

