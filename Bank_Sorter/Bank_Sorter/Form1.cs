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

namespace Bank_Sorter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Usuario(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			Conexion cn = new Conexion();
			try
			{
				

				string cadena = cn.CadenaConexion();
				string consulta = "SELECT * FROM Usuarios WHERE username = @id";
				SqlConnection con = new SqlConnection(cadena);
				SqlCommand cmd = new SqlCommand(consulta, con);

				cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
				cmd.Parameters["@id"].Value = txtUsuario.Text;

				con.Open();
				SqlDataReader drd = cmd.ExecuteReader();
				while (drd.Read())
				{
					if (drd[0].ToString() != txtUsuario.Text || drd[2].ToString() != txtContra.Text)
					{
						MessageBox.Show("Usuario o contraseña erróneos. En caso de no recordar el acceso, contacte al administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						drd.Close();
						con.Close();
						return;
					}
					else
					{
						
						MessageBox.Show("Bienvenido " + drd[1].ToString(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
						drd.Close();
						con.Close();
						MainMenu menu = new MainMenu();
						menu.Show();
						this.Hide();
						return;
					}
				}

			}
			catch
			{
				MessageBox.Show("Error ");
			}

		
		}
	}
}
