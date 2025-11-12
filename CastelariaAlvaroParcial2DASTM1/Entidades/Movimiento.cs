using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoMovimiento
    {
        Debito,
        Credito
    }
    public class Movimiento
    {
        public int id_mov { get; set; }

        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public TipoMovimiento Tipo { get; set; }
        public int id_cta { get; set; }
        public CuentaCorriente CuentaCorriente { get; set; }
    }
}
