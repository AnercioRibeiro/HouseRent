using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models
{
    public class Tenant
    {
        [Key]
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
