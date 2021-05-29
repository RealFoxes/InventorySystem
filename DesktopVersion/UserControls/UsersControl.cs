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

			panelAddUser.SignOnEventControlsToShowHint();

			comboBoxEmployees.AddClearEntities<Employee>(context, "Surname");

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
	}
}

