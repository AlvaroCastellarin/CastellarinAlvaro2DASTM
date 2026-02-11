using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public List<DetalleVenta> DetallesVenta { get; set; }
        public List<Inventario> Inventarios { get; set; }
    }
}
