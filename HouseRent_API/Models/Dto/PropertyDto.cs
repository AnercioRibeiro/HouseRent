using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRent_API.Models.Dto
{
    public class PropertyDto
    {

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Tipology { get; set; }
        public string Floor { get; set; }
        public string Division { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        public string PaymentPeriodicy { get; set; }
        public decimal Price { get; set; }
        public int OwnerId { get; set; }
        public int CountyId { get; set; }
        public int ProvinceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
