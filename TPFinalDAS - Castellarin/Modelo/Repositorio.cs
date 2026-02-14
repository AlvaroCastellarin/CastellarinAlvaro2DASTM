using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class Repositorio
    {
        private Context Context;
        public Repositorio()
        {
            Context = new Context();
        }
        public IReadOnlyCollection<Producto> ListarP()
        {
            return Context.Productos.ToList().AsReadOnly();
        }
        public void AgregarP(Producto producto)
        {
            Context.Productos.Add(producto);
            Context.SaveChanges();
        }
        public void ModificarP(Producto producto)
        {
            Context.Productos.Update(producto);
            Context.SaveChanges();
        }
        public void EliminarP(Producto producto)
        {
            Context.Productos.Remove(producto);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<Cliente> ListarC()
        {
            return Context.Clientes.ToList().AsReadOnly();
        }
        public void AgregarC(Cliente cliente)
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
        }
        public void ModificarC(Cliente cliente)
        {
            Context.Clientes.Update(cliente);
            Context.SaveChanges();
        }
        public void EliminarC(Cliente cliente)
        {
            Context.Clientes.Remove(cliente);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<Venta> ListarV()
        {
            return Context.Ventas.ToList().AsReadOnly();
        }
        public void AgregarV(Venta venta)
        {
            Context.Ventas.Add(venta);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<DetalleVenta> ListarDV()
        {
            return Context.DetallesVenta.ToList().AsReadOnly();
        }
        public void AgregarDV(DetalleVenta detalleVenta)
        {
            Context.DetallesVenta.Add(detalleVenta);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<Factura> ListarF()
        {
            return Context.Facturas.ToList().AsReadOnly();
        }
        public void AgregarF(Factura factura)
        {
            Context.Facturas.Add(factura);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<Sucursal> ListarS()
        {
            return Context.Sucursales.ToList().AsReadOnly();
        }
        public void AgregarS(Sucursal sucursal)
        {
            Context.Sucursales.Add(sucursal);
            Context.SaveChanges();
        }
        public void ModificarS(Sucursal sucursal)
        {
            Context.Sucursales.Update(sucursal);
            Context.SaveChanges();
        }
        public void EliminarS(Sucursal sucursal)
        {
            Context.Sucursales.Remove(sucursal);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<Inventario> ListarI()
        {
            return Context.Inventarios.ToList().AsReadOnly();
        }
        public void AgregarI(Inventario inventario)
        {
            Context.Inventarios.Add(inventario);
            Context.SaveChanges();
        }
        public void ModificarI(Inventario inventario)
        {
            Context.Inventarios.Update(inventario);
            Context.SaveChanges();
        }
        public void EliminarI(Inventario inventario)
        {
            Context.Inventarios.Remove(inventario);
            Context.SaveChanges();
        }
        public IReadOnlyCollection<MetodoPago> ListarMP()
        {
            return Context.MetodosPago.ToList().AsReadOnly();
        }
        public void AgregarMP(MetodoPago metodoPago)
        {
            Context.MetodosPago.Add(metodoPago);
            Context.SaveChanges();
        }
    }
}
