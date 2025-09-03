using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EJ01
{
    public class AlumnosDB
    {
        private string connectionString =
          "Data Source=localhost;Initial Catalog=EJ01;Integrated Security=True;";
        public bool ProbarConexion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar: " + ex.Message);
                    return false;
                }
            }

        }
    }
}