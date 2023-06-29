﻿using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models.Dto
{
    public class PublicationDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string PictureUrl { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        [MaxLength(30)]
        public string Tipology { get; set; }
        [Required]
        [MaxLength(10)]
        public string Floor { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Details { get; set; }
        public string PaymentPeriodicy { get; set; }
        public decimal Price { get; set; }
        [Required]
        [MaxLength(50)]
        public string Municipalities { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
