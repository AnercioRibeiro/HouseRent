using System.ComponentModel.DataAnnotations;

namespace HouseRent_API.Models.Dto
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        Tenant Tenant { get; set; }
        public int TenantId { get; set; }
    }
}
