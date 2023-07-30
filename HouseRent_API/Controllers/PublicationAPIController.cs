using AutoMapper;
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
        private readonly IMapper _mapper;

        public PublicationAPIController(ILogger<PublicationAPIController> logger, ApplicationDbContext db, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            _mapper = mapper;
        }

        [HttpGet(Name ="GetPublications")]
       [ProducesResponseType(StatusCodes.Status200OK)]
       public async Task<ActionResult<IEnumerable<Publication>>> GetPublications() 
        {
            _logger.LogInformation("Getting all publications");
            IEnumerable<Publication> publicationList = await _db.Publications.ToListAsync();
            return Ok(_mapper.Map<List<PublicationDto>>(publicationList));
            
        }

        [HttpGet("{id:int}", Name = "GetPublication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PublicationDto>> GetPublication(int id)
        {
            if (id == 0)
            {
                _logger.LogError("Get publication Error with Id"+id);
                return BadRequest();
            }
            var publication =  await _db.Publications.FirstOrDefaultAsync(u => u.Id == id);
            if (publication == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PublicationDto>(publication));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PublicationDto>> CreatePublication([FromBody] PublicationCreateDto createDto) 
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if (await _db.Publications.FirstOrDefaultAsync(x=>x.Name.ToLower() == createDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CreatePublicationCustomError", "Villa already Exists!");
                return BadRequest(ModelState);
            }
            if (createDto == null)
            {
                return BadRequest(createDto);
            }
            Publication publication = _mapper.Map<Publication>(createDto);

    //   Publication model = new()
    //   {
        
    //   Name = createDto.Name,
    //   Identifier = createDto.Identifier,
    //   ImageUrl = createDto.ImageUrl,
    //   Description = createDto.Description,
    //   Address = createDto.Address,

    //   Tipology = createDto.Tipology,
    //   Floor = createDto.Floor,
    //   Division = createDto.Division,
    //   Latitude = createDto.Latitude,
    //   Longitude = createDto.Longitude,
    //   Elevator = createDto.Elevator,
    //   Details = createDto.Details,
    //   PaymentPeriodicy = createDto.PaymentPeriodicy,
    //   Price = createDto.Price,
    //   Municipalities = createDto.Municipalities,
    //   CreatedDate = createDto.CreatedDate,

    //};
            await _db.Publications.AddAsync(publication);
            await _db.SaveChangesAsync();
            return CreatedAtRoute("GetPublication", new {id = publication.Id }, publication);
        }

        [HttpDelete("{id:int}", Name = "DeletePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PublicationDto>> DeletePublication(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var publication = await _db.Publications.FirstOrDefaultAsync(x => x.Id == id);
           
            if (publication == null)
            {
                return NotFound();
            }

            _db.Publications.Remove(publication);
            await _db.SaveChangesAsync();
           
            return NoContent();
        }
        [HttpPut("{id:int}", Name = "UpdatePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePublication(int id, [FromBody] PublicationUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.Id)
            {
                return BadRequest();
            }
            //var publication = _db.Publications.FirstOrDefault(x => x.Id == id);

            //if (publication == null)
            //{
            //    return NotFound();
            //}

            Publication publication = _mapper.Map<Publication>(updateDto);

            _db.Publications.Update(publication);
            await _db.SaveChangesAsync();

            return NoContent();
        }
        
        [HttpPatch("{id:int}", Name = "UpdatePartialPublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialPublication(int id, JsonPatchDocument<PublicationUpdateDto> patchDto)
        {

            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }
            var publication = await _db.Publications.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            PublicationUpdateDto publicationDto = _mapper.Map<PublicationUpdateDto>(publication);
            if (publication == null)
            {
                return BadRequest();
            }
            patchDto.ApplyTo(publicationDto, ModelState);
            Publication model = _mapper.Map<Publication>(publicationDto);
   
            _db.Publications.Update(model);
            await _db.SaveChangesAsync();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
