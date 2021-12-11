using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Sorter
{
	public partial class GestionTurnos : Form
	{
		public GestionTurnos()
		{
			InitializeComponent();
			actualizar();
			timer1.Enabled = true;
			btnGuardar.Enabled = true;
			btnLlamar.Enabled = false;
			btnModificar.Enabled = false;
			txtMesa.Enabled = true;
		}

		Heap cola = new Heap();

		void actualizar()
		{

			Conexion cn = new Conexion();

			string cadena = cn.source + cn.db + cn.user + cn.pass;

			SqlConnection conx = new SqlConnection(cadena);
			SqlConnection conx2 = new SqlConnection(cadena);
			SqlConnection conx3 = new SqlConnection(cadena);

			string com1 = "select * from turno where estado=0";
			string com2 = "update turno set estado=1 where id=@id";
			string com3 = "select * from turno;";


			//Se crea el lector para realizar la búsqueda de tickets de clientes
			//no colocados en la cola de prioridad

			SqlDataReader rd;
			conx.Open();
			SqlCommand cmd1 = new SqlCommand(com1, conx);


			rd = cmd1.ExecuteReader();

			while (rd.Read())
			{
				Turno turno = new Turno();

				turno.peso = int.Parse(rd[1].ToString());
				turno.numero = int.Parse(rd[0].ToString());
				
				//Cada turno se añade a la cola de prioridad
				cola.InsertElementInHeap(turno);

				SqlCommand cmd2 = new SqlCommand(com2, conx2);
				conx2.Open();


				//Se cambia el estado del turno en la BD
				//para que no vuelva a ser agregado a la cola

				cmd2.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
				cmd2.Parameters["@id"].Value = turno.numero;

				cmd2.ExecuteNonQuery();

				conx2.Close();
			}
			conx.Close();

			Turno turnoMuestra = null;

			if (cola != null)
			{
				turnoMuestra = cola.PeekOfHeap();
			}

			string next = "";

			if (turnoMuestra != null)
			{

				if (turnoMuestra.peso == 1)
					next += "CP";

				if (turnoMuestra.peso == 2)
					next += "CM";

				if (turnoMuestra.peso == 3)
					next += "CN";

				next += turnoMuestra.numero;
			}

			if (next == "")
			{
				lbTurno.Text = "-En Espera-";
			}
			else
			{
				lbTurno.Text = next;
			}

			SqlCommand cmd3 = new SqlCommand(com3, conx3);
			conx3.Open();
			SqlDataReader rd3 = cmd3.ExecuteReader();

			if (rd3.Read())
			{
				conx3.Close();
			}
			else
			{
				cola = null;
				cola = new Heap();
				conx3.Close();
				lbTurno.Text = "-En Espera-";
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			actualizar();
		}

		private void btnLlamar_Click(object sender, EventArgs e)
		{
			if (txtMesa.Text == "")
			{
				MessageBox.Show("Debe colocar un número de mesa o " +
					"ventana de atención", "Aviso",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Conexion cnn = new Conexion();
				//try
				//{
					Turno temp = cola.PeekOfHeap();
					cola.extractHeadOfHeap();
					cnn.llamarCliente(int.Parse(txtMesa.Text), temp.numero);
				//}
				//catch
				//{
					//MessageBox.Show("Se produjo un error, intente nuevamente",
						//"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			btnGuardar.Enabled = false;
			btnLlamar.Enabled = true;
			btnModificar.Enabled = true;
			txtMesa.Enabled = false;
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			btnLlamar.Enabled = false;
			btnGuardar.Enabled = true;
			btnModificar.Enabled = false;
			txtMesa.Enabled = true;
		}

		private void txtMesa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void GestionTurnos_Load(object sender, EventArgs e)
		{

		}
	}
}
