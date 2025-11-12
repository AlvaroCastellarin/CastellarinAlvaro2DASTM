using Entidades;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using static Modelo.Context;

namespace Controladora
{
    public class Controladora
    {
        private Repositorio repositorio = new Repositorio();
        private static Controladora instancia;
        public static Controladora Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora();
                }
                return instancia;
            }
        }
        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return repositorio.ListarClientes();
        }

        public string AgregarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                return "Error: Nombre y Apellido del cliente son obligatorios.";
            }
            if (cliente.DNI <= 0)
            {
                return "Error: DNI debe ser un valor positivo.";
            }
            if (repositorio.ObtenerClientePorDNI(cliente.DNI) != null)
            {
                return "Error: Ya existe un cliente con el mismo DNI.";
            }

            repositorio.AgregarCliente(cliente);
            return "Cliente registrado con éxito.";
        }

        public string ModificarCliente(Cliente cliente)
        {
            repositorio.ModificarCliente(cliente);
            return "Cliente modificado con éxito.";
        }

        public string EliminarCliente(Cliente cliente)
        {
            try
            {
                repositorio.EliminarCliente(cliente);
                return "Cliente eliminado con éxito (y todas sus cuentas/movimientos).";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el cliente: El sistema no pudo completar la baja.";
            }
        }
        public string CrearCuentaCorriente(int id_cli)
        {
            if (repositorio.ListarClientes().FirstOrDefault(c => c.id_cli == id_cli) == null)
            {
                return "Error: No se encontró el cliente para asociar la cuenta.";
            }
            int ultimoNro = repositorio.ObtenerUltimoNumeroCuenta();
            int nuevoNroCuenta = ultimoNro + 1;

            CuentaCorriente nuevaCuenta = new CuentaCorriente
            {
                id_cli = id_cli,
                nro_cta = nuevoNroCuenta
            };
            repositorio.AgregarCuenta(nuevaCuenta);
            return $"Cuenta Corriente creada y asociada. Número asignado: {nuevoNroCuenta}.";
        }

        public IReadOnlyCollection<CuentaCorriente> ListarCuentasConSaldos()
        {
            return repositorio.ListarCuentas();
        }
        public string AgregarMovimiento(Movimiento movimiento)
        {
            if (movimiento.Monto <= 0)
            {
                return "Error: El monto del movimiento debe ser un valor positivo.";
            }
            var cuenta = repositorio.ObtenerCuentaPorId(movimiento.id_cta);
            if (cuenta == null)
            {
                return "Error: La cuenta corriente especificada no existe.";
            }
            if (movimiento.Fecha == default(DateTime))
            {
                movimiento.Fecha = DateTime.Now;
            }

            repositorio.AgregarMovimiento(movimiento);

            return $"Movimiento de {movimiento.Tipo} por {movimiento.Monto} registrado con éxito en la cuenta {movimiento.id_cta}.";
        }
        public decimal CalcularSaldo(int id_cta)
        {
            var cuenta = repositorio.ObtenerCuentaPorId(id_cta);

            if (cuenta == null)
            {
                return 0m;
            }
            var movimientos = cuenta.Movimientos;
            var totalCreditos = movimientos
                .Where(m => m.Tipo == TipoMovimiento.Credito)
                .Sum(m => m.Monto);

            var totalDebitos = movimientos
                .Where(m => m.Tipo == TipoMovimiento.Debito)
                .Sum(m => m.Monto);

            return totalCreditos - totalDebitos;
        }
        public IReadOnlyCollection<Movimiento> VerHistorial(int id_cta)
        {
            return repositorio.ListarMovimientosPorCuenta(id_cta);
        }
        public (decimal totalCreditos, decimal totalDebitos, decimal saldo) ObtenerResumen(int id_cta)
        {
            var movimientos = repositorio.ListarMovimientosPorCuenta(id_cta);

            var totalCreditos = movimientos
                .Where(m => m.Tipo == TipoMovimiento.Credito)
                .Sum(m => m.Monto);

            var totalDebitos = movimientos
                .Where(m => m.Tipo == TipoMovimiento.Debito)
                .Sum(m => m.Monto);

            decimal saldo = totalCreditos - totalDebitos;

            return (totalCreditos, totalDebitos, saldo);
        }
        public Cliente ObtenerClientePorDNI(int dni)
        {
            return repositorio.ObtenerClientePorDNI(dni);
        }

    }
}
