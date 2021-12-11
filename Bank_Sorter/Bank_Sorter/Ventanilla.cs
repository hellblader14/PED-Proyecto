using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace Bank_Sorter
{
	public partial class Ventanilla : Form
	{
		Turno turno = new Turno();
		List<Turno> lista = new List<Turno>();
		string[] turnos = new string[5];
		string[] mesa = new string[5];

		public Ventanilla()
		{
			InitializeComponent();

			c1.Text = "";
			c2.Text = "";
			c3.Text = "";
			c4.Text = "";
			c5.Text = "";

			v1.Text = "";
			v2.Text = "";
			v3.Text = "";
			v4.Text = "";
			v5.Text = "";

			actualizarTabla();
		}

		private void actualizarTabla()
		{
			try
			{
				//Para Línea 1            
				if (lista[0].peso == 1)
				{
					turnos[0] = "CP";
				}

				if (lista[0].peso == 2)
				{
					turnos[0] = "CM";
				}

				if (lista[0].peso == 3)
				{
					turnos[0] = "CN";
				}
				c1.Text = turnos[0] + lista[0].numero;
				v1.Text = lista[0].mesa.ToString();


				//Para Línea 2          
				if (lista[1].peso == 1)
				{
					turnos[1] = "CP";
				}

				if (lista[1].peso == 2)
				{
					turnos[1] = "CM";
				}

				if (lista[1].peso == 3)
				{
					turnos[1] = "CN";
				}
				c2.Text = turnos[1] + lista[1].numero;
				v2.Text = lista[1].mesa.ToString();

				//Para Línea 3            
				if (lista[2].peso == 1)
				{
					turnos[2] = "CP";
				}

				if (lista[2].peso == 2)
				{
					turnos[2] = "CM";
				}

				if (lista[2].peso == 3)
				{
					turnos[2] = "CN";
				}
				c3.Text = turnos[2] + lista[2].numero;
				v3.Text = lista[2].mesa.ToString();

				//Para Línea 4          
				if (lista[3].peso == 1)
				{
					turnos[3] = "CP";
				}

				if (lista[3].peso == 2)
				{
					turnos[3] = "CM";
				}

				if (lista[3].peso == 3)
				{
					turnos[3] = "CN";
				}
				c4.Text = turnos[3] + lista[3].numero;
				v4.Text = lista[3].mesa.ToString();

				//Para Línea 5            
				if (lista[4].peso == 1)
				{
					turnos[4] = "CP";
				}

				if (lista[4].peso == 2)
				{
					turnos[4] = "CM";
				}

				if (lista[4].peso == 3)
				{
					turnos[4] = "CN";
				}
				c5.Text = turnos[4] + lista[4].numero;
				v5.Text = lista[4].mesa.ToString();
			}
			catch
			{

			}
		}

		private void actualizarDatos()
		{
			Conexion cn = new Conexion();

			Turno t = cn.listarTurnos();

			if (t != null)
			{
				lista.Reverse();
				lista.Add(t);
				lista.Reverse();

				notificacion();
				actualizarTabla();
			}

			else
			{

			}

			if (lista.Count > 6)
			{
				int max = lista.Count;

				for (int i = 5; i < max; i++)
				{
					if (i == 6)
					{

					}
					else
					{
						lista.RemoveAt(i);
					}

				}
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Cerrar ventana?", "Confirmación",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnCerrar_MouseHover(object sender, EventArgs e)
		{
			btnCerrar.BackColor = Color.Red;
		}

		private void btnCerrar_MouseLeave(object sender, EventArgs e)
		{
			btnCerrar.BackColor = Color.DarkRed;
			btnCerrar.BorderStyle = BorderStyle.None;
		}

		private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
		{
			btnCerrar.BorderStyle = BorderStyle.Fixed3D;
		}

		private void btnCerrar_MouseDown(object sender, MouseEventArgs e)
		{
			btnCerrar.BorderStyle = BorderStyle.Fixed3D;
		}

		void notificacion()
		{
			SoundPlayer player = new SoundPlayer(Properties.Resources.Turno);
			player.Play();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			actualizarDatos();
		}

		private void Ventanilla_Load(object sender, EventArgs e)
		{

		}
	}
}
