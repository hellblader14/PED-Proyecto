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
	public partial class Usuarios : Form
	{
		public Usuarios()
		{
			InitializeComponent();
		}

		public string user = "user id=admin;";
		public string pass = "password=administrador;";
		public string db = "Initial Catalog=bank_sort;";
		public string source = "Data source= ped-banco.c4soltedlppz.us-east-2.rds.amazonaws.com,1433;";

		private void Usuarios_Load(object sender, EventArgs e)
		{
			actualizarGrid();
		}

		public void actualizarGrid()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT username as " +
				"'Nombre de Usuario', nombre as 'Nombre', tipo as 'Nivel de Usuario' FROM Usuarios",
				"server = ped-banco.c4soltedlppz.us-east-2.rds.amazonaws.com,1433; database = bank_sort; " +
				"UID = admin; password = administrador");
			DataSet ds = new DataSet();
			da.Fill(ds, "usuarios");
			dgvUsuarios.DataSource = ds.Tables["usuarios"].DefaultView;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string cadena = source + db + user + pass;

			Conexion cn = new Conexion();
			try
			{
				string cadena2 = cn.CadenaConexion();
				string consulta = "SELECT * FROM usuarios";
				SqlConnection con = new SqlConnection(cadena);
				SqlCommand cmd2 = new SqlCommand(consulta, con);

				con.Open();
				SqlDataReader drd = cmd2.ExecuteReader();
				while (drd.Read())
				{
					if (drd["username"].ToString() == txtUsuario.Text)
					{
						MessageBox.Show("El nombre de usuario ingresado ya existe");
						drd.Close();
						con.Close();
						return;
					}

				}

			}
			catch
			{
				MessageBox.Show("Error ");
			}

			Aes256Base64Encrypter enc = new Aes256Base64Encrypter();

			SqlConnection conx = new SqlConnection(cadena);
			string com = "insert into usuarios (username,nombre,contra, tipo) " +
				"values (@id, @nom, @con, @tip);";
			conx.Open();
			SqlCommand cmd = new SqlCommand(com, conx);

			cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
			cmd.Parameters["@id"].Value = txtUsuario.Text;

			cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
			cmd.Parameters["@nom"].Value = txtNombre.Text;

			cmd.Parameters.Add(new SqlParameter("@con", SqlDbType.VarChar));
			cmd.Parameters["@con"].Value = enc.Encrypt(txtContra.Text, "215");

			if (rbCont.Checked == true)
			{
				cmd.Parameters.Add(new SqlParameter("@tip", SqlDbType.VarChar));
				cmd.Parameters["@tip"].Value = "1";
			}
			else if (rbTran.Checked == true)
			{
				cmd.Parameters.Add(new SqlParameter("@tip", SqlDbType.VarChar));
				cmd.Parameters["@tip"].Value = "2";
			}
			else
			{
				MessageBox.Show("Seleccione el nivel de acceso que tendrá el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				conx.Close();
				actualizarGrid();

				return;
			}


			cmd.ExecuteNonQuery();
			conx.Close();
			actualizarGrid();
			txtUsuario.Text = "";
			txtContra.Text = "";
			txtNombre.Text = "";
			rbCont.Checked = false;
			rbTran.Checked = false;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{


			if ((string)dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value == "admin")
			{
				MessageBox.Show("Usuario no puede ser eliminado", "Acción no autorizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if ((string)dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value == Program.usuario)
			{
				MessageBox.Show("No se puede eliminar el usuario utilizado para iniciar sesión.", "Acción no autorizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}


			Conexion cn = new Conexion();
			string cadena = cn.CadenaConexion();
			string consulta = "DELETE FROM usuarios WHERE username = @id";
			SqlConnection con = new SqlConnection(cadena);
			SqlCommand cmd = new SqlCommand(consulta, con);
			cmd.Parameters.AddWithValue("@id", dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value);

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Usuario eliminado",
					"Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Hubo un error, intente nuevamente",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				con.Close();
			}
			actualizarGrid();
		}
	}
}
