using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarjeta : MetodoPago
    {
        public int Cuotas { get; set; }
        public decimal Interes { get; set; }
    }
}
