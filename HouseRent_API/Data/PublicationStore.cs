using HouseRent_API.Models.Dto;

namespace HouseRent_API.Data
{
    public static class PublicationStore
    {
        public static List<PublicationDto> publicationList = new List<PublicationDto>{
        
                new PublicationDto
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
                     PictureUrl = "",
                     PaymentPeriodicy = "Mensal",
                     Price = 400000,
                     Tipology = "T2"
                },
                new PublicationDto
                {
                     Id = 2,
                     Address = "Morro Bento",
                     Municipalities = "Samba",
                     Description = "Vivenda T2",
                     Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                     Elevator = false,
                     Floor = "3º Andar",
                     Identifier = "1235",
                     Latitude = "-8.8303705",
                     Longitude = "13.2779031",
                     Name = "",
                     PictureUrl = "",
                     PaymentPeriodicy = "Mensal",
                     Price = 400000,
                     Tipology = "T2"
                },
                new PublicationDto
                {
                    Id = 3,
                    Address = "Benfica",
                    Municipalities = "Belas",
                    Description = "Vivenda T2",
                    Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                    Elevator = false,
                    Floor = "3º Andar",
                    Identifier = "1235",
                    Latitude = "-8.8303705",
                    Longitude = "13.2779031",
                    Name = "",
                    PictureUrl = "",
                    PaymentPeriodicy = "Mensal",
                    Price = 400000,
                    Tipology = "T2"
                }
        };
    }
}
