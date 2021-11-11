using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo6
{
    class CRUD
    {
        /// <summary>
        /// Este método se encarga de establecer la conexión entre la aplicación de windows form y la base de datos
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection conexion()
        {
            //Declarando variables
            string servidor = "localhost";
            string bd = "gutesbier";
            string usuario = "root";
            string contraseña = "root";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + contraseña;

            try
            {
                //Estableciendo conexión con la base de datos
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
