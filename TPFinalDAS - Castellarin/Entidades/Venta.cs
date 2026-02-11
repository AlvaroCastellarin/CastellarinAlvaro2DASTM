using Entidades;

public class Venta
{
    public int Id { get; set; }

    public int ClienteId { get; set; }
    public Cliente cliente { get; set; }

    public int SucursalId { get; set; }
    public Sucursal sucursal { get; set; }

    public List<DetalleVenta> detalleVenta { get; set; } = new();

    public Factura factura { get; set; }
}
