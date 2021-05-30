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
	public partial class OfficeControl : UserControl
	{

		private MySQLModel context = SessionClass.Instance().Context;
		public OfficeControl()
		{
			InitializeComponent();

			DragPanel dragPanel = new DragPanel(panelEdit, buttonClosePanelEdit, buttonEditShow);

			panelAddOffice.SignOnEventControlsToShowHint();

			dataGridViewMain.AddClearRange(context.Offices.ToList());
		}

		private void buttonItemAdd_Click(object sender, EventArgs e)
		{
			if (panelAddOffice.CheckFullnessOfContols())
			{
				Office office = new Office();
				office.Name = textBoxOfficeName.Text;
				office.Address = textBoxAddress.Text;
				
				context.Offices.Add(office);
				context.SaveChanges();

				dataGridViewMain.AddClearRange(context.Offices.ToList());
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<Office> offices = context.Offices.ToList();
			dataGridViewMain.AddClearRange(offices.Where(r => r.Name.StartsWith(textBoxSearch.Text)).ToList());
		}

		private void buttonOfficeDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{

				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить офис?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Office office = (Office)dataGridViewMain.SelectedRows[0].Tag;
					context.Offices.Remove(office);
					context.SaveChanges();
					dataGridViewMain.AddClearRange(context.Offices.ToList());
				}
			}
			else
				MessageBox.Show("Не выбран офис");
			
		}

		private void buttonOfficeEditShow_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count<1)
			{
				MessageBox.Show("Не выбран офис");
				return;
			}
			Office office = (Office)dataGridViewMain.SelectedRows[0].Tag;
			textBoxOfficeEditName.Text = office.Name;
			textBoxOfficeEditAddress.Text = office.Address;
			panelEdit.Tag = office;
		}

		private void buttonOfficeConfirmEdit_Click(object sender, EventArgs e)
		{
			if (panelBackgroundEdit.CheckFullnessOfContols())
			{
				Office office = (Office)panelEdit.Tag;
				office.Address = textBoxOfficeEditAddress.Text;
				office.Name = textBoxOfficeEditName.Text;
				context.SaveChanges();
				dataGridViewMain.AddClearRange(context.Offices.ToList());
				panelEdit.Visible = false;
			}
		}

		private void buttonExcel_Click(object sender, EventArgs e)
		{
			var excel = new Excel(dataGridViewMain);
			excel.StartExcel();
		}
	}
}
