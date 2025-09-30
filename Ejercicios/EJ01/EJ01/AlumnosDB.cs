using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace EJ01
{
    public class AlumnosDB
    {
        private string cadenaConexion = "Data Source = ALVARO\\SQLEXPRESS; Initial Catalog = EJ01;" + "Integrated Security=True;";
        public bool prueba()
        {
            try { SqlConnection c = new SqlConnection(cadenaConexion); c.Open(); }
            catch { return false; }
            return true;
        }
        public List<Alumno> ListaAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            string Query = "SELECT legajo, nombre, edad FROM Alumnos";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(Query, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Alumno a = new Alumno();
                        a.legajo = lector.GetInt32(0);
                        a.nombre = lector.GetString(1);
                        a.edad = lector.GetInt32(2);
                        alumnos.Add(a);
                    }
                    lector.Close();
                    conexion.Close();
                    return alumnos;
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
        public Alumno ObtenerAlumno(int l)
        {
            string Query = "SELECT legajo, nombre, edad FROM Alumnos " + "WHERE legajo = @legajo";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.Parameters.AddWithValue("@legajo", l);
                try
                {
                    conexion.Open();
                    SqlDataReader lec = comando.ExecuteReader();
                    lec.Read();
                    Alumno a = new Alumno();
                    a.legajo = lec.GetInt32(0);
                    a.nombre = lec.GetString(1);
                    a.edad = lec.GetInt32(2);
                    lec.Close();
                    conexion.Close();
                    return a;
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message ); }
            }
        }
        public void AltaAlumno(string n, int e)
        {
            string Query = "INSERT INTO Alumnos(nombre, edad) VALUES" + " (@nombre, @edad)";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.Parameters.AddWithValue("@nombre", n);
                comando.Parameters.AddWithValue("@edad", e);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
        public void BajaAlumno(int l)
        {
            string Query = "DELETE FROM Alumnos" + " WHERE legajo = @legajo";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.Parameters.AddWithValue("@legajo", l);
                try { conexion.Open(); comando.ExecuteNonQuery(); conexion.Close(); }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
        public void ModifcaAlumno(string n, int e, int l)
        {
            string Query = "UPDATE Alumnos SET nombre=@nombre, edad=@edad" + " WHERE legajo=@legajo";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(Query, conexion);
                comando.Parameters.AddWithValue("@legajo", l);
                comando.Parameters.AddWithValue("@edad", e);
                comando.Parameters.AddWithValue("@nombre", n);
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            }
        }
    }
}
