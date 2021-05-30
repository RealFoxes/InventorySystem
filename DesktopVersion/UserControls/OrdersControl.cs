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
	public partial class OrdersControl : UserControl
	{
		private MySQLModel context = SessionClass.Instance().Context;
		public OrdersControl()
		{
			InitializeComponent();

			DragPanel dragPanel2 = new DragPanel(panelEdit, buttonClosePanelEdit, buttonEditShow);
			DragPanel dragPanel = new DragPanel(panelAddClient, buttonClosePanelAddClient, buttonAddNewClient);

			panelAddClient.SignOnEventControlsToShowHint();

			comboBoxEditEmployee.AddClearEntities<Employee>(context, "Surname");
			comboBoxEditServers.AddClearEntities<Server>(context, "Name");
			comboBoxServers.AddClearEntities<Server>(context, "Name");
			comboBoxClients.AddClearEntities<Client>(context, "FullName");
			comboBoxEditClients.AddClearEntities<Client>(context, "FullName");

			UpdateTable(context.Orders.ToList());
			dataGridClients.AddClearRange(context.Clients.ToList());
		}

		private void UpdateTable(List<Order> orders)
		{
			dataGridViewMain.Rows.Clear();
			foreach (var order in orders)
			{
				dataGridViewMain.Rows.Add();
				var row = dataGridViewMain.Rows[dataGridViewMain.Rows.Count - 2];
				row.Tag = order;
				row.Cells[0].Value = order.Id.ToString();
				row.Cells[1].Value = order.Employee.ToString();
				row.Cells[2].Value = order.DateTime.ToString("d");
				row.Cells[3].Value = order.Server.ToString();
				row.Cells[4].Value = order.DateOfEnd.ToString("d");
				row.Cells[5].Value = $"{order.Cost.ToString()}{order.Currency}";
				row.Cells[6].Value = order.Client.ToString();
				row.Cells[7].Value = order.Domen.ToString();
			}
		}

		private void buttonOrderAdd_Click(object sender, EventArgs e)
		{
			if (panelAddOrder.CheckFullnessOfContols())
			{
				Order order = new Order();
				order.Client = (Client)comboBoxClients.SelectedItem;
				order.Cost = Convert.ToDecimal(textBoxCost.Text);
				order.Currency = comboBoxCurrency.Text;
				order.Domen = textBoxDomen.Text;
				order.DateTime = DateTime.Now;
				order.Employee = SessionClass.Instance().User.Employee;
				order.DateOfEnd = dateTimePickerOrderEnd.Value;
				order.Server = (Server)comboBoxServers.SelectedItem;

				context.Orders.Add(order);
				context.SaveChanges();

				UpdateTable(context.Orders.ToList());
			}
		}

		private void buttonOrderDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{

				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить заказ?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Order order = (Order)dataGridViewMain.SelectedRows[0].Tag;
					context.Orders.Remove(order);
					context.SaveChanges();

					UpdateTable(context.Orders.ToList());
				}
			}
			else
			{
				MessageBox.Show("Не выбран заказ");
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<Order> orders = context.Orders.ToList();
			UpdateTable(orders.Where(o => o.Server.Name.Contains(textBoxSearch.Text)).ToList());
		}

		private void buttonAddClientAdd_Click(object sender, EventArgs e)
		{
			if (panelAddClientBackGround.CheckFullnessOfContols())
			{
				Client client = new Client();
				client.FullName = TextBoxAddClientFullName.Text;
				client.PhoneNumber = TextBoxAddClientPhoneNumber.Text;

				context.Clients.Add(client);
				context.SaveChanges();

				TextBoxAddClientFullName.Text = String.Empty;
				TextBoxAddClientPhoneNumber.Text = String.Empty;

				dataGridClients.AddClearRange(context.Clients.ToList());
				comboBoxClients.AddClearEntities<Client>(context, "FullName");
				comboBoxEditClients.AddClearEntities<Client>(context, "FullName");
			}
		}
		private void buttonAddClientDelete_Click(object sender, EventArgs e)
		{
			if (dataGridClients.SelectedRows.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить клиента?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Client client = (Client)dataGridClients.SelectedRows[0].Tag;
					context.Clients.Remove(client);
					context.SaveChanges();

					dataGridClients.AddClearRange(context.Clients.ToList());
					comboBoxClients.AddClearEntities<Client>(context, "FullName");
					comboBoxEditClients.AddClearEntities<Client>(context, "FullName");
				}
			}
			else
			{
				MessageBox.Show("Не выбран клиент для удаления");
			}
		}

		private void buttonEditShow_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count < 1)
			{
				MessageBox.Show("Не выбран заказ");
				return;
			}
			Order order = (Order)dataGridViewMain.SelectedRows[0].Tag;
			textBoxEditCost.Text = order.Cost.ToString();
			textBoxEditDomen.Text = order.Domen;
			comboBoxEditCurrency.Text = order.Currency;
			comboBoxEditEmployee.SelectedItem = order.Employee;
			comboBoxEditClients.SelectedItem = order.Client;
			comboBoxEditServers.SelectedItem = order.Server;
			dateTimePickerEditOrderTime.Value = order.DateTime;
			dateTimePickerEditOrderEnd.Value = order.DateOfEnd;
			panelEdit.Tag = order;
		}

		private void buttonOfficeConfirmEdit_Click(object sender, EventArgs e)
		{
			if (panelBackgroundEdit.CheckFullnessOfContols())
			{
				Order order = (Order)panelEdit.Tag;
				order.Currency = comboBoxEditCurrency.Text;
				order.Domen = textBoxEditDomen.Text;
				order.Cost = Convert.ToDecimal(textBoxEditCost.Text);
				order.Employee = (Employee)comboBoxEditEmployee.SelectedItem;
				order.Client = (Client)comboBoxEditClients.SelectedItem;
				order.Server = (Server)comboBoxEditServers.SelectedItem;
				order.DateTime = dateTimePickerEditOrderTime.Value;
				order.DateOfEnd = dateTimePickerEditOrderEnd.Value;
				context.SaveChanges();
				UpdateTable(context.Orders.ToList());
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
