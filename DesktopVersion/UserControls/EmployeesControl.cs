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

			DragPanel dragPanel = new DragPanel(panelAddJobPosition, buttonClosePanelAddJobPosition, buttonAddNewJobPosition);

			panelAddEmployee.SignOnEventControlsToShowHint();

			comboBoxOffices.AddClearEntities<Office>(context, "Name");
			comboBoxJobPosition.AddClearEntities<JobPosition>(context, "Name");

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

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<Employee> employee = context.Employees.ToList();
			dataGridViewMain.AddClearRange(employee.Where(r => r.Surname.StartsWith(textBoxSearch.Text)).ToList());
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
			}
		}
	}
}
