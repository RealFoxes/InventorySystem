using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopVersion
{
	public class SearchTextBox
	{
		private DataGridView grid { get; set; }
		private ComboBox comboBox { get; set; }
		private int invisibleColumnCount { get; set; } = 0;
		
		public SearchTextBox(DataGridView dataGridView, TextBox textBoxSearch, ComboBox comboBoxSearch)
		{
			this.grid = dataGridView;
			this.comboBox = comboBoxSearch;

			foreach (DataGridViewColumn column in grid.Columns)
			{
				if (!column.Visible)
				{
					invisibleColumnCount++;
					continue;
				}
				comboBoxSearch.Items.Add(column.HeaderText);
			}

			textBoxSearch.TextChanged += textBoxSearch_TextChanged;
		}

		public void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			var textBox = (TextBox)sender;
			List<DataGridViewRow> rows = grid.Rows.Cast<DataGridViewRow>().ToList();

			foreach (DataGridViewRow row in rows)
			{
				var value = row.Cells[comboBox.SelectedIndex+invisibleColumnCount].Value;
				if (value == null)
					continue;

				row.Visible = value.ToString().ToLower().Contains(textBox.Text.ToLower());
			}
		}
	}
}
