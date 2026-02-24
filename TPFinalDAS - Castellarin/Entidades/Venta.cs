using Entidades;

public class Venta
{
    public int Id { get; set; }

    public int ClienteId { get; set; }
    public Cliente cliente { get; set; }

    public int SucursalId { get; set; }
    public Sucursal sucursal { get; set; }
    public int VendedorId { get; set; }
    public Vendedor Vendedor { get; set; }
    public DateTime Fecha { get; set; }
    public bool pagada { get; set; } = false;

    public List<DetalleVenta> Detalles { get; set; } = new();
}
