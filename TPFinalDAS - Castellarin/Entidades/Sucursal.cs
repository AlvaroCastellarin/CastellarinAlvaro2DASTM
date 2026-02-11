using Entidades;

public class Sucursal
{
    public int Id { get; set; }
    public string nombre_sucursal { get; set; } = "";

    public List<Venta> ventas { get; set; } = new();
    public List<Inventario> inventario_local { get; set; } = new();
}
