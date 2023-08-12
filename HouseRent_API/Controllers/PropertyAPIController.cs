using AutoMapper;
using HouseRent_API.Data;
using HouseRent_API.Models;
using HouseRent_API.Models.APIResponse;
using HouseRent_API.Models.Dto;
using HouseRent_API.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HouseRent_API.Controllers
{
    [Route("api/Property")]
    [ApiController]
    public class PropertyAPIController : ControllerBase
    {
        //private readonly ILogger<PublicationAPIController> _logger;
        private readonly IPropertyRepository _PropertyRepo;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        public PropertyAPIController(IPropertyRepository PropertyRepo, IMapper mapper)
        {
            //_logger = logger;
            _PropertyRepo = PropertyRepo;
            _mapper = mapper;
            this._response = new();
        }

        [HttpGet(Name = "GetProperties")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetAllProperties()
        {
            try
            {
                //_logger.LogInformation("Getting all publications");
                IEnumerable<Property> propertyList = await _PropertyRepo.GetAllAsync();
                _response.Result = _mapper.Map<List<PropertyDto>>(propertyList);
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

        [HttpGet("{id:int}", Name = "GetProperty")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetProperty(int id)
        {
            try
            {
                if (id == 0)
                {
                    //_logger.LogError("Get publication Error with Id"+id);
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var property = await _PropertyRepo.GetAsync(u => u.Id == id);
                if (property == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<PropertyDto>(property);
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
        public async Task<ActionResult<APIResponse>> CreateProperty([FromBody] PropertyCreateDto createDto)
        {
            try
            {

                if (await _PropertyRepo.GetAsync(x => x.Description.ToLower() == createDto.Description.ToLower()) != null)
                {
                    ModelState.AddModelError("CreatePropertyCustomError", "Property already Exists!");
                    return BadRequest(ModelState);
                }
                if (createDto == null)
                {
                    return BadRequest(createDto);
                }
                Property property = _mapper.Map<Property>(createDto);

                property.CreatedDate = DateTime.Now;
                await _PropertyRepo.CreateAsync(property);
                _response.Result = _mapper.Map<PropertyDto>(property);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetProperty", new { id = property.Id }, _response);
            }

            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString()
                };
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeleteProperty")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteProperty(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var publication = await _PropertyRepo.GetAsync(x => x.Id == id);

                if (publication == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                await _PropertyRepo.RemoveAsync(publication);
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
        [HttpPut("{id:int}", Name = "UpdateProperty")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> UpdateProperty(int id, [FromBody] PropertyUpdateDto updateDto)
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

                Property publication = _mapper.Map<Property>(updateDto);

                await _PropertyRepo.UpdateAsync(publication);
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

        [HttpPatch("{id:int}", Name = "UpdatePartialProperty")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdatePartialProperty(int id, JsonPatchDocument<PropertyUpdateDto> patchDto)
        {
            try
            {

                if (patchDto == null || id == 0)
                    _response.StatusCode = HttpStatusCode.BadRequest;
                {
                    return BadRequest(_response);
                }
                var property = await _PropertyRepo.GetAsync(x => x.Id == id, tracked: false);
                PropertyUpdateDto propertyDto = _mapper.Map<PropertyUpdateDto>(property);
                if (property == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                patchDto.ApplyTo(propertyDto, ModelState);
                Property model = _mapper.Map<Property>(propertyDto);

                await _PropertyRepo.UpdateAsync(model);

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
