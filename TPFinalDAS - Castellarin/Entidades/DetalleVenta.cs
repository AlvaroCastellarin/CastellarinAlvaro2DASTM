using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int id_venta { get; set; }
        public Venta venta { get; set; }
        public int id_producto { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }   

    }
}
