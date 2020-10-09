using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class ItemsControl : UserControl
	{
		private bool dragging = false;
		private Point dragCursorPoint, dragFormPoint;
		private MySQLModel Model = SessionClass.init().Model;
		public ItemsControl()
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
			foreach (Office office in Model.Offices)
			{
				comboBoxOffices.Items.Add(office.Name.ToString());
			}
			foreach (TypeOfItem TypeOfIt in Model.TypeOfItems)//Подругзка после добавления и удаления
			{
				comboBoxTypeOfItem.Items.Add(TypeOfIt.Name.ToString());
			}

			Utilities.ListToDataGridViewWithoutHat(Model.Items.ToListAsync().Result, dataGridViewMain);
			Utilities.ListToDataGridViewWithoutHat(Model.TypeOfItems.ToListAsync().Result, dataGridTypeOfItem);



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

		private void buttonAddNewTypeOfItem_Click(object sender, EventArgs e)//Открытие панельки по добавлению типа предмета
		{
			if (!panelAddTypеOfItem.Visible)
			{
				panelAddTypеOfItem.Visible = true;
				dataGridTypeOfItem.ClearSelection();
				Point p = GetPositionInForm(buttonAddNewTypeOfItem);
				panelAddTypеOfItem.Location = new Point(p.X - panelAddTypеOfItem.Width, p.Y);
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

		private void buttonClosePanelAddTypeOfItem_Click(object sender, EventArgs e)//Закрытие кнопки МБ тут сохранение данных
		{
			panelAddTypеOfItem.Visible = false;

		}

		#region DragPanelAddTypeOfItem
		private void panelAddTypеOfItem_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}

		private void panelAddTypеOfItem_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{

				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				panelAddTypеOfItem.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void panelAddTypеOfItem_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = panelAddTypеOfItem.Location;
		}
		#endregion


		private void buttonAddTypeOfItemDelete_Click(object sender, EventArgs e)
		{
			if (dataGridTypeOfItem.SelectedRows.Count > 0)
			{


				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить тип предмета", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					int cell = Convert.ToInt32(dataGridTypeOfItem.SelectedRows[0].Cells[0].Value);
					Model.TypeOfItems.Remove(Model.TypeOfItems.Single(ToI => ToI.Id == cell));
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.TypeOfItems.ToListAsync().Result, dataGridTypeOfItem);
					comboBoxTypeOfItem.Items.Clear();
					foreach (TypeOfItem TypeOfIt in Model.TypeOfItems)//Подругзка после добавления и удаления
					{
						comboBoxTypeOfItem.Items.Add(TypeOfIt.Name.ToString());
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
			if (comboBoxTypeOfItem.SelectedItem != null && comboBoxOffices.SelectedItem != null)
			{
				if (comboBoxTypeOfItem.SelectedItem.ToString() == comboBoxTypeOfItem.Tag.ToString() || comboBoxOffices.SelectedItem.ToString() == comboBoxOffices.Tag.ToString() || textBoxDetails.Text == textBoxDetails.Tag.ToString() || textBoxItemName.Text == textBoxItemName.Tag.ToString())
				{
					MessageBox.Show("Один или несколько параметров не заполненые");
				}
				else
				{
					TypeOfItem typeOfItem = Model.TypeOfItems.Where(ToI => ToI.Name == comboBoxTypeOfItem.SelectedItem.ToString()).First();
					Office office = Model.Offices.Where(off => off.Name == comboBoxOffices.SelectedItem.ToString()).First();
					String name = textBoxItemName.Text;
					String details = textBoxDetails.Text;
					Item item = new Item { TypeItem = typeOfItem, Office = office, Details = details, Name = name };
					Model.Items.Add(item);
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.Items.ToListAsync().Result, dataGridViewMain);
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
			List<Item> items = Model.Items.ToListAsync().Result;
			Utilities.ListToDataGridViewWithoutHat(items.Where(r => r.Name.StartsWith(textBoxSearch.Text)).ToList(), dataGridViewMain);
		}

		private void buttonAddTypeOfItemAdd_Click(object sender, EventArgs e)
		{
			if (TextBoxAddTypeOfItem.Text != string.Empty)
			{
				TypeOfItem typeOfItem = new TypeOfItem { Name = TextBoxAddTypeOfItem.Text };
				Model.TypeOfItems.Add(typeOfItem);
				Console.WriteLine("Добавил новое значение: " + TextBoxAddTypeOfItem.Text);
				Model.SaveChanges();
				TextBoxAddTypeOfItem.Text = string.Empty;
				Utilities.ListToDataGridViewWithoutHat(Model.TypeOfItems.ToListAsync().Result, dataGridTypeOfItem);
				comboBoxTypeOfItem.Items.Clear();
				foreach (TypeOfItem TypeOfIt in Model.TypeOfItems)
				{
					comboBoxTypeOfItem.Items.Add(TypeOfIt.Name.ToString());
				}
			}
			else
			{
				MessageBox.Show("Строка не можзет содержать пустого значения!");
			}
		}



	}
}
