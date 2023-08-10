using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRent_API.Models
{
    public class County
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Province Province { get; set; }
        [ForeignKey("Province")]
        public int ProvinceId { get; set; }
    }
}
