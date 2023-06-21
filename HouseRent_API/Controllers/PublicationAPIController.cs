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
       public ActionResult<IEnumerable<PublicationDto>> GetPublications() 
        {
            return Ok(PublicationStore.publicationList);
        }

        [HttpGet("{id:int}")]
        public ActionResult<PublicationDto> GetPublication(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var publication = PublicationStore.publicationList.FirstOrDefault(u => u.Id == id);
            if (publication == null)
            {
                return NotFound();
            }
            return Ok(publication);
        }
    }
}
