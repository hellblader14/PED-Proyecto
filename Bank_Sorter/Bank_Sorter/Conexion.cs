using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bank_Sorter
{
	class Conexion
	{
		public string user = "user id=admin;";
		public string pass = "password=administrador;";
		public string db = "Initial Catalog=bank_sort;";
		public string source = "Data source= ped-banco.c4soltedlppz.us-east-2.rds.amazonaws.com,1433;";

		public string CadenaConexion()
		{
			SqlConnection conexion = new SqlConnection();

			SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();

			cadena.UserID = Properties.Settings.Default.loginid;

			cadena.Password = Properties.Settings.Default.pass;

			cadena.InitialCatalog = Properties.Settings.Default.bdd;

			cadena.DataSource = Properties.Settings.Default.servidor;

			cadena.ConnectTimeout = 30;

			conexion.ConnectionString = cadena.ConnectionString;
			return conexion.ConnectionString;
		}

		public void agregarTurno(int peso)
		{
			string cadena = source + db + user + pass;
			SqlConnection conx = new SqlConnection(cadena);
			string com = "insert into turno(peso, estado) " +
				"values (@peso,0);";
			conx.Open();
			SqlCommand cmd = new SqlCommand(com, conx);

			cmd.Parameters.Add(new SqlParameter("@peso", SqlDbType.Int));
			cmd.Parameters["@peso"].Value = peso;

			cmd.ExecuteNonQuery();
			conx.Close();
		}

		public void reiniciar()
		{
			string cadena = source + db + user + pass;
			SqlConnection conx = new SqlConnection(cadena);
			string com = "delete from turno;DBCC CHECKIDENT ('turno',reseed, 0);";
			conx.Open();
			SqlCommand cmd = new SqlCommand(com, conx);

			cmd.ExecuteNonQuery();
			conx.Close();
		}

		public Turno listarTurnos()
		{
			string cadena = source + db + user + pass;
			SqlConnection conx = new SqlConnection(cadena);
			SqlConnection conx2 = new SqlConnection(cadena);

			string com = "select top 1 * from turno where estado=2";
			string com2 = "update turno set estado = 3 where id=@id;";

			conx.Open();

			SqlCommand cmd = new SqlCommand(com, conx);
			SqlCommand cmd2 = new SqlCommand(com2, conx2);

			SqlDataReader rd = cmd.ExecuteReader();

			if (rd.Read())
			{
				Turno turno = new Turno();
				turno.numero = int.Parse(rd[0].ToString());
				turno.peso = int.Parse(rd[1].ToString());
				turno.mesa = int.Parse(rd[3].ToString());

				cmd2.Parameters.AddWithValue("@id", int.Parse(turno.numero.ToString()));

				conx2.Open();

				cmd2.ExecuteNonQuery();
				conx2.Close();

				conx.Close();
				return turno;
			}

			else
			{
				conx.Close();
				return null;
			}
		}

		public void llamarCliente(int mesa, int idu)
		{
			string cadena = source + db + user + pass;
			SqlConnection conx = new SqlConnection(cadena);
			string com = "update turno set estado=2, mesa=@mesa where id=@id;";
			conx.Open();
			SqlCommand cmd = new SqlCommand(com, conx);

			cmd.Parameters.Add(new SqlParameter("@mesa", SqlDbType.Int));
			cmd.Parameters["@mesa"].Value = mesa;

			cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
			cmd.Parameters["@id"].Value = idu;

			cmd.ExecuteNonQuery();
			conx.Close();
		}
	}
}
