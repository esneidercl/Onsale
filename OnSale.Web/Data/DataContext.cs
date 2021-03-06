﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;
using OnSale.Web.Data.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : IdentityDbContext<User> // para heredar, requiere importar 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)// metodo constructor ctro 2 veces tab, con parametro
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)// para validar que no se repitan 2 paises
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
          .HasIndex(t => t.Name)
          .IsUnique();

            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(t => t.Name)
                .IsUnique();

        }
    }
}
