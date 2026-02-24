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
        public int Id_venta { get; set; }
        public Venta venta { get; set; }
        public int Id_producto { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_unitario { get; set; } // esto esta para que quede regstrado el precio del producto al momento de la venta, ya que el precio del producto puede cambiar con el tiempo
        public decimal Subtotal {  get; set; }
    }
}
