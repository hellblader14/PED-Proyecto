using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Sorter
{
	public partial class MainMenu : Form
	{
		clientes c = new clientes();
		GestionTurnos g = new GestionTurnos();
		Usuarios u = new Usuarios();
		Tickets t = new Tickets();

		public MainMenu()
		{
			InitializeComponent();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		void cargarForm(Form frm)
		{
			if(panel1.Controls.Count > 0)
			{
				panel1.Controls.RemoveAt(0);
			}
			string nombre = frm.Name.ToString();
			
			if(nombre == "clientes")
			{
				if ((frm != null) || !(frm.IsHandleCreated))
				{
					frm = new clientes();
				}
			}
			if (nombre == "GestionTurnos")
			{
				if ((frm != null) || !(frm.IsHandleCreated))
				{
					frm = new GestionTurnos();
				}
			}
			if (nombre == "Usuarios")
			{
				if ((frm != null) || !(frm.IsHandleCreated))
				{
					frm = new Usuarios();
				}
			}
			if (nombre == "Tickets")
			{
				if ((frm != null) || !(frm.IsHandleCreated))
				{
					frm = new Tickets();
				}
			}


			frm.TopLevel = false;
			frm.FormBorderStyle = FormBorderStyle.None;
			frm.Size = new System.Drawing.Size(600, 400);
			frm.Location = new System.Drawing.Point(0, 0);
			frm.WindowState = FormWindowState.Normal;
			//LimpiarText(frm);
			this.panel1.Controls.Add(frm);
			frm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cargarForm(c);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cargarForm(g);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			cargarForm(u);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			cargarForm(t);

		}
	}
}
