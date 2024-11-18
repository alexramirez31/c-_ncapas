using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class Conexion
    {
		private MySqlConnection conexion = new MySqlConnection();

        public MySqlConnection IniciarConexion()
		{
			try 
			{	        
				string con = "Server=localhost;username=root;password=admin123;database=capas";
				conexion.ConnectionString = con;
				conexion.Open();
				return conexion;
			}
			catch (MySqlException ex)
			{
				return null;
				Console.WriteLine("" +ex);
			}
		}
	}
}
