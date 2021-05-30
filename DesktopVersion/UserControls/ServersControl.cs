using Bunifu.DataViz;
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
		private Random random = new Random();
		List<int> gpu1 = new List<int>();
		List<int> gpu2 = new List<int>();
		List<int> gpu3 = new List<int>();
		List<int> gpu4 = new List<int>();
		List<int> memory = new List<int>();
		List<int> disk = new List<int>();
		List<int> internet = new List<int>();
		public ServersControl()
		{
			InitializeComponent();

			DragPanel dragPanel3 = new DragPanel(panelMonitoring, buttonCloseMonitoring, dataGridViewMain);
			DragPanel dragPanel2 = new DragPanel(panelEdit, buttonClosePanelEdit, buttonEditShow);
			DragPanel dragPanel = new DragPanel(panelAddTypеOfServer, buttonClosePanelAddTypeOfServer, buttonAddNewTypeOfServer);

			panelAddServer.SignOnEventControlsToShowHint();
			comboBoxOffices.AddClearEntities<Office>(context, "Name");
			comboBoxEditOffices.AddClearEntities<Office>(context, "Name");
			comboBoxTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
			comboBoxEditTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
			
			dataGridViewMain.AddClearRange(context.Servers.ToList());
			dataGridTypeOfServer.AddClearRange(context.TypeOfServers.ToList());

			bunifuDataVizGPU1.colorSet.Add(Color.Blue);
			bunifuDataVizGPU2.colorSet.Add(Color.Blue);
			bunifuDataVizGPU3.colorSet.Add(Color.Blue);
			bunifuDataVizGPU4.colorSet.Add(Color.Blue);

			bunifuDataVizMemory.colorSet.Add(Color.Purple);
			bunifuDataVizDisk.colorSet.Add(Color.Green);
			bunifuDataVizInternet.colorSet.Add(Color.Orange);
		}

		private void buttonServerAdd_Click(object sender, EventArgs e)
		{
			if (panelAddServer.CheckFullnessOfContols())
			{
				Server server = new Server();
				server.Name = textBoxServerName.Text;
				server.Ip = textBoxIP.Text;
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
				comboBoxEditTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
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
					comboBoxEditTypeOfServer.AddClearEntities<TypeOfServer>(context, "Name");
				}
			}
			else
				MessageBox.Show("Не выбран тип сервера");
		}

		private void buttonOfficeConfirmEdit_Click(object sender, EventArgs e)
		{
			if (panelBackgroundEdit.CheckFullnessOfContols())
			{
				Server server = (Server)panelEdit.Tag;
				server.TypeOfServer = (TypeOfServer)comboBoxEditTypeOfServer.SelectedItem;
				server.Office = (Office)comboBoxEditOffices.SelectedItem;
				server.Name = textBoxEditServerName.Text;
				server.Ip = textBoxEditIP.Text;
				server.Details = textBoxEditDetails.Text;
				context.SaveChanges();
				dataGridViewMain.AddClearRange(context.Servers.ToList());
				panelEdit.Visible = false;
			}
		}

		private void buttonEditShow_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count < 1)
			{
				MessageBox.Show("Не выбран сервер");
				return;
			}
			Server server = (Server)dataGridViewMain.SelectedRows[0].Tag;
			comboBoxEditTypeOfServer.SelectedItem = server.TypeOfServer;
			comboBoxEditOffices.SelectedItem = server.Office;
			textBoxEditServerName.Text = server.Name;
			textBoxEditIP.Text = server.Ip;
			textBoxEditDetails.Text = server.Details;
			panelEdit.Tag = server;
		}

		private static Canvas GetCanvas(List<int> list)
		{
			var canvas = new Canvas();
			var dataPoint = new DataPoint(BunifuDataViz._type.Bunifu_splineArea);
			foreach (var item in list)
			{
				dataPoint.addLabely("", item.ToString());
			}

			canvas.addData(dataPoint);
			return canvas;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (panelMonitoring.Visible)
			{
				switch (tabControlMemory.SelectedIndex)
				{
					case 0:
						gpu1.RemoveAt(0);
						gpu2.RemoveAt(0);
						gpu3.RemoveAt(0);
						gpu4.RemoveAt(0);

						gpu1.Add(random.Next(11));
						gpu2.Add(random.Next(11));
						gpu3.Add(random.Next(11));
						gpu4.Add(random.Next(11));

						bunifuDataVizGPU1.Render(GetCanvas(gpu1));
						bunifuDataVizGPU2.Render(GetCanvas(gpu2));
						bunifuDataVizGPU3.Render(GetCanvas(gpu3));
						bunifuDataVizGPU4.Render(GetCanvas(gpu4));
						break;
					case 1:
						memory.RemoveAt(0);

						memory.Add(random.Next(3,6));

						bunifuDataVizMemory.Render(GetCanvas(memory));
						break;
					case 2:
						disk.RemoveAt(0);

						disk.Add(random.Next(1,10));

						bunifuDataVizDisk.Render(GetCanvas(disk));
						break;
					case 3:
						internet.RemoveAt(0);

						internet.Add(random.Next(1,7));

						bunifuDataVizInternet.Render(GetCanvas(internet));
						break;
				}

			}
		}

		private void buttonExcel_Click(object sender, EventArgs e)
		{
			var excel = new Excel(dataGridViewMain);
			excel.StartExcel();
		}

		private void dataGridViewMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			gpu1 = new List<int>();
			gpu2 = new List<int>();
			gpu3 = new List<int>();
			gpu4 = new List<int>();
			memory = new List<int>();
			for (int i = 0; i < 6; i++)
			{
				gpu1.Add(0);
				gpu2.Add(0);
				gpu3.Add(0);
				gpu4.Add(0);
				memory.Add(0);
				disk.Add(0);
				internet.Add(0);
			}
			Server server = (Server)dataGridViewMain.Rows[e.RowIndex].Tag;
			labelNameOfServer.Text = $"Данные о сервере: {server.Name}";

			bunifuDataVizGPU1.Render(GetCanvas(gpu1));
			bunifuDataVizGPU2.Render(GetCanvas(gpu2));
			bunifuDataVizGPU3.Render(GetCanvas(gpu3));
			bunifuDataVizGPU4.Render(GetCanvas(gpu4));
		}
	}
}
