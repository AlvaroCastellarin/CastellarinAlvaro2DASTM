using Entidades;

public class Sucursal
{
    public int Id { get; set; }
    public string nombre_sucursal { get; set; }

    public List<Venta> ventas { get; set; }
    public List<Inventario> inventario_local { get; set; }
    public List<Vendedor> Vendedores { get;set; }

}
