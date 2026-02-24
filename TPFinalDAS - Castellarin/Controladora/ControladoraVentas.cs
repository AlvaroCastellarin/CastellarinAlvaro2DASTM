using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.Identity.Client;
using Modelo;

namespace Controladora
{
    public class ControladoraVentas
    {
        private Repositorio repositorio = new Repositorio();
        private static ControladoraVentas instancia;
        public static ControladoraVentas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return instancia = new ControladoraVentas();
                }
                return instancia;
            }
        }
        public IReadOnlyCollection<MetodoPago> ListarMP()
        {
            return repositorio.ListarMP();
        }
        public string AgregarMP(MetodoPago mp)
        {
            try
            {
                if (mp == null)
                {
                    return "El metodo de pago no puede ser nulo.";
                }
                if (mp is Tarjeta)
                {
                    Tarjeta tarjeta = (Tarjeta)mp;
                    if (tarjeta.Cuotas <= 0)
                    {
                        return "Las cuotas deben ser un numero positivo mayor a cero.";
                    }
                    if (tarjeta.Interes < 0)
                    {
                        return "El interes no puede ser un numero negativo.";
                    }
                }
                repositorio.AgregarMP(mp);
                return "Metodo de pago registrado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error inesperado al registrar metodo de pago: " + ex.Message;
            }
        }
        public IReadOnlyCollection<Vendedor> ListarVnd()
        {
            return repositorio.ListarVnd();
        }
        public string AgregarVnd (Vendedor vnd)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(vnd.Nombre))
                {
                    return "El nombre del cliente no pude ser nulo";
                }
                if (vnd.Dni <= 0)
                {
                    return "El dni tiene que ser un numero positivo mayor a 0";
                }
                if (ListarVnd().Any(x => x.Dni == vnd.Dni ))
                {
                    return "El DNI ya esta registrado";
                }
                if (vnd.IdSucursal == 0)
                {
                    return "El vendedor tiene que tener asignada una sucursal";
                }
                if (!repositorio.ListarS().Any(x => x.Id == vnd.IdSucursal))
                {
                    return "Se debe asignar una sucursal existente";
                }
                vnd.Sucursal = repositorio.ListarS().First(x => x.Id == vnd.IdSucursal);
                vnd.Sucursal.Vendedores.Add(vnd);
                repositorio.ModificarS(vnd.Sucursal);
                repositorio.AgregarVnd(vnd);
                return "Vendedor registrado con exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string ModificarVnd(Vendedor vnd)
        {
            try
            {
                if (ListarVnd().Count == 0)
                    return "Para modificar un vendedor, debes registrar uno primero";
                if (vnd == null)
                    return "El vendedor no puede ser nulo";

                var vendedorViejo = ListarVnd().FirstOrDefault(x => x.Id == vnd.Id);
                if (vendedorViejo == null)
                    return "El vendedor que trata de modificar no existe";

                if (string.IsNullOrWhiteSpace(vnd.Nombre))
                    return "El nombre del vendedor no puede estar vacío";
                if (vnd.IdSucursal == 0)
                    return "El vendedor debe tener asignada una sucursal";

                var sucursalNueva = repositorio.ListarS().FirstOrDefault(x => x.Id == vnd.IdSucursal);
                if (sucursalNueva == null)
                    return "La sucursal que trata de asignarle al vendedor no existe";

                if (vendedorViejo.IdSucursal != vnd.IdSucursal)
                {
                    var sucursalVieja = repositorio.ListarS()
                        .First(x => x.Id == vendedorViejo.IdSucursal);

                    sucursalVieja.Vendedores.Remove(vendedorViejo);
                    sucursalNueva.Vendedores.Add(vendedorViejo);

                    repositorio.ModificarS(sucursalVieja);
                    repositorio.ModificarS(sucursalNueva);
                }

                vendedorViejo.Nombre = vnd.Nombre;
                vendedorViejo.IdSucursal = vnd.IdSucursal;

                repositorio.ModificarVnd(vendedorViejo);

                return "Vendedor modificado con éxito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string EliminarVnd(Vendedor vnd)
        {
            try
            {
                if (ListarVnd().Count == 0)
                {
                    return "Para modificar un vendedor, debes registrar uno primero";
                }
                if (vnd == null)
                {
                    return "El vendedor no puede ser nulo";
                }
                if (!ListarVnd().Any(x => x.Id == vnd.Id))
                {
                    return "El vendedor que trata de modificar no existe";
                }
                repositorio.EliminarVnd(vnd);
                return "Vendedor eliminado con exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public IReadOnlyCollection<Venta> ListarV()
        {
            return repositorio.ListarV();
        }
        public string AgregarV(Venta v)
        {
            try
            {
                if (repositorio.ListarC().Count == 0)
                {
                    return "No se pueden registrar ventas sin clientes registrados.";
                }
                if (repositorio.ListarS().Count == 0)
                {
                    return "No se pueden registrar ventas sin sucursales registradas.";
                }
                if (ListarVnd().Count == 0)
                {
                    return "Tiene que haber vendedores registrados para hacer una venta";
                }
                if (!ListarVnd().Any(x => x.Id == v.VendedorId))
                {
                    return "El vendedor seleccionado no existe";
                }
                if (v == null)
                {
                    return "La venta no puede ser nula.";
                }
                if (v.Detalles == null || !v.Detalles.Any())
                {
                    return "La venta debe tener al menos un detalle.";
                }
                if (v.ClienteId == 0)
                {
                    return "La venta debe tener asignado un cliente.";
                }
                if (!repositorio.ListarC().Any(x => x.Id == v.ClienteId))
                {
                    return "La venta debe tener asignado un cliente existente";
                }
                if (v.SucursalId == 0)
                {
                    return "La venta debe tener asignada una sucursal.";
                }
                if (!repositorio.ListarS().Any(x => x.Id == v.SucursalId))
                {
                    return "La venta debe tener asignada una sucursal existente";
                }
                v.cliente = repositorio.ListarC().First(x => x.Id == v.ClienteId);
                v.sucursal = repositorio.ListarS().First(x => x.Id == v.SucursalId);

                v.Vendedor = ListarVnd().First(x => x.Id == v.VendedorId);
                v.Vendedor.Ventas.Add(v);
                repositorio.ModificarVnd(v.Vendedor);
                v.cliente.ventas.Add(v);
                repositorio.ModificarC(v.cliente);
                v.Fecha = DateTime.Now;
                v.sucursal.ventas.Add(v);
                repositorio.ModificarS(v.sucursal);
                repositorio.AgregarV(v);
                var cliente = v.cliente;
                if (cliente is Minorista && cliente.ventas.Count >= 10)
                {
                    cliente = new Mayorista
                    {
                        Id = cliente.Id,
                        nombre_cliente = cliente.nombre_cliente,
                        ventas = cliente.ventas
                    };

                    repositorio.ModificarC(cliente);
                }
                return "Venta registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error inesperado al registrar venta: " + ex.Message;
            }
        }
        public IReadOnlyCollection<DetalleVenta> ListarDV()
        {
            return repositorio.ListarDV();
        }
        public string AgregarDV(DetalleVenta dv)
        {
            try
            {
                if (ListarV().Count == 0)
                {
                    return "No se pueden registrar detalles de venta sin ventas registradas.";
                }
                if (dv == null)
                {
                    return "El detalle de venta no puede ser nulo.";
                }
                if (dv.Id_producto == 0)
                {
                    return "El detalle de venta debe tener asignado un producto.";
                }
                if(dv.Id_venta == 0)
                {
                    return "El detalle de venta debe tener asignada una venta.";
                }
                if (dv.Cantidad < 0)
                {
                    return "La cantidad debe ser un numero positivo mayor a cero.";
                }
                if (!repositorio.ListarP().Any(x => x.Id == dv.Id_producto))
                {
                    return "El detalle de venta debe tener asignado un producto existente.";
                }
                if (!ListarV().Any(x => x.Id == dv.Id_venta))
                {
                    return "El detalle de venta debe tener asignada una venta existente.";
                }
                dv.venta = ListarV().First(x => x.Id == dv.Id_venta);
                var invenrario = repositorio.ListarI().FirstOrDefault(x => x.id_producto == dv.Id_producto && x.id_sucursal == dv.venta.SucursalId);
                if (invenrario == null)
                {
                    return "No hay inventario para ese producto en esa sucursal";
                }
                if (invenrario.cantidad <= dv.Cantidad)
                {
                    return "No hay stock sufuciente en la sucursal para poder realizar la venta";
                }
                invenrario.cantidad -= dv.Cantidad;
                repositorio.ModificarI(invenrario);
                dv.producto = repositorio.ListarP().First(x => x.Id == dv.Id_producto);
                dv.Precio_unitario = dv.producto.Precio;
                decimal Subtotal = dv.Precio_unitario * dv.Cantidad;
                if (dv.Cantidad >= 10)
                {
                    Subtotal *= 0.95m;
                }
                dv.Subtotal = Subtotal;
                dv.venta.Detalles.Add(dv);
                dv.producto.DetallesVenta.Add(dv);
                repositorio.ModificarP(dv.producto);
                repositorio.AgregarDV(dv);
                return "Detalle de venta registrado exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error inesperado al registrar detalle de venta: " + ex.Message;
            }
        }
        public IReadOnlyCollection<Factura> ListarF()
        {
            return repositorio.ListarF();
        }
         public string AgregarF(Factura f)
        {
            try
            {
                if (ListarV().Count == 0)
                {
                    return "No se pueden registrar facturas sin ventas registradas.";
                }
                if (ListarMP().Count == 0)
                {
                    return "No se pueden registrar facturas sin metodos de pago registrados.";
                }
                if (f == null)
                {
                    return "La factura no puede ser nula.";
                }
                if (f.VentaId == 0)
                {
                    return "La factura debe tener asignada una venta.";
                }
                if (f.MetodoPagoId == 0)
                {
                    return "La factura debe tener asignado un metodo de pago.";
                }
                if (!ListarV().Any(x => x.Id == f.VentaId))
                {
                    return "La factura debe tener asignada una venta existente.";
                }
                if (!ListarMP().Any(x => x.Id == f.MetodoPagoId))
                {
                    return "La factura debe tener asignado un metodo de pago existente.";
                }
                if (f.Fecha == default)
                {
                    return "La factura debe tener asignada una fecha.";
                }
                if(f.Fecha > DateTime.Now)
                {
                    return "La fecha de la factura no puede ser una fecha futura.";
                }
                f.Venta = ListarV().First(x => x.Id == f.VentaId);
                if (f.Venta.pagada == true)
                {
                    return "La venta ya fue pagada, por o que la factura ya existe";
                }
                f.MetodoPago = ListarMP().First(x => x.Id == f.MetodoPagoId);
                f.Total = CalcularTot(f.Venta, f.MetodoPago);
                f.Venta.pagada = true;
                repositorio.ModificarV(f.Venta);
                f.MetodoPago.Facturas.Add(f);
                repositorio.ModificarMP(f.MetodoPago);
                repositorio.AgregarF(f);
                return "Factura registrada exitosamente.";
            }
            catch (Exception ex)
            {
                return "Error inesperado al registrar factura: " + ex.Message;
            }
         }
        public decimal CalcularTot (Venta v, MetodoPago mp)
        {
            decimal total = v.Detalles.Sum(d => d.Subtotal);
            if (v.cliente is Mayorista && v.Detalles.Count >= 10)
                total *= 0.90m;
            if (mp is Efectivo)
                total *= 0.90m;
            if (mp is Transferencia)
                total *= 0.95m;
            if (mp is Tarjeta)
            {
                Tarjeta t = (Tarjeta)mp;
                if (t.Cuotas > 0)
                {
                    total *= t.Interes;
                }
            }
            return total;
        }
        public List<(Producto producto, int cantidadVendida)> ProductosOrdenadosPorVentas()
        {
            var detalles = ListarDV();
            var lista = detalles.GroupBy(dv => dv.producto).Select(g => (producto: g.Key, cantidadVendida: g.Sum(dv => dv.Cantidad))).OrderByDescending(x => x.cantidadVendida).ToList();
            return lista;
        }
        public IReadOnlyCollection<Venta> ReporteVentaPorPeriodo(DateTime desde, DateTime hasta)
        {
            return ListarV().Where(v => v.Fecha >= desde && v.Fecha <= hasta).ToList().AsReadOnly();
        }
        public List<(Sucursal sucursal, decimal total)> ReporteVentasPorSucursal()
        {
            return repositorio.ListarV().GroupBy(v => v.sucursal).Select(g => (sucursal: g.Key, total: g.SelectMany(v => v.Detalles).Sum(d => d.Subtotal))).OrderByDescending(x => x.total).ToList();
        }
        public List<(Vendedor vendedor, decimal total)> ReporteVentasPorVendedor()
        {
            return repositorio.ListarV().GroupBy(v => v.Vendedor).Select(g => (vendedor: g.Key, total: g.SelectMany(v => v.Detalles).Sum(d => d.Subtotal))).OrderByDescending(x => x.total).ToList();
        }
        public IReadOnlyCollection<Venta> VentasImpagasDeCliente(Cliente c)
        {
            return c.ventas.Where(v => !v.pagada).ToList().AsReadOnly();
        }
    }
}
