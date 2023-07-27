using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseRent_API.Controllers
{
    [Route("api/Publication")]
    [ApiController]
    public class PublicationAPIController : ControllerBase
    {
        private readonly ILogger<PublicationAPIController> _logger;
        private readonly ApplicationDbContext _db;

        public PublicationAPIController(ILogger<PublicationAPIController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name ="GetPublications")]
       [ProducesResponseType(StatusCodes.Status200OK)]
       public ActionResult<IEnumerable<PublicationDto>> GetPublications() 
        {
            _logger.LogInformation("Getting all publications");
            return Ok(_db.Publications.ToList());
        }

        [HttpGet("{id:int}", Name = "GetPublication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PublicationDto> GetPublication(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Get publication Error with Id"+id);
                return BadRequest();
            }
            var publication = _db.Publications.FirstOrDefault(u => u.Id == id);
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
            if (_db.Publications.FirstOrDefault(x=>x.Name.ToLower() == publicationDTO.Name.ToLower()) != null)
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

            Publication model = new()
            {
            

       Name = publicationDTO.Name,
       Identifier = publicationDTO.Identifier,
       ImageUrl = publicationDTO.ImageUrl,
       Description = publicationDTO.Description,
       Address = publicationDTO.Address,

       Tipology = publicationDTO.Tipology,
       Floor = publicationDTO.Floor,
       Division = publicationDTO.Division,
       Latitude = publicationDTO.Latitude,
       Longitude = publicationDTO.Longitude,
       Elevator = publicationDTO.Elevator,
       Details = publicationDTO.Details,
       PaymentPeriodicy = publicationDTO.PaymentPeriodicy,
       Price = publicationDTO.Price,
       Municipalities = publicationDTO.Municipalities,
       CreatedDate = publicationDTO.CreatedDate,

    };
            _db.Publications.Add(model);
            _db.SaveChanges();
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
            var publication = _db.Publications.FirstOrDefault(x => x.Id == id);
           
            if (publication == null)
            {
                return NotFound();
            }

            _db.Publications.Remove(publication);
            _db.SaveChanges();
           
            return NoContent();
        }
        [HttpPut("{id:int}", Name = "UpdatePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePublication(int id, [FromBody] PublicationDto publicationDTO)
        {
            if (publicationDTO == null || id != publicationDTO.Id)
            {
                return BadRequest();
            }
            var publication = _db.Publications.FirstOrDefault(x => x.Id == id);

            if (publication == null)
            {
                return NotFound();
            }

            Publication model = new()
            {
                Name = publicationDTO.Name,
                Identifier = publicationDTO.Identifier,
                ImageUrl = publicationDTO.ImageUrl,
                Description = publicationDTO.Description,
                Address = publicationDTO.Address,
                Tipology = publicationDTO.Tipology,
                Floor = publicationDTO.Floor,
                Division = publicationDTO.Division,
                Latitude = publicationDTO.Latitude,
                Longitude = publicationDTO.Longitude,
                Elevator = publicationDTO.Elevator,
                Details = publicationDTO.Details,
                PaymentPeriodicy = publicationDTO.PaymentPeriodicy,
                Price = publicationDTO.Price,
                Municipalities = publicationDTO.Municipalities,
                CreatedDate = publicationDTO.CreatedDate

            };

            _db.Publications.Update(model);
            _db.SaveChanges();

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
            var publication = _db.Publications.AsNoTracking().FirstOrDefault(x => x.Id == id);
            PublicationDto publicationDto = new()
            {
                Id = publication.Id,
                Name = publication.Name,
                Identifier = publication.Identifier,
                ImageUrl = publication.ImageUrl,
                Description = publication.Description,
                Address = publication.Address,

                Tipology = publication.Tipology,
                Floor = publication.Floor,
                Division = publication.Division,
                Latitude = publication.Latitude,
                Longitude = publication.Longitude,
                Elevator = publication.Elevator,
                Details = publication.Details,
                PaymentPeriodicy = publication.PaymentPeriodicy,
                Price = publication.Price,
                Municipalities = publication.Municipalities,
                CreatedDate = publication.CreatedDate

            };
            if (publication == null)
            {
                return BadRequest();
            }
            patchPublicationDto.ApplyTo(publicationDto, ModelState);
            Publication model = new Publication()
            {
                Name = publicationDto.Name,
                Identifier = publicationDto.Identifier,
                ImageUrl = publicationDto.ImageUrl,
                Description = publicationDto.Description,
                Address = publicationDto.Address,
                Id = publicationDto.Id,
                Tipology = publicationDto.Tipology,
                Floor = publicationDto.Floor,
                Division = publicationDto.Division,
                Latitude = publicationDto.Latitude,
                Longitude = publicationDto.Longitude,
                Elevator = publicationDto.Elevator,
                Details = publicationDto.Details,
                PaymentPeriodicy = publicationDto.PaymentPeriodicy,
                Price = publicationDto.Price,
                Municipalities = publicationDto.Municipalities,
                CreatedDate = publicationDto.CreatedDate

            };
            _db.Publications.Update(model);
            _db.SaveChanges();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
