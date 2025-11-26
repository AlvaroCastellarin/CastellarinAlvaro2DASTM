using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace GestionSocios
{
    public class GestionSocios
    {
        private string cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Club;Integrated Security=True;TrustServerCertificate=True;";
        public bool prueba()
        {
            try
            {
                using SqlConnection c = new SqlConnection(cadenaConexion);
                c.Open();
                MessageBox.Show("Conectado correctamente");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public List<Socio> getSocioList()
        {
            List<Socio> socios = new List<Socio>();
            string query = "SELECT * FROM Socios";
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
                        s.id = lector.GetInt32(0);
                        s.nombre = lector.GetString(1);
                        s.apellido = lector.GetString(2);
                        s.dni = lector.GetString(3);
                        s.fechaNac = lector.GetDateTime(4);
                        s.nroSocio = lector.GetInt32(5);
                        s.cuotaAlDia = lector.GetBoolean(6);
                        socios.Add(s);
                    }
                    lector.Close();
                    conexion.Close();
                    return socios;
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
        public void AltaSocio(string nombre, string apellido, string dni, DateTime fechaNac, int nroSoc, bool cuotaDia)
        {
            string query = "insert into Socios (nombre, apellido, dni, fecha_nacimiento, numero_socio, cuota_al_dia) values" + " (@nombre, @apellido, @dni, @fecha_nacimiento, @numero_socio, @cuota_al_dia)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fechaNac);
                comando.Parameters.AddWithValue("@numero_socio", nroSoc);
                comando.Parameters.AddWithValue("@cuota_al_dia", cuotaDia);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
            
        }
        public void BajaSocio(int id)
        {
            string query = "delete from Socios" + " where id = @id";
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
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
        public Socio ObterSocio(int id)
        {
            string query = "select * from Socios" + " where id = @id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    lector.Read();
                    Socio s = new Socio();
                    s.id = lector.GetInt32(0);
                    s.nombre = lector.GetString(1);
                    s.apellido = lector.GetString(2);
                    s.dni = lector.GetString(3);
                    s.fechaNac = lector.GetDateTime(4);
                    s.nroSocio = lector.GetInt32(5);
                    s.cuotaAlDia = lector.GetBoolean(6);
                    return s;
                }
                catch (Exception ex) { throw new Exception("Error: "+ex.Message); }
            }
        }
        public void ModificaSocio(int id, string nombre, string apellido, string dni, DateTime fechaNac, int nroSoc, bool cuotaDia)
        {
            string query = "update Socios set nombre = @nombre, apellido = @apellido, dni = @dni, fecha_nacimiento = @fecha_nacimiento, numero_socio = @numero_socio, cuota_al_dia = @cuota_al_dia" + " where id = @id";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand (query, conexion);
                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@fecha_nacimiento", fechaNac);
                comando.Parameters.AddWithValue("@numero_socio", nroSoc);
                comando.Parameters.AddWithValue("@cuota_al_dia", cuotaDia);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
        public int contadorSociosAlDia()
        {
            List<Socio> socios = getSocioList();
            int contador = socios.Count(x => x.cuotaAlDia == true);
            return contador;
        }
        public List<Socio> SociosMayores()
        {
            List<Socio> socios = getSocioList();
            List<Socio> mayores = socios.Where(x => x.edad(x.fechaNac) >= 18).ToList();
            return mayores;
        }
    }
}

