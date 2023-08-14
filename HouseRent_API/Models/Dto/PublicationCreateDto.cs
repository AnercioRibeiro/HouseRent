using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRent_API.Models.Dto
{
    public class PublicationCreateDto
    {

        public string Identifier { get; set; }
        public int PublicationId { get; set; }


    }
}
