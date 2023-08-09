﻿using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Province Province { get; set; }
        public int ProvinceId { get; set; }
    }
}
