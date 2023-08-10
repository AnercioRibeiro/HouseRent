using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Property")]
        public int PublicationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
