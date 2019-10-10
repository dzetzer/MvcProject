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

            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    ID = 1,
                    Content = "This Car Is Super Fast",
                    Rating = 5,
                    UserName = "SpyderMan",
                    ProductID = 1
                },

                new Review()
                {
                    ID = 2,
                    Content = "Very Expensive",
                    Rating = 1,
                    UserName = "Janitor",
                    ProductID = 1
                },

                new Review()
                {
                    ID = 3,
                    Content = "Guts, Glory, Ram",
                    Rating = 3,
                    UserName = "Truck Fan",
                    ProductID = 2
                },

                new Review()
                {
                    ID = 4,
                    Content = "It's a good truck. Good gas mileage.",
                    Rating = 3,
                    UserName = "Tater.Mpeg",
                    ProductID = 2
                },

                new Review()
                {
                    ID = 5,
                    Content = "Unparralled Performace",
                    Rating = 4,
                    UserName = "Horse Breeder",
                    ProductID = 3
                },

                new Review()
                {
                    ID = 6,
                    Content = "Doesn't fit taller people.",
                    Rating = 2,
                    UserName = "Too Tall For Life",
                    ProductID = 3
                },

                new Review()
                {
                    ID = 7,
                    Content = "This car puts the thrill in every ride",
                    Rating = 4,
                    UserName = "Bumblebee",
                    ProductID = 4
                },


                new Review()
                {
                    ID = 8,
                    Content = "This car has transformed my life.",
                    Rating = 5,
                    UserName = "Optimus Prime",
                    ProductID = 4
                },

                new Review()
                {
                    ID = 9,
                    Content = "Sporty Coupe!",
                    Rating = 3,
                    UserName = "Father Time",
                    ProductID = 5
                },

                new Review()
                {
                    ID = 10,
                    Content = "This was my first car. It brings back memories.",
                    Rating = 5,
                    UserName = "Nostalgia",
                    ProductID = 5
                }
                );

            base.OnModelCreating(modelBuilder);
;                
        }
    }
}
