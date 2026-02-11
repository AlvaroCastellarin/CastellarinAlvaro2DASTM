using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public int Id { get; set; }

        public int id_sucursal { get; set; }
        public Sucursal sucursal { get; set; }

        public int id_producto { get; set; }
        public Producto producto { get; set; }

        public int cantidad { get; set; }
    }
}
