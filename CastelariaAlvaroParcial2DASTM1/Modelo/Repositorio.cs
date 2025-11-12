using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Controladora
{
    public class Repositorio
    {
        private Context contexto;

        public Repositorio()
        {
            contexto = new Context();
        }
        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            return contexto.Clientes
                .Include(c => c.Cuentas)
                .ToList()
                .AsReadOnly();
        }

        public Cliente ObtenerClientePorDNI(int dni)
        {
            return contexto.Clientes
        .Include(c => c.Cuentas)
        .FirstOrDefault(c => c.DNI == dni);
        }

        public void AgregarCliente(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void ModificarCliente(Cliente cliente)
        {
            contexto.Clientes.Update(cliente);
            contexto.SaveChanges();
        }

        public void EliminarCliente(Cliente cliente)
        {
            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();
        }
        public CuentaCorriente ObtenerCuentaPorId(int id_cta)
        {
            return contexto.CuentasCorrientes
                .Include(c => c.Movimientos)
                .FirstOrDefault(c => c.id_cta == id_cta);
        }

        public IReadOnlyCollection<CuentaCorriente> ListarCuentas()
        {
            return contexto.CuentasCorrientes
                .Include(c => c.Cliente)
                .ToList()
                .AsReadOnly();
        }

        public void AgregarCuenta(CuentaCorriente cuenta)
        {
            contexto.CuentasCorrientes.Add(cuenta);
            contexto.SaveChanges();
        }
        public void AgregarMovimiento(Movimiento movimiento)
        {
            contexto.Movimientos.Add(movimiento);
            contexto.SaveChanges();
        }
        public IReadOnlyCollection<Movimiento> ListarMovimientosPorCuenta(int id_cta)
        {
            return contexto.Movimientos
        .Include(m => m.CuentaCorriente)
        .Where(m => m.id_cta == id_cta)
        .OrderBy(m => m.Fecha)
        .ToList()
        .AsReadOnly();
        }
        public int ObtenerUltimoNumeroCuenta()
        {
            return contexto.CuentasCorrientes.Any() ? contexto.CuentasCorrientes.Max(c => c.nro_cta) : 0;
        }
    }
}
