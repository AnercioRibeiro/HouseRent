﻿using AutoMapper;
using HouseRent_API.Models;
using HouseRent_API.Models.Dto;

namespace HouseRent_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Property, PropertyDto>();
            CreateMap<PropertyDto, Property>();

            CreateMap<Property, PropertyCreateDto>().ReverseMap();
            CreateMap<Property, PropertyUpdateDto>().ReverseMap();
            //;            CreateMap<Publication, PublicationCreateDto>();
            //            CreateMap<Publication, PublicationUpdateDto>();

        }
    }
}