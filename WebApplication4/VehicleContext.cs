using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject
{
    public class VehicleContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=VehicleReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ID = 1,
                    Image = "/Images/mclaren-570s-spider-design-edition.jpg",
                    Title = "MycLaren 570 Spyder",
                    Category = "Sports Car",
                    Manufacturer = "McLaren Automotives",
                    Make = "McLaren",
                    Model = "570 Spyder",
                    Year = "2015 - Present",
                },
                
                new Product()
                {
                    ID = 2,
                    Image = "/Images/ram.jpg",
                    Title = "Ram 1500",
                    Category = "Pick Up Truck",
                    Manufacturer = "Fiat Chrysler Automobiles",
                    Make = "Ram",
                    Model = "1500",
                    Year = "1981 - Present",
                },

                new Product()
                {
                    ID = 3,
                    Image = "/Images/mustang.jpg",
                    Title = "Ford Mustang",
                    Category = "Sports Car",
                    Manufacturer = "Ford Motor Company",
                    Make = "Ford",
                    Model = "Mustang",
                    Year = "1964 - Present",
                },

                new Product()
                {
                    ID = 4,
                    Image = "/Images/camero.jpg",
                    Title = "Chevy Camaro",
                    Category = " Muscle Car",
                    Manufacturer = "General Motors",
                    Make = "Chevrolet",
                    Model = "Camaro",
                    Year = "1966 - Present",
                },

                new Product()
                {
                    ID = 5,
                    Image = "/Images/prelude.jpg",
                    Title = "Honda Prelude",
                    Category = "90's Ricer Dream",
                    Manufacturer = "Honda Motor Company Ltd.",
                    Make = "Honda",
                    Model = "Prelude",
                    Year = "1978 - 2001",
                }
                );
                
        }
    }
}
