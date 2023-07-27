﻿using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models.Dto
{
    public class PublicationUpdateDto
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Tipology { get; set; }
        public string Floor { get; set; }
        public string Division { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Elevator { get; set; }
        public string Details { get; set; }
        public string PaymentPeriodicy { get; set; }
        public decimal Price { get; set; }
        public string Municipalities { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}