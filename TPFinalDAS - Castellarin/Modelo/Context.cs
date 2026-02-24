using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion =
            @"Data Source=ALVARO\SQLEXPRESS;Initial Catalog=TPVentasDB;Integrated Security=True;TrustServerCertificate=True;";

        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }
        public DbSet<Vendedor> Vendedores {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Minorista>("Minorista")
                .HasValue<Mayorista>("Mayorista");

            modelBuilder.Entity<MetodoPago>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Efectivo>("Efectivo")
                .HasValue<Tarjeta>("Tarjeta")
                .HasValue<Transferencia>("Transferencia");

            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasPrecision(18, 2);

            modelBuilder.Entity<DetalleVenta>()
                .Property(d => d.Precio_unitario)
                .HasPrecision(18, 2);

            modelBuilder.Entity<DetalleVenta>()
                .Property(d => d.Subtotal)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Tarjeta>()
                .Property(t => t.Interes)
                .HasPrecision(5, 2);

        }
       

    }
}
