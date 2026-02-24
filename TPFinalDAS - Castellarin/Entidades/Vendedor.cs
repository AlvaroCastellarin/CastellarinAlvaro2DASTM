using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Dni {  get; set; }
        public int IdSucursal { get; set; }
        public Sucursal Sucursal { get; set; }
        public List<Venta> Ventas { get; set; }
    }
}
