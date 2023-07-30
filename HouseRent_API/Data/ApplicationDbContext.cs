using HouseRent_API.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRent_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Publication> Publications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publication>().HasData(
                new Publication()
                {
                    Id = 1,
                    Address = "Projecto Nova vida",
                    Municipalities = "Kilamba Kiaxi",
                    Description = "Apartamento T2",
                    Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                    Elevator = false,
                    Floor = "3º Andar",
                    Identifier = "1234",
                    Latitude = "-8.8303705",
                    Longitude = "13.2779031",
                    Name = "",
                    ImageUrl = "",
                    PaymentPeriodicy = "Mensal",
                    Price = 400000,
                    Tipology = "T2",
                    
                },
                    new Publication()
                {
                        Id  = 2,
                     Address = "Projecto Nova vida",
                        Municipalities = "Kilamba Kiaxi",
                        Description = "Apartamento T2",
                        Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                        Elevator = false,
                        Floor = "3º Andar",
                        Identifier = "1234",
                        Latitude = "-8.8303705",
                        Longitude = "13.2779031",
                        Name = "",
                        ImageUrl = "",
                        PaymentPeriodicy = "Mensal",
                        Price = 400000,
                        Tipology = "T2"
                    },
                        new Publication()
                        {
                            Id = 3,
                            Address = "Projecto Nova vida",
                            Municipalities = "Kilamba Kiaxi",
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Name = "",
                            ImageUrl = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000,
                            Tipology = "T2"
                        },
                            new Publication()
                            {
                                Id = 4,
                                Address = "Projecto Nova vida",
                                Municipalities = "Kilamba Kiaxi",
                                Description = "Apartamento T2",
                                Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                                Elevator = false,
                                Floor = "3º Andar",
                                Identifier = "1234",
                                Latitude = "-8.8303705",
                                Longitude = "13.2779031",
                                Name = "",
                                ImageUrl = "",
                                PaymentPeriodicy = "Mensal",
                                Price = 400000,
                                Tipology = "T2"
                            },
                                new Publication()
                                {
                                    Id = 5,
                                    Address = "Projecto Nova vida",
                                    Municipalities = "Kilamba Kiaxi",
                                    Description = "Apartamento T2",
                                    Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                                    Elevator = false,
                                    Floor = "3º Andar",
                                    Identifier = "1234",
                                    Latitude = "-8.8303705",
                                    Longitude = "13.2779031",
                                    Name = "",
                                    ImageUrl = "",
                                    PaymentPeriodicy = "Mensal",
                                    Price = 400000,
                                    Tipology = "T2"
                                },
                                    new Publication()
                                    {
                                        Id = 6,
                                        Address = "Projecto Nova vida",
                                        Municipalities = "Kilamba Kiaxi",
                                        Description = "Apartamento T2",
                                        Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                                        Elevator = false,
                                        Floor = "3º Andar",
                                        Identifier = "1234",
                                        Latitude = "-8.8303705",
                                        Longitude = "13.2779031",
                                        Name = "",
                                        ImageUrl = "",
                                        PaymentPeriodicy = "Mensal",
                                        Price = 400000,
                                        Tipology = "T2"
                                    },
                                        new Publication()
                                        {
                                            Id = 7,
                                            Address = "Projecto Nova vida",
                                            Municipalities = "Kilamba Kiaxi",
                                            Description = "Apartamento T2",
                                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                                            Elevator = false,
                                            Floor = "3º Andar",
                                            Identifier = "1234",
                                            Latitude = "-8.8303705",
                                            Longitude = "13.2779031",
                                            Name = "",
                                            ImageUrl = "",
                                            PaymentPeriodicy = "Mensal",
                                            Price = 400000,
                                            Tipology = "T2"
                                        },
                                            new Publication()
                                            {
                                                Id = 8,
                                                Address = "Projecto Nova vida",
                                                Municipalities = "Kilamba Kiaxi",
                                                Description = "Apartamento T2",
                                                Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                                                Elevator = false,
                                                Floor = "3º Andar",
                                                Identifier = "1234",
                                                Latitude = "-8.8303705",
                                                Longitude = "13.2779031",
                                                Name = "",
                                                ImageUrl = "",
                                                PaymentPeriodicy = "Mensal",
                                                Price = 400000,
                                                Tipology = "T2"
                                            }
                );
        }
    }
}
