using AutoMapper;
using HouseRent_API.Models;
using HouseRent_API.Models.Dto;

namespace HouseRent_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Property, PublicationDto>();
            CreateMap<PublicationDto, Property>();

            CreateMap<Property, PublicationCreateDto>().ReverseMap();
            CreateMap<Property, PublicationUpdateDto>().ReverseMap();
            //;            CreateMap<Publication, PublicationCreateDto>();
            //            CreateMap<Publication, PublicationUpdateDto>();

        }
    }
}
