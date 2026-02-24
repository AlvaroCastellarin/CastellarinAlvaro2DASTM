using Entidades;

public class Factura
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public int VentaId { get; set; }
    public Venta Venta { get; set; }
    public decimal Total { get; set; }
    public int MetodoPagoId { get; set; }
    public MetodoPago MetodoPago { get; set; }
}
