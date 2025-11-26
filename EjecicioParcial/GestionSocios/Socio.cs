using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSocios
{
    public class Socio
    {
        public int id {  get; set; }
        public int nroSocio {  get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? dni { get; set;}
        public DateTime fechaNac { get; set; }
        public bool cuotaAlDia {  get; set; }
        public int edad (DateTime nac)
        {
            int edad = DateTime.Now.Year - nac.Year;
            if (DateTime.Now < nac.AddYears(edad)) edad--;
            return edad;
        }
    }
}
