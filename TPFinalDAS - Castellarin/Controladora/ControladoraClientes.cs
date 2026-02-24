using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraClientes
    {
        private Repositorio repositorio = new Repositorio();
        private static ControladoraClientes instancia;
        public static ControladoraClientes Instancia
        {
            get
            {
                if(instancia == null)
                {
                    return instancia = new ControladoraClientes();
                }
                return instancia;
            }
        }
        public IReadOnlyCollection<Cliente> ListarC()
        {
            return repositorio.ListarC();
        }
        public string Agregar(Cliente c)
        {
            try
            {
                if (c == null)
                {
                    return "El cliente no puede ser nulo";
                }
                if (string.IsNullOrEmpty(c.nombre_cliente))
                {
                    return "El nombre del cliente no puede estar vacio";
                }
                repositorio.AgregarC(c);
                return "Cliente registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error inesperado al registrar cliente: " + ex.Message;
            }
        }
        public string Modificar(Cliente c)
        {
            try
            {
                if (ListarC().Count == 0)
                {
                    return "No hay clientes registrados para modificar";
                }
                if (c == null)
                {
                    return "El cliente no puede ser nulo";
                }
                if (!ListarC().Any(x => x.Id == c.Id))
                {
                    return "El cliente que quiere modificar no existe";
                }
                if (string.IsNullOrWhiteSpace(c.nombre_cliente))
                {
                    return "El nombre del cliente no pude estar vacio";
                }
                repositorio.ModificarC(c);
                return "Cambios realizados";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.Message;
            }
        }
       
        }

    }
}
