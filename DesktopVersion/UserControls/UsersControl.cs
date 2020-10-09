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
		private MySQLModel Model = SessionClass.init().Model;

		public UsersControl()
		{
			InitializeComponent();
			foreach (Control Element in panelAddItem.Controls.Cast<Control>().OrderBy(c => c.TabIndex)) // Первоначальная прогрузка подсказок на контролах
			{
				if (Element.Tag != null)
				{
					if (Element.Text == "")
					{
						Element.Text = Element.Tag.ToString();
						Element.ForeColor = Color.Gray;
					}
				}
			}
			Model = new MySQLModel();//Подгрузка комбобоксов
			comboBoxEmployees.DisplayMember = "surname";
			comboBoxEmployees.ValueMember = "Id";

			foreach (Employee employee in Model.Employees)
			{

				comboBoxEmployees.Items.Add(employee);
			}

			Utilities.ListToDataGridViewWithoutHat(Model.Users.ToListAsync().Result, dataGridViewMain);



		}

		private void EnterInElementsRight(object sender, EventArgs e) //При входе в элемент открузка подсказки
		{
			Control Element = (Control)sender;
			if (Element.Tag != null)
			{
				if (Element.Text == Element.Tag.ToString())
				{
					Element.Text = "";
				}
				Element.ForeColor = Color.Black;
			}
		}

		private void LeaveFromElementsRight(object sender, EventArgs e) //И наоборот
		{
			Control Element = (Control)sender;
			if (Element.Tag != null)
			{
				if (Element.Text == "")
				{
					Element.Text = Element.Tag.ToString();
					Element.ForeColor = Color.Gray;
				}
			}

		}



		private void buttonItemAdd_Click(object sender, EventArgs e)
		{
			if (Utilities.ContorslsIsNotEmptyWithHint(panelAddItem))
			{
				Employee employee = Model.Employees.Where(off => off.Id == ((Employee)comboBoxEmployees.SelectedItem).Id).First();
				String username = textBoxItemName.Text;
				String password = Utilities.GenerateHash(textBoxDetails.Text);
				User user = new User { AccessLVL = (User.E_Access)comboBoxAccessLVL.SelectedIndex, Employee = employee, Password = password, Username = username };
				Model.Users.Add(user);
				Model.SaveChanges();
				Utilities.ListToDataGridViewWithoutHat(Model.Users.ToListAsync().Result, dataGridViewMain);
			}
			else
			{
				MessageBox.Show("Один или несколько параметров не заполненые");
			}
		}

		private void buttonItemDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{

				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить предмет", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					int cell = Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value);
					Model.Items.Remove(Model.Items.Single(ToI => ToI.Id == cell));
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.Items.ToListAsync().Result, dataGridViewMain);
				}
			}
			else
			{
				MessageBox.Show("Не выбран предмет");
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<User> users = Model.Users.ToListAsync().Result;
			Utilities.ListToDataGridViewWithoutHat(users.Where(r => r.Username.StartsWith(textBoxSearch.Text)).ToList(), dataGridViewMain);

		}
	}
}

