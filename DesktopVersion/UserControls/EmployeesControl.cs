using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class EmployeesControl : UserControl
	{
		private bool dragging = false;
		private Point dragCursorPoint, dragFormPoint;
		private MySQLModel Model = SessionClass.init().Model;
		public EmployeesControl()
		{
			InitializeComponent();
			foreach (Control Element in panelAddEmployee.Controls.Cast<Control>().OrderBy(c => c.TabIndex)) // Первоначальная прогрузка подсказок на контролах
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
			foreach (Office office in Model.Offices)
			{
				comboBoxOffices.Items.Add(office.Name.ToString());
			}
			foreach (JobPosition TypeOfIt in Model.JobPositions)//cboxHour.Items.Clear() Подругзка после добавления и удаления
			{
				comboBoxJobPosition.Items.Add(TypeOfIt.Name.ToString());
			}

			Utilities.ListToDataGridViewWithoutHat(Model.Employees.ToListAsync().Result, dataGridViewMain);
			Utilities.ListToDataGridViewWithoutHat(Model.JobPositions.ToListAsync().Result, dataGridJobPosition);
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
		private void buttonAddNewJobPosition_Click(object sender, EventArgs e)//Открытие панельки по добавлению типа предмета
		{
			if (!panelAddJobPosition.Visible)
			{
				panelAddJobPosition.Visible = true;
				dataGridJobPosition.ClearSelection();
				Point p = GetPositionInForm(buttonAddNewJobPosition);
				panelAddJobPosition.Location = new Point(p.X - panelAddJobPosition.Width, p.Y);
			}
		}

		public Point GetPositionInForm(Control ctrl) // Получение координаты в форме а не в панельке
		{
			Point p = ctrl.Location;
			Control parent = ctrl.Parent;
			while (!(parent is Form))
			{
				p.Offset(parent.Location.X, parent.Location.Y);
				parent = parent.Parent;
			}
			return p;
		}

		private void buttonClosePanelAddJobPosition_Click(object sender, EventArgs e)//Закрытие кнопки МБ тут сохранение данных
		{
			panelAddJobPosition.Visible = false;

		}

		#region DragPanelAddJobPosition
		private void panelAddTypеOfItem_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void panelAddTypеOfItem_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{

				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				panelAddJobPosition.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void panelAddTypеOfItem_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = panelAddJobPosition.Location;
		}
		#endregion

		private void buttonAddJobPositionDelete_Click(object sender, EventArgs e)
		{
			if (dataGridJobPosition.SelectedRows.Count > 0)
			{


				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить тип предмета", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					int cell = Convert.ToInt32(dataGridJobPosition.SelectedRows[0].Cells[0].Value);
					Model.JobPositions.Remove(Model.JobPositions.Single(ToI => ToI.Id == cell));
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.JobPositions.ToListAsync().Result, dataGridJobPosition);
					comboBoxJobPosition.Items.Clear();
					foreach (JobPosition TypeOfIt in Model.JobPositions)//cboxHour.Items.Clear() Подругзка после добавления и удаления
					{
						comboBoxJobPosition.Items.Add(TypeOfIt.Name.ToString());
					}
				}
			}
			else
			{
				MessageBox.Show("Не выбран тип предмета");
			}
		}

		private void buttonItemAdd_Click(object sender, EventArgs e)
		{
			if (comboBoxJobPosition.SelectedItem != null && comboBoxOffices.SelectedItem != null)
			{
				bool Contains = true;
				foreach (Control Element in panelAddEmployee.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
				{
					if (Element.Tag != null)
					{
						if (Element.Text == Element.Tag.ToString())
						{
							Contains = false;
						}
					}

				}
				if (!Contains)
				{
					MessageBox.Show("Один или несколько параметров не заполнены");
				}
				else
				{
					JobPosition JobPosition = Model.JobPositions.Where(ToI => ToI.Name == comboBoxJobPosition.SelectedItem.ToString()).First();
					Office _office = Model.Offices.Where(off => off.Name == comboBoxOffices.SelectedItem.ToString()).First();
					String _name = textBoxItemName.Text;
					String _surname = textBoxItemSurname.Text;
					String _patronymic = textBoxItemPatronymic.Text;
					DateTime _birthdate = datepickerBirthday.Value;
					Employee employee = new Employee { JobPosition = JobPosition, Office = _office, Birthdate = _birthdate, Name = _name, Patronymic = _patronymic, Surname = _surname };
					Model.Employees.Add(employee);
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.Employees.ToListAsync().Result, dataGridViewMain);
				}
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
					Model.Employees.Remove(Model.Employees.Single(ToI => ToI.Id == cell));
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.Employees.ToListAsync().Result, dataGridViewMain);
				}
			}
			else
			{
				MessageBox.Show("Не выбран предмет");
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<Employee> employee = Model.Employees.ToListAsync().Result;
			Utilities.ListToDataGridViewWithoutHat(employee.Where(r => r.Surname.StartsWith(textBoxSearch.Text)).ToList(), dataGridViewMain);
		}

		private void buttonAddJobPositionAdd_Click(object sender, EventArgs e)
		{
			if (TextBoxAddJobPosition.Text != string.Empty)
			{
				JobPosition JobPosition = new JobPosition { Name = TextBoxAddJobPosition.Text };
				Model.JobPositions.Add(JobPosition);
				Console.WriteLine("Добавил новое значение: " + TextBoxAddJobPosition.Text);
				Model.SaveChanges();
				TextBoxAddJobPosition.Text = string.Empty;
				Utilities.ListToDataGridViewWithoutHat(Model.JobPositions.ToListAsync().Result, dataGridJobPosition);
				comboBoxJobPosition.Items.Clear();
				foreach (JobPosition TypeOfIt in Model.JobPositions)
				{
					comboBoxJobPosition.Items.Add(TypeOfIt.Name.ToString());
				}
			}
			else
			{
				MessageBox.Show("Строка не можзет содержать пустого значения!");
			}
		}



	}
}
