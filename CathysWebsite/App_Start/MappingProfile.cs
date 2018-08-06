using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using CathysWebsite.Models;
using CathysWebsite.Dtos;

namespace CathysWebsite.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Review, ReviewDto>();

            Mapper.CreateMap<ReviewDto, Review>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}