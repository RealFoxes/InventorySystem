using ns1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DesktopVersion
{
	public static class Utilities
	{
		public static void OnlyForDecimal(this TextBox textBox)
		{
			textBox.KeyPress += textBox_KeyPress;
		}
		private static void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
		public static void SignOnEventControlsToShowHint(this Panel panel)
		{
			foreach (Control control in panel.Controls.Cast<Control>())
			{
				if (control.Tag != null && control.Text == "")
				{
					control.Text = control.Tag.ToString();
					control.ForeColor = Color.Gray;

				}
				control.Enter += EnterInControl;
				control.Leave += LeaveFromElements;
			}
		}

		private static void EnterInControl(object sender, EventArgs e) 
		{
			Control control = (Control)sender;
			if (control.Tag != null)
			{
				if (control.Text == control.Tag.ToString())
				{
					control.Text = "";
				}
				control.ForeColor = Color.Black;
			}
		}
		private static void LeaveFromElements(object sender, EventArgs e) 
		{
			Control control = (Control)sender;
			if (control.Tag != null && control.Text == "")
			{
				control.Text = control.Tag.ToString();
				control.ForeColor = Color.Gray;

			}

		}
		public static void AddClearEntities<TEntity>(this ComboBox comboBox, DbContext context, string NameOfPropetyToShow) where TEntity : class
		{
			var entities = context.Set<TEntity>().ToArray();

			comboBox.Items.Clear();
			comboBox.Items.AddRange(entities);

			comboBox.DisplayMember = NameOfPropetyToShow;
		}
		public static bool CheckFullnessOfContols(this Panel panel)
		{
			bool isFilled = true;
			foreach (var control in panel.Controls.Cast<Control>())
			{
				if (control is Label) continue;
				if (control is Button || control is Bunifu.Framework.UI.BunifuFlatButton) continue;
				if (control is DataGridView) continue;
				if (control is BunifuDatepicker datepicker)
				{
					if (datepicker.Value == null)
					{
						isFilled = false;
						break;
					}
					continue;
				}
				if (control is Control winControl)
				{
					if (winControl.Text == String.Empty || winControl.Text == winControl.Tag.ToString()) 
					{
						isFilled = false;
						break;
					}
					continue;
				}
				
			}

			if (!isFilled)
			{
				MessageBox.Show("Один или несколько параметров не заполнены!","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			return isFilled;
		}
		public static void AddClearRange<T>(this DataGridView grid, List<T> list)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			grid.Rows.Clear();
			for (int i = 0; i < list.Count; i++)//T item in data
			{
				T item = list[i];
				grid.Rows.Add();
				grid.Rows[i].Tag = item;
				for (int q = 0; q < properties.Count; q++)
				{
					var property = properties[q];
					if (property.PropertyType.IsGenericType) continue;
					object value = properties[q].GetValue(item) ?? DBNull.Value;
					grid.Rows[i].Cells[q].Value = value.ToString();
				}
			}
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
