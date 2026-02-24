using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraInventario
    {
        private Repositorio repositorio = new Repositorio();
        private static ControladoraInventario instancia;
        public static ControladoraInventario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return instancia = new ControladoraInventario();
                }
                return instancia;
            }
        }
        public IReadOnlyCollection<Producto> ListarP()
        {
            return repositorio.ListarP();
        }
        public string AltaP(Producto p)
        {
            try
            {
                if (p == null)
                {
                    return "El producto no puede ser nulo";
                }
                if (string.IsNullOrWhiteSpace(p.Nombre))
                {
                    return "El nombre del producto no puede estar vacio";
                }
                if (ListarP().Any((x => string.Equals(x.Nombre, p.Nombre, StringComparison.OrdinalIgnoreCase))))
                {
                    return "El nombre ya esta registrado";
                }
                if (p.Precio <= 0)
                {
                    return "El precio debe ser mayor a 0";
                }
                if (string.IsNullOrWhiteSpace(p.Categoria))
                {
                    return "Al producto se le debe asignar una categoria";
                }

                repositorio.AgregarP(p);
                return "Producto registrado con exito";
            }
            catch(Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string ModificarP(Producto p)
        {
            try
            {
                if (ListarP().Count == 0)
                {
                    return "No hay producto existentes para modificar";
                }
                if (p == null)
                {
                    return "El producto no puede ser nulo";
                }
                if (!ListarP().Any(x => x.Id == p.Id))
                {
                    return "No se encontro el producto a modificar";
                }
                if (ListarP().Any(x => x.Id != p.Id && x.Nombre == p.Nombre))
                {
                    return "El nombre que intenta guardar ya esta registrado";
                }
                if (p.Precio <= 0)
                {
                    return "El precio debe ser un numero positivo y mayor a cero";
                }
                if (string.IsNullOrWhiteSpace(p.Categoria))
                {
                    return "La categoria no puede estar vacia";
                }
                repositorio.ModificarP(p);
                return "Cambios realizados con éxito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string BajaP (Producto p)
        {
            try
            {
                if (ListarP().Count == 0)
                {
                    return "No hay productos existentes para eliminar";
                }
                if (!ListarP().Any(x => x.Id == p.Id))
                    return "No se encontró el producto a eliminar";
                var inventarios = ListarI().Where(x => x.id_producto == p.Id).ToList();
                foreach (var inv in inventarios)
                {
                    repositorio.EliminarI(inv);
                }
                    repositorio.EliminarP(p);
                return "Cambios realizados con éxito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public IReadOnlyCollection<Sucursal> ListarS()
        {
            return repositorio.ListarS();
        }
        public string AltaS (Sucursal s)
        {
            try
            {
                if (ListarS().Any(x => string.Equals(x.nombre_sucursal, s.nombre_sucursal, StringComparison.OrdinalIgnoreCase)))
                    return "Nombre de sucursal ya registrado";
                repositorio.AgregarS(s);
                return "Sucursal registrada con exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
        public string BajaS (Sucursal s)
        {
            try
            {
                if (!ListarS().Any(x => x.Id == s.Id))
                    return "No se encontro la sucursal a eliminar";
                repositorio.EliminarS(s);
                return "Sucursal eliminada com exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public IReadOnlyCollection<Inventario> ListarI()
        {
            return repositorio.ListarI();
        }
        public string AltaI(Sucursal s, Producto p, int cantidad)
        {
            try
            {

                if (ListarP().Count == 0)
                    return "No hay productos registrados para ser iventariados";
                if (ListarS().Count == 0)
                    return "No hay sucursales registadas para hacer el inventariado";
                if (!ListarS().Any(x => x.Id == s.Id))
                    return "La sucursal no existe";
                if (!ListarP().Any(x => x.Id == p.Id))
                    return "El producto que trata de inventariar no existe";
                if (cantidad <= 0)
                    return "La cantida de unidades del producto debe ser mayor a 0";
                if (ListarI().Any(x => x.id_sucursal == s.Id && x.id_producto == p.Id))
                    return "Ese producto ya está inventariado en esa sucursal";
                Inventario i = new Inventario();
                i.id_sucursal = s.Id;
                i.id_producto = p.Id;
                i.producto = p;
                i.sucursal = s;
                i.cantidad = cantidad;
                i.producto.Inventarios.Add(i);
                repositorio.ModificarP(i.producto);
                i.sucursal.inventario_local.Add(i);
                repositorio.ModificarS(i.sucursal);
                repositorio.AgregarI(i);
                return "Producto inventariado con exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string ModificarI(Inventario i, int cantidad)
        {
            try
            {
                if (i == null)
                    return "El producto no puede ser nulo";
                if (ListarP().Count == 0)
                    return "No hay productos registrados para ser iventariados";
                if (ListarS().Count == 0)
                    return "No hay sucursales registadas para hacer el inventariado";
                if (ListarI().Count == 0)
                    return "No hay inventariados hechos para modificar";
                if (cantidad <= 0)
                    return "La cantida de unidades del producto debe ser mayor a 0";
                if (i.cantidad == cantidad)
                    return "El producto ya esta inventariado con esta cantidad en la sucursal" + i.sucursal.nombre_sucursal;
                i.cantidad = cantidad;
                repositorio.ModificarI(i);
                return "Inventariado modificado con exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string BajaI(Inventario i)
        {
            try
            {

                if (ListarP().Count == 0)
                    return "No hay productos registrados para ser iventariados";
                if (ListarS().Count == 0)
                    return "No hay sucursales registadas para hacer el inventariado";
                if (ListarI().Count == 0)
                    return "No hay inventariados hechos para dar de baja";
                repositorio.EliminarI(i);
                return "Producto dado de baja con exito";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string ConsultaDisponibilidad(Producto p, Sucursal s)
        {
            try
            {
                if (ListarP().Count == 0)
                {
                    return "No se pueden hacer consultas de stock, porque no hay productos registrados";
                }
                if (ListarS().Count == 0)
                {
                    return "No se pueden hacer consultas de stock, porque no hay sucursales registradas";
                }
                var inventario = ListarI().FirstOrDefault(x => x.id_producto == p.Id && x.id_sucursal == s.Id);
                if (inventario == null)
                {
                    return "El producto no esta inventariado";
                }
                return $"El producto '{p.Nombre}' tiene {inventario.cantidad} unidades disponibles en la sucursal '{s.nombre_sucursal}'";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}
