using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        MySqlConnection cn;

        public DataSet mostrar()
        {
            try
            {
                cn = new Conexion().IniciarConexion();
                MySqlCommand comando = new MySqlCommand("select * from usuario",cn);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataSet ds = new DataSet();

                datos.Fill(ds);

                return ds;
            }
            catch (MySqlException ex)
            {
                return null;
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public void Insertar(string id,string nombre,string telefono)
        {
            try
            {
                cn = new Conexion().IniciarConexion();
                MySqlCommand comando = new MySqlCommand($"INSERT INTO Usuario values({id},'{nombre}',{telefono})", cn);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public string[] Buscar(string id)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"select * from usuario where id={id}", cn);
                MySqlDataReader reader = comando.ExecuteReader();

                string[] datos = new string[3];

                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        datos[0] = reader.GetString(0);
                        datos[1] = reader.GetString(1);
                        datos[2] = reader.GetString(2);
                    }

                    reader.Close();
                }

                return datos;

            }
            catch (MySqlException ex)
            {
                return null;
                throw;
            }
        }

        public void Actualizar(string id, string nombre, string telefono)
        {
            try
            {
                cn = new Conexion().IniciarConexion();
                MySqlCommand comando = new MySqlCommand($"update Usuario set nombre='{nombre}',telefono={telefono} where id=({id})", cn);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public void Eliminar(string id)
        {
            try
            {
                cn = new Conexion().IniciarConexion();
                MySqlCommand comando = new MySqlCommand($"delete from usuario where id=({id})", cn);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }


    
}
