using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial2
{
    public class Socio
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }


        private int nroSocio;
        public int NroSocio { get { return nroSocio; } set {  nroSocio = value; } }


        private string? nombre;
        public string? Nombre { get { return nombre; } set { nombre = value; } }


        private string? apellido;
        public string? Apellido { get { return apellido; } set { apellido = value; } }


        private string? dni;
        public string? Dni { get { return dni; } set { dni = value; } }


        private DateTime fechaNac;
        public DateTime FechaNac { get { return fechaNac; } set { fechaNac = value; } }


        private bool cuotaAlDia;
        public bool CuotaAlDia { get { return cuotaAlDia; } set { cuotaAlDia = value; } }


        public int Edad(DateTime nac)
        {
            int edad = DateTime.Now.Year - nac.Year;
            if (DateTime.Now < nac.AddYears(edad)) edad--;
            return edad;
        }
    }
}
