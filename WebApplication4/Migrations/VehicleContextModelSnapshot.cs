﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcProject;

namespace MvcProject.Migrations
{
    [DbContext(typeof(VehicleContext))]
    partial class VehicleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcProject.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Content");

                    b.Property<string>("Image");

                    b.Property<string>("Make");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Model");

                    b.Property<string>("Title");

                    b.Property<string>("Year");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Category = "Sports Car", Image = "/Images/mclaren-570s-spider-design-edition.jpg", Make = "McLaren", Manufacturer = "McLaren Automotives", Model = "570 Spyder", Title = "MycLaren 570 Spyder", Year = "2015 - Present" },
                        new { ID = 2, Category = "Pick Up Truck", Image = "/Images/ram.jpg", Make = "Ram", Manufacturer = "Fiat Chrysler Automobiles", Model = "1500", Title = "Ram 1500", Year = "1981 - Present" },
                        new { ID = 3, Category = "Sports Car", Image = "/Images/mustang.jpg", Make = "Ford", Manufacturer = "Ford Motor Company", Model = "Mustang", Title = "Ford Mustang", Year = "1964 - Present" },
                        new { ID = 4, Category = " Muscle Car", Image = "/Images/camero.jpg", Make = "Chevrolet", Manufacturer = "General Motors", Model = "Camaro", Title = "Chevy Camaro", Year = "1966 - Present" },
                        new { ID = 5, Category = "90's Ricer Dream", Image = "/Images/prelude.jpg", Make = "Honda", Manufacturer = "Honda Motor Company Ltd.", Model = "Prelude", Title = "Honda Prelude", Year = "1978 - 2001" }
                    );
                });

            modelBuilder.Entity("MvcProject.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("Rating");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
