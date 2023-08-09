using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        [MaxLength(30)]
        public string Tipology { get; set; }
        public string Floor { get; set; }
        public string PropertyType { get; set; }
        public string Division { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        public Province Province { get; set; }
        public int ProvinceId { get; set; }
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Details { get; set; }
        public decimal Price { get; set; }
    }
}
