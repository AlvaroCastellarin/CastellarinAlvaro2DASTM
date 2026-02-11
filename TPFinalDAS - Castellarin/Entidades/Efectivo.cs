using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Efectivo : MetodoPago
    {
        public decimal descuento_efectivo { get; set; } = 0.10m; // Descuento del 10% para pagos en efectivo
    }
}
