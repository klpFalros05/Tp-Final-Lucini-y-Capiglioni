using Entidades;
using Microsoft.EntityFrameworkCore;


namespace Modelo
{
    public class ContextoVentas : DbContext
    {
        private string conexion = "Data Source=LAPTOP-IQ1OBU3N\\SQLEXPRESS;Initial Catalog=TpFinalLuciniCapiglioni;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Minorista> Minoristas { get; set; }
        public DbSet<Mayorista> Mayoristas { get; set; }

        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Venta - Vendedor
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Vendedor)
                .WithMany()                 // si después ponemos la List<Venta> en Vendedor, acá va .WithMany(x => x.Ventas)
                .HasForeignKey(v => v.VendedorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Venta - Sucursal
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Sucursal)
                .WithMany()
                .HasForeignKey(v => v.SucursalId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
