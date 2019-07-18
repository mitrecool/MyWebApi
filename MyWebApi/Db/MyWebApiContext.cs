using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using System;

namespace MyWebApi.Db
{
    public class MyWebApiContext : DbContext
    {
        public const int MaxTopCount = 50;

        public DbSet<Good> Goods { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public MyWebApiContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()                
                .HasIndex(b => b.Name)
                .ForSqlServerInclude("Description", "Price");

            modelBuilder.Entity<Good>()
                .HasIndex(g => g.Name)
                .ForSqlServerInclude("Description", "Price");

            modelBuilder.Entity<Pet>().HasData(
                new Pet() { PetId = Guid.NewGuid(), Name = "Cat", Description = "Cute cat", Price = 111.0m },
                new Pet() { PetId = Guid.NewGuid(), Name = "Dog", Description = "Good boy", Price = 111.0m }
            );

            modelBuilder.Entity<Good>().HasData(
                new Good() { GoodId = Guid.NewGuid(), Name = "Soccer ball", Description = "New soccer ball", Price = 111.0m },
                new Good() { GoodId = Guid.NewGuid(), Name = "Foot ball", Description = "New foot ball", Price = 221.0m }
            );
        }
    }
}
