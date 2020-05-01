using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingConfig
    {
        public static IMapper Mapper { get; private set; }

        public static void Initialize()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Customer, CustomerDto>();
                x.CreateMap<CustomerDto, Customer>().ForMember(m => m.ID, o => o.Ignore());
                x.CreateMap<Movie, MovieDto>();
                x.CreateMap<MovieDto, Movie>().ForMember(m => m.ID, o => o.Ignore());
            });

            Mapper = config.CreateMapper();
        }
    }
}