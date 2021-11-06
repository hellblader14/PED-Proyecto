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
	}
}
