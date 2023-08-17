using AutoMapper;
using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Models.APIResponse;
using HouseRent_API.Models.Dto;
using HouseRent_API.Repository.IRepository;
using HouseRent_API.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace HouseRent_API.Controllers
{
    [Route("api/Publication")]
    [ApiController]
    public class PublicationAPIController : ControllerBase
    {
        //private readonly ILogger<PublicationAPIController> _logger;
        private readonly IPublicationRepository _PublicationRepo;
        public readonly IPublicationService _publicationService;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        public PublicationAPIController(IPublicationRepository PublicationRepo, IMapper mapper, IPublicationService publicationService)
        {
            //_logger = logger;
            _PublicationRepo = PublicationRepo;
            _mapper = mapper;
            this._response = new();
            _publicationService = publicationService;
        }

        [HttpGet(Name = "GetPublications")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllPublications()
         {
            List<PublicationDto> list = new();
          
                //_logger.LogInformation("Getting all publications");
                var response = await _publicationService.GetAllAsync<APIResponse>();
                if (response != null && response.IsSuccess)
                {
                    list = JsonConvert.DeserializeObject<List<PublicationDto>>(Convert.ToString(response.Result));
                }
                return Ok(list);
               
            
        }

        [HttpGet("{id:int}", Name = "GetPublication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetPublication(int id)
        {
            try
            {
                if (id == 0)
                {
                    //_logger.LogError("Get publication Error with Id"+id);
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var Publication = await _PublicationRepo.GetAsync(u => u.Id == id);
                if (Publication == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<PublicationDto>(Publication);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()
                };
            }
            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreatePublication([FromBody] PublicationCreateDto createDto)
        {
            try
            {

                if (await _PublicationRepo.GetAsync(x => x.Identifier.ToLower() == createDto.Identifier.ToLower()) != null)
                {
                    ModelState.AddModelError("CreatePublicationCustomError", "Publication already Exists!");
                    return BadRequest(ModelState);
                }
                if (createDto == null)
                {
                    return BadRequest(createDto);
                }
                Publication Publication = _mapper.Map<Publication>(createDto);

                Publication.CreatedDate = DateTime.Now;
                await _PublicationRepo.CreateAsync(Publication);
                _response.Result = _mapper.Map<PublicationDto>(Publication);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetPublication", new { id = Publication.Id }, _response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()
                };
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeletePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeletePublication(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var publication = await _PublicationRepo.GetAsync(x => x.Id == id);

                if (publication == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _PublicationRepo.RemoveAsync(publication);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()
                };
            }
            return _response;
        }
        [HttpPut("{id:int}", Name = "UpdatePublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> UpdatePublication(int id, [FromBody] PublicationUpdateDto updateDto)
        {
            try
            {
                if (updateDto == null || id != updateDto.Id)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                //var publication = _db.Publications.FirstOrDefault(x => x.Id == id);

                //if (publication == null)
                //{
                //    return NotFound();
                //}

                Publication publication = _mapper.Map<Publication>(updateDto);

                await _PublicationRepo.UpdateAsync(publication);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()
                };
            }
            return _response;
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialPublication")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdatePartialPublication(int id, JsonPatchDocument<PublicationUpdateDto> patchDto)
        {
            try
            {

                if (patchDto == null || id == 0)
                    _response.StatusCode = HttpStatusCode.BadRequest;
                {
                    return BadRequest(_response);
                }
                var Publication = await _PublicationRepo.GetAsync(x => x.Id == id, tracked: false);
                PublicationUpdateDto PublicationDto = _mapper.Map<PublicationUpdateDto>(Publication);
                if (Publication == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                patchDto.ApplyTo(PublicationDto, ModelState);
                Publication model = _mapper.Map<Publication>(PublicationDto);

                await _PublicationRepo.UpdateAsync(model);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()
                    };
            }
            return _response;
        }
    }
}
