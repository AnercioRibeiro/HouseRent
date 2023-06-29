using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace HouseRent_API.Controllers
{
    [Route("api/Publication")]
    [ApiController]
    public class PublicationAPIController : ControllerBase
    {
       [HttpGet(Name ="GetPublications")]
       [ProducesResponseType(StatusCodes.Status200OK)]
       public ActionResult<IEnumerable<PublicationDto>> GetPublications() 
        {
            return Ok(PublicationStore.publicationList);
        }

        [HttpGet("{id:int}", Name = "GetPublication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PublicationDto> CreatePublication([FromBody] PublicationDto publicationDTO) 
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if (PublicationStore.publicationList.FirstOrDefault(x=>x.Name.ToLower() == publicationDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CreatePublicationCustomError", "Villa already Exists!");
                return BadRequest(ModelState);
            }
            if (publicationDTO == null)
            {
                return BadRequest(publicationDTO);
            }
            if (publicationDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            publicationDTO.Id = PublicationStore.publicationList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            PublicationStore.publicationList.Add(publicationDTO);
            return CreatedAtRoute("GetPublication", new {id = publicationDTO.Id }, publicationDTO);
        }

        [HttpDelete("{id:int}", Name = "DeletePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PublicationDto> DeletePublication(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var publication = PublicationStore.publicationList.FirstOrDefault(x => x.Id == id);
           
            if (publication == null)
            {
                return NotFound();
            }

            PublicationStore.publicationList.Remove(publication);
           
            return NoContent();
        }
        [HttpPut("{id:int}", Name = "UpdatePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePublication(int id, [FromBody] PublicationDto publicationDto)
        {
            if (publicationDto == null || id != publicationDto.Id)
            {
                return BadRequest();
            }
            var publication = PublicationStore.publicationList.FirstOrDefault(x => x.Id == id);

            if (publication == null)
            {
                return NotFound();
            }

            publication.Name = publicationDto.Name;
            publication.Address = publicationDto.Address;
            publication.Description = publicationDto.Description;
            publication.Details = publicationDto.Details;
            publication.Elevator = publicationDto.Elevator;
            publication.Floor = publicationDto.Floor;
            publication.Identifier = publicationDto.Identifier;
            publication.Latitude = publicationDto.Latitude;
            publication.Longitude = publicationDto.Longitude;
            publication.Municipalities = publicationDto.Municipalities;
            publication.PaymentPeriodicy = publicationDto.PaymentPeriodicy;
            publication.PictureUrl = publicationDto.PictureUrl;
            publication.Price = publicationDto.Price;
            publication.Tipology = publicationDto.Tipology;

            return NoContent();
        }
        
        [HttpPatch("{id:int}", Name = "UpdatePartialPublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialPublication(int id, JsonPatchDocument<PublicationDto> patchPublicationDto)
        {

            if (patchPublicationDto == null || id == 0)
            {
                return BadRequest();
            }
            var publication = PublicationStore.publicationList.FirstOrDefault(x => x.Id == id);
            if (publication == null)
            {
                return BadRequest();
            }
            patchPublicationDto.ApplyTo(publication, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
