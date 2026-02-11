using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nombre_cliente { get; set; }
        public List<Venta> ventas { get; set; }
    }
}
