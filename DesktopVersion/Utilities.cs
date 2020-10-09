using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DesktopVersion
{
	class Utilities
	{
		public static DataTable ToDataTable<T>(IList<T> data)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			foreach (PropertyDescriptor prop in properties)
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			foreach (T item in data)
			{
				DataRow row = table.NewRow();
				foreach (PropertyDescriptor prop in properties)
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				table.Rows.Add(row);
			}
			return table;
		}
		public static void ListToDataGridViewWithoutHat<T>(IList<T> data, DataGridView table)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			table.Rows.Clear();
			for (int i = 0; i < data.Count; i++)//T item in data
			{
				T item = data[i];
				table.Rows.Add();
				for (int q = 0; q < properties.Count; q++)
				{
					var prop = properties[q];
					table.Rows[i].Cells[q].Value = prop.GetValue(item) ?? DBNull.Value;
				}
			}

		}

		public static void ListToDataGridViewWithoutHat(List<Item> data, DataGridView table)
		{
			table.Rows.Clear();
			for (int i = 0; i < data.Count; i++)
			{
				Item item = data[i];
				table.Rows.Add();

				table.Rows[i].Cells[0].Value = item.Id;
				table.Rows[i].Cells[1].Value = item.TypeItem.Name;
				table.Rows[i].Cells[2].Value = item.Name;
				table.Rows[i].Cells[3].Value = item.Details;
				table.Rows[i].Cells[4].Value = item.Office.Name;

			}

		}

		public static void ListToDataGridViewWithoutHat(IList<Employee> data, DataGridView table)
		{
			table.Rows.Clear();
			for (int i = 0; i < data.Count; i++)
			{
				Employee item = data[i];
				table.Rows.Add();

				table.Rows[i].Cells[0].Value = item.Id;
				table.Rows[i].Cells[1].Value = item.JobPosition.Name;
				table.Rows[i].Cells[2].Value = item.Name;
				table.Rows[i].Cells[3].Value = item.Surname;
				table.Rows[i].Cells[4].Value = item.Patronymic;
				table.Rows[i].Cells[5].Value = item.Birthdate.ToString("dd/MM/yyyy");
				table.Rows[i].Cells[6].Value = item.Office.Name;
			}

		}

		public static void ListToDataGridViewWithoutHat(IList<User> data, DataGridView table)
		{
			table.Rows.Clear();
			for (int i = 0; i < data.Count; i++)
			{
				User item = data[i];
				table.Rows.Add();

				table.Rows[i].Cells[0].Value = item.Id;
				table.Rows[i].Cells[1].Value = item.Username;
				table.Rows[i].Cells[2].Value = item.Password;
				table.Rows[i].Cells[3].Value = User.S_Access[(int)item.AccessLVL];
				table.Rows[i].Cells[4].Value = $"{item.Employee.Surname} {item.Employee.Name[0]}.{item.Employee.Patronymic[0]}.";

			}

		}

		public static void ListToDataGridViewWithoutHat(IList<Office> data, DataGridView table)
		{
			table.Rows.Clear();
			for (int i = 0; i < data.Count; i++)
			{
				Office item = data[i];
				table.Rows.Add();

				table.Rows[i].Cells[0].Value = item.Id;
				table.Rows[i].Cells[1].Value = item.Name;
				table.Rows[i].Cells[2].Value = item.Adress;
				table.Rows[i].Cells[3].Value = item.Chief;

			}

		}

		public static bool ContorslsIsNotEmptyWithHint(Panel panel)
		{
			foreach (Control Element in panel.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
			{
				switch (Element)
				{
					case ComboBox comboBox:
						if (comboBox.SelectedItem == null || comboBox.SelectedItem.ToString() == comboBox.Tag.ToString()) return false;
						break;
					case TextBox textBox:
						if (textBox.Text == textBox.Tag.ToString()) return false;
						break;
				}
			}
			return true;
		}

		public static string GenerateHash(string value)
		{
			MD5 hash = MD5.Create();
			byte[] arr = hash.ComputeHash(Encoding.UTF8.GetBytes(value + "1c466e063d7e3ad12bb6588cc83c0b3b"));
			StringBuilder strBuilder = new StringBuilder();
			foreach (byte b in arr)
			{
				strBuilder.Append(b.ToString("x2"));
			}
			return strBuilder.ToString();
		}
	}
}
