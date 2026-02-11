using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mayorista : Cliente
    {
        public int cuit { get; set; }
        public decimal descuento { get; set; } = 0.10m; // Descuento del 10% para mayoristas
    }
}
