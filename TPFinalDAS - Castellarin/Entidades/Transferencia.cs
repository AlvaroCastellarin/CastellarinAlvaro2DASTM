using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Transferencia : MetodoPago
    {
        public decimal descuento_transferencia { get; set; } = 0.05m; // Descuento del 5% para pagos por transferencia bancaria
    }
}
