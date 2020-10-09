using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesktopVersion
{
	public partial class OfficeControl : UserControl
	{

		private MySQLModel Model = SessionClass.init().Model;
		public OfficeControl()
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


			Utilities.ListToDataGridViewWithoutHat(Model.Offices.ToListAsync().Result, dataGridViewMain);
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



		private void buttonItemAdd_Click(object sender, EventArgs e)
		{
			if (Utilities.ContorslsIsNotEmptyWithHint(panelAddItem))
			{
				String name = textBoxOfficeName.Text;
				String address = textBoxAddress.Text;
				String owner = textBoxOwner.Text;
				Office office = new Office { Name = name, Adress = address, Chief = owner };
				Model.Offices.Add(office);
				Model.SaveChanges();
				Utilities.ListToDataGridViewWithoutHat(Model.Offices.ToListAsync().Result, dataGridViewMain);
			}
			else
			{
				MessageBox.Show("Один или несколько параметров не заполненые");
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<Office> offices = Model.Offices.ToListAsync().Result;
			Utilities.ListToDataGridViewWithoutHat(offices.Where(r => r.Name.StartsWith(textBoxSearch.Text)).ToList(), dataGridViewMain);
		}

		private void buttonItemDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{

				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить предмет", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					int cell = Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value);
					Model.Offices.Remove(Model.Offices.Single(ToI => ToI.Id == cell));
					Model.SaveChanges();
					Utilities.ListToDataGridViewWithoutHat(Model.Offices.ToListAsync().Result, dataGridViewMain);
				}
			}
			else
			{
				MessageBox.Show("Не выбран предмет");
			}
		}

	}
}
