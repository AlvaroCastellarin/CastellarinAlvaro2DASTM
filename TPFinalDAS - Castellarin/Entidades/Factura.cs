using Entidades;

public class Factura
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public int VentaId { get; set; }
    public Venta venta { get; set; }

    public int MetodoPagoId { get; set; }
    public MetodoPago metodoPago { get; set; }
}
