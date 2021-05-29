using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopVersion
{
	public class DragPanel
	{
		private Panel panelToDrag { get; set; }
		private Button buttonClose { get; set; }
		private BunifuFlatButton buttonShowBunifu { get; set; }
		private bool dragging { get; set; } = false;
		private Point dragCursorPoint, dragFormPoint;
		public DragPanel(Panel panel, Button buttonToClose, BunifuFlatButton buttonToShow)
		{
			this.panelToDrag = panel;
			this.buttonClose = buttonToClose;
			this.buttonShowBunifu = buttonToShow;

			panelToDrag.MouseUp += panelMouseUp;
			panelToDrag.MouseMove += panelMouseMove;
			panelToDrag.MouseDown += panelMouseDown;

			this.buttonShowBunifu.Click += buttonShowClick;
			this.buttonClose.Click += buttonCloseClick;
		}
		private static Point GetPositionInForm(Control control)
		{
			Point p = control.Location;
			Control parent = control.Parent;
			while (!(parent is Form))
			{
				p.Offset(parent.Location.X, parent.Location.Y);
				parent = parent.Parent;
			}
			return p;
		}
		private void panelMouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
		private void panelMouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{

				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				panelToDrag.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}
		private void panelMouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = panelToDrag.Location;
		}

		private void buttonCloseClick(object sender, EventArgs e)
		{
			panelToDrag.Visible = false;

		}
		private void buttonShowClick(object sender, EventArgs e)
		{
			if (!panelToDrag.Visible)
			{
				panelToDrag.Visible = true;
				Point p = GetPositionInForm(buttonShowBunifu);
				panelToDrag.Location = new Point(p.X - panelToDrag.Width, p.Y);
			}
		}
	}
}
