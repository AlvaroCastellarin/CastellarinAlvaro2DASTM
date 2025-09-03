using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    public class AlumnosBD
    {
        private string connectionString =
            "Data Source=ALVARO\\SQLEXPRESS;Initial Catalog=EJ01;Integrated Security=True;";

        public bool ProbarConexion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
