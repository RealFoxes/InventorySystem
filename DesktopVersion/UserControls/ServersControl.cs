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
	public partial class ServersControl : UserControl
	{
		private MySQLModel context = SessionClass.Instance().Context;
		public ServersControl()
		{
			InitializeComponent();

			DragPanel dragPanel = new DragPanel(panelAddTypеOfServer, buttonClosePanelAddTypeOfServer, buttonAddNewTypeOfServer);

			panelAddServer.SignOnEventControlsToShowHint();
			comboBoxOffices.AddClearEntities<Office>(context, "Name");
			comboBoxTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
			
			dataGridViewMain.AddClearRange(context.Servers.ToList());
			dataGridTypeOfServer.AddClearRange(context.TypeOfServers.ToList());
		}
		
		private void buttonServerAdd_Click(object sender, EventArgs e)
		{
			if (panelAddServer.CheckFullnessOfContols())
			{
				Server server = new Server();
				server.Name = textBoxServerName.Text;
				server.Office = (Office)comboBoxOffices.SelectedItem;
				server.TypeOfServer = (TypeOfServer)comboBoxTypeOfServer.SelectedItem;
				server.Details = textBoxDetails.Text;

				context.Servers.Add(server);
				context.SaveChanges();

				dataGridViewMain.AddClearRange(context.Servers.ToList());
			}
		}

		private void buttonServerDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count > 0)
			{

				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить сервер?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Server server = (Server)dataGridViewMain.SelectedRows[0].Tag;
					context.Servers.Remove(server);
					context.SaveChanges();

					dataGridViewMain.AddClearRange(context.Servers.ToList());
				}
			}
			else
				MessageBox.Show("Не выбран сервер");
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			List<Server> servers = context.Servers.ToList();
			dataGridViewMain.AddClearRange(servers.Where(r => r.Name.StartsWith(textBoxSearch.Text)).ToList());
		}

		private void buttonAddTypeOfServerAdd_Click(object sender, EventArgs e)
		{
			if (panelAddTypеOfServer.CheckFullnessOfContols())
			{
				TypeOfServer typeOfServer = new TypeOfServer();
				typeOfServer.Name = textBoxAddTypeOfServer.Text;
				context.TypeOfServers.Add(typeOfServer);
				context.SaveChanges();

				textBoxAddTypeOfServer.Text = String.Empty;

				dataGridTypeOfServer.AddClearRange(context.TypeOfServers.ToList());
				comboBoxTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
			}
			
		}
		private void buttonAddTypeOfServerDelete_Click(object sender, EventArgs e)
		{
			if (dataGridTypeOfServer.SelectedRows.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы уверенны что хотите удалить тип сервера?", "Потверждение", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					TypeOfServer server = (TypeOfServer)dataGridTypeOfServer.SelectedRows[0].Tag;
					context.TypeOfServers.Remove(server);
					context.SaveChanges();

					dataGridTypeOfServer.AddClearRange(context.TypeOfServers.ToList());
					comboBoxTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
				}
			}
			else
				MessageBox.Show("Не выбран тип сервера");
		}



	}
}
