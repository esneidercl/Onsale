using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext // para heredar, requiere importar 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)// metodo constructor ctro 2 veces tab, con parametro
        {
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)// para validar que no se repitan 2 paises
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()// referencia de la entidad a evaluar
                .HasIndex(t => t.Name) // crear un indice a la entidad por el campo nombre, la t es un objeto
                .IsUnique();// instruccion para hacer unico un campo
        }
    }
}
