using Microsoft.EntityFrameworkCore;
using Pedidos_Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos_Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source = Data/Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 1, Descripcion = "Manzana", Costo = 55, Inventario = 57 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 2, Descripcion = "Cerveza", Costo = 30, Inventario = 53 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 3, Descripcion = "Leche", Costo = 45, Inventario = 30 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 4, Descripcion = "Pizza", Costo = 500, Inventario = 1 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 5, Descripcion = "Helado", Costo = 200, Inventario = 2 });


            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 1, Nombres = "Por Venir" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 2, Nombres = "Presidente" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 3, Nombres = "Nestle" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 4, Nombres = "Pizza Hut" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 5, Nombres = "Helados Bon" });

        }
    }
}