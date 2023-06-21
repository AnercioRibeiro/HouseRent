using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent_API.Controllers
{
    [Route("api/Publication")]
    [ApiController]
    public class PublicationAPIController : ControllerBase
    {
       [HttpGet]
       public IEnumerable<PublicationDto> GetPublications() 
        {
            return PublicationStore.publicationList;
        }

        [HttpGet("{id:int}")]
        public PublicationDto GetPublication(int id)
        {
            return PublicationStore.publicationList.FirstOrDefault(u=>u.Id==id);
        }
    }
}
