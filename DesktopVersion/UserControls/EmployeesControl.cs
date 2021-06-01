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
	public partial class EmployeesControl : UserControl
	{
		private MySQLModel context = SessionClass.Instance().Context;
		public EmployeesControl()
		{
			InitializeComponent();

			DragPanel dragPanel2 = new DragPanel(panelEdit, buttonClosePanelEdit, buttonEditShow);
			DragPanel dragPanel = new DragPanel(panelAddJobPosition, buttonClosePanelAddJobPosition, buttonAddNewJobPosition);
			
			SearchTextBox search = new SearchTextBox(dataGridViewMain, textBoxSearch, comboBoxSearch);
			
			panelAddEmployee.SignOnEventControlsToShowHint();

			comboBoxOffices.AddClearEntities<Office>(context, "Name");
			comboBoxEditOffices.AddClearEntities<Office>(context, "Name");
			comboBoxJobPosition.AddClearEntities<JobPosition>(context, "Name");
			comboBoxEditJobPosition.AddClearEntities<JobPosition>(context, "Name");

			dataGridViewMain.AddClearRange(context.Employees.ToList());
			dataGridJobPosition.AddClearRange(context.JobPositions.ToList());
		}
		private void buttonAddJobPositionDelete_Click(object sender, EventArgs e)
		{
			if (dataGridJobPosition.SelectedRows.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить должность?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					JobPosition jobPosition = (JobPosition)dataGridJobPosition.SelectedRows[0].Tag;
					context.JobPositions.Remove(jobPosition);
					context.SaveChanges();

					dataGridJobPosition.AddClearRange(context.JobPositions.ToList());
					comboBoxJobPosition.AddClearEntities<JobPosition>(context, "Name");
					comboBoxEditJobPosition.AddClearEntities<JobPosition>(context, "Name");

				}
			}
			else 
				MessageBox.Show("Не выбрана должность");
		}

		private void buttonItemAdd_Click(object sender, EventArgs e)
		{
			if (panelAddEmployee.CheckFullnessOfContols())
			{
				Employee employee = new Employee();
				employee.JobPosition = (JobPosition)comboBoxJobPosition.SelectedItem;
				employee.Office = (Office)comboBoxOffices.SelectedItem;
				employee.Birthdate = datepickerBirthday.Value;
				employee.Name = textBoxEmployeeName.Text;
				employee.Patronymic = textBoxEmployeeSurname.Text;
				employee.Surname = textBoxEmployeePatronymic.Text;

				context.Employees.Add(employee);
				context.SaveChanges();
				dataGridViewMain.AddClearRange(context.Employees.ToList());

			}
		}

		private void buttonEmployeeDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить сотрудника?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Employee employee = (Employee)dataGridViewMain.SelectedRows[0].Tag;

					context.Employees.Remove(employee);
					context.SaveChanges();
					dataGridViewMain.AddClearRange(context.Employees.ToList());
				}
			}
			else
				MessageBox.Show("Не выбран сотрудник");
		}

		private void buttonAddJobPositionAdd_Click(object sender, EventArgs e)
		{
			if (panelAddJobPosition.CheckFullnessOfContols())
			{
				JobPosition jobPosition = new JobPosition();
				jobPosition.Name = textBoxAddJobPosition.Text;

				context.JobPositions.Add(jobPosition);
				context.SaveChanges();

				textBoxAddJobPosition.Text = string.Empty;

				dataGridJobPosition.AddClearRange(context.JobPositions.ToList());
				comboBoxJobPosition.AddClearEntities<JobPosition>(context, "Name");
				comboBoxEditJobPosition.AddClearEntities<JobPosition>(context, "Name");
			}
		}

		private void buttonEditShow_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count < 1)
			{
				MessageBox.Show("Не выбран сотрудник");
				return;
			}
			Employee employee = (Employee)dataGridViewMain.SelectedRows[0].Tag;
			comboBoxEditJobPosition.SelectedItem = employee.JobPosition;
			comboBoxEditOffices.SelectedItem = employee.Office;
			textBoxEditEmployeeName.Text = employee.Name;
			textBoxEditEmployeePatronymic.Text = employee.Patronymic;
			textBoxEditEmployeeSurname.Text = employee.Surname;
			datepickerEditBirthday.Value = employee.Birthdate;
			panelEdit.Tag = employee;
		}

		private void buttonOfficeConfirmEdit_Click(object sender, EventArgs e)
		{
			if (panelBackgroundEdit.CheckFullnessOfContols())
			{
				Employee employee = (Employee)panelEdit.Tag;
				employee.JobPosition = (JobPosition)comboBoxEditJobPosition.SelectedItem;
				employee.Office = (Office)comboBoxEditOffices.SelectedItem;
				employee.Name = textBoxEditEmployeeName.Text;
				employee.Patronymic = textBoxEditEmployeePatronymic.Text;
				employee.Surname = textBoxEditEmployeeSurname.Text;
				employee.Birthdate = datepickerEditBirthday.Value;
				context.SaveChanges();
				dataGridViewMain.AddClearRange(context.Employees.ToList());
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
