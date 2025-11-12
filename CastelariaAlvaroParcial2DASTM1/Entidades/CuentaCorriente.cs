using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {
        public int id_cta { get; set; }
        public int nro_cta { get; set; }
        public int id_cli { get; set; }
        public Cliente Cliente { get; set; }
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
    }
}
