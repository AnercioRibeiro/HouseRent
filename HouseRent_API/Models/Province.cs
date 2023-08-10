using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
