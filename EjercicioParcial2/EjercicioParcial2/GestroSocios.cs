using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EjercicioParcial2
{
    public class GestroSocios
    {
        private string cadenaConexion = "Data source = ALVARO\\SQLEXPRESS; Initial Catalog = Club; Integrated Security=True;TrustServerCertificate=True;";
        public bool prueba()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return true;
        }
        public List<Socio> ListaSocios()
        {
            List<Socio> socios = new List<Socio>();
            string query = "select * from Socios";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Socio s = new Socio();
                        s.Id = lector.GetInt32(0);
                        s.Nombre = lector.GetString(1);
                        s.Apellido = lector.GetString(2);
                        s.Dni = lector.GetString(3);
                        s.FechaNac = lector.GetDateTime(4);
                        s.NroSocio = lector.GetInt32(5);
                        s.CuotaAlDia = lector.GetBoolean(6);
                        socios.Add(s);
                    }
                    lector.Close();
                    return socios;
                    conexion.Close();
                }
                catch { throw; }
            }
        }
        public void AltaSocio(string nombre, string apellido, string dni, DateTime fechaNac, int nroSocio, bool cuotaDia)
        {
            string query = "insert into Socios (nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia) values" +
                "(@nombre, @apellido, @dni, @fecha_nacimiento, @numero_socio, @cuota_al_dia)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fechaNac);
                comando.Parameters.AddWithValue("@numero_socio", nroSocio);
                comando.Parameters.AddWithValue("@cuota_al_dia", cuotaDia);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch { throw; }
            }
        }
        public void BajaSocio(int id)
        {
            string query = "delete from Socios where id=@id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch { throw; }
            }
        }
    }
}