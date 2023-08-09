using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models
{
    public class Publication
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Identifier { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
        public List<Tenant> Tenant { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
