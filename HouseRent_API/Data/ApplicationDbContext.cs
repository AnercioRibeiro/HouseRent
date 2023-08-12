using HouseRent_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRent_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<County> Counties { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Property>().HasData(
        //        new Property()
        //        {
        //            Id = 1,
        //            Address = "Projecto Nova vida",
        //            Description = "Apartamento T2",
        //            Elevator = false,
        //            Floor = "3º Andar",
        //            Latitude = "-8.8303705",
        //            Longitude = "13.2779031",
        //            Name = "",
        //            ImageUrl = "",
        //            PaymentPeriodicy = "Mensal",
        //            Price = 400000,
        //            Tipology = "T2",

        //        },
        //            new Property()
        //        {
        //                Id  = 2,
        //             Address = "Projecto Nova vida",
        //                Description = "Apartamento T2",
        //                Elevator = false,
        //                Floor = "3º Andar",
        //                Latitude = "-8.8303705",
        //                Longitude = "13.2779031",
        //                Name = "",
        //                ImageUrl = "",
        //                PaymentPeriodicy = "Mensal",
        //                Price = 400000,
        //                Tipology = "T2"
        //            },
        //                new Property()
        //                {
        //                    Id = 3,
        //                    Address = "Projecto Nova vida",
        //                    Description = "Apartamento T2",
        //                    Elevator = false,
        //                    Floor = "3º Andar",
        //                    Latitude = "-8.8303705",
        //                    Longitude = "13.2779031",
        //                    Name = "",
        //                    ImageUrl = "",
        //                    PaymentPeriodicy = "Mensal",
        //                    Price = 400000,
        //                    Tipology = "T2"
        //                },
        //                    new Property()
        //                    {
        //                        Id = 4,
        //                        Address = "Projecto Nova vida",
        //                        Description = "Apartamento T2",
        //                        Elevator = false,
        //                        Floor = "3º Andar",
        //                        Latitude = "-8.8303705",
        //                        Longitude = "13.2779031",
        //                        Name = "",
        //                        ImageUrl = "",
        //                        PaymentPeriodicy = "Mensal",
        //                        Price = 400000,
        //                        Tipology = "T2"
        //                    },
        //                        new Property()
        //                        {
        //                            Id = 5,
        //                            Address = "Projecto Nova vida",
        //                            Description = "Apartamento T2",
        //                            Elevator = false,
        //                            Floor = "3º Andar",
        //                            Latitude = "-8.8303705",
        //                            Longitude = "13.2779031",
        //                            Name = "",
        //                            ImageUrl = "",
        //                            PaymentPeriodicy = "Mensal",
        //                            Price = 400000,
        //                            Tipology = "T2"
        //                        },
        //                            new Property()
        //                            {
        //                                Id = 6,
        //                                Address = "Projecto Nova vida",
        //                                Description = "Apartamento T2",
        //                                Elevator = false,
        //                                Floor = "3º Andar",
        //                                Latitude = "-8.8303705",
        //                                Longitude = "13.2779031",
        //                                Name = "",
        //                                ImageUrl = "",
        //                                PaymentPeriodicy = "Mensal",
        //                                Price = 400000,
        //                                Tipology = "T2"
        //                            },
        //                                new Property()
        //                                {
        //                                    Id = 7,
        //                                    Address = "Projecto Nova vida",
        //                                    Description = "Apartamento T2",
        //                                    Elevator = false,
        //                                    Floor = "3º Andar",
        //                                    Latitude = "-8.8303705",
        //                                    Longitude = "13.2779031",
        //                                    Name = "",
        //                                    ImageUrl = "",
        //                                    PaymentPeriodicy = "Mensal",
        //                                    Price = 400000,
        //                                    Tipology = "T2"
        //                                },
        //                                    new Property()
        //                                    {
        //                                        Id = 8,
        //                                        Address = "Projecto Nova vida",
        //                                        Description = "Apartamento T2",
        //                                        Elevator = false,
        //                                        Floor = "3º Andar",
        //                                        Latitude = "-8.8303705",
        //                                        Longitude = "13.2779031",
        //                                        Name = "",
        //                                        ImageUrl = "",
        //                                        PaymentPeriodicy = "Mensal",
        //                                        Price = 400000,
        //                                        Tipology = "T2"
        //                                    }
        //        );
        //}
    }
}
