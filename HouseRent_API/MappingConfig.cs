using AutoMapper;
using HouseRent_API.Models;
using HouseRent_API.Models.Dto;

namespace HouseRent_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Publication, PublicationDto>();
            CreateMap<PublicationDto, Publication>();

            CreateMap<Publication, PublicationCreateDto>().ReverseMap();
            CreateMap<Publication, PublicationUpdateDto>().ReverseMap();
            //;            CreateMap<Publication, PublicationCreateDto>();
            //            CreateMap<Publication, PublicationUpdateDto>();

        }
    }
}
