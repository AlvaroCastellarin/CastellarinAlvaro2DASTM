using Microsoft.EntityFrameworkCore;
using Entidades;




namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion = @"Data Source=ALVARO\SQLEXPRESS;Initial Catalog=CuentasCorrientes;Integrated Security=True;TrustServerCertificate=True;";
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.id_cli);

            modelBuilder.Entity<CuentaCorriente>()
                .HasKey(c => c.id_cta);

            modelBuilder.Entity<Movimiento>()
                .HasKey(m => m.id_mov);

            modelBuilder.Entity<CuentaCorriente>()
                .HasOne(c => c.Cliente) 
                .WithMany(cli => cli.Cuentas) 
                .HasForeignKey(c => c.id_cli)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Movimiento>()
                .HasOne(m => m.CuentaCorriente)
                .WithMany(c => c.Movimientos)
                .HasForeignKey(m => m.id_cta)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
