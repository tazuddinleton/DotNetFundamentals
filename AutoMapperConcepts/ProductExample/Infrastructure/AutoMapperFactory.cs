using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts.ProductExample.Infrastructure
{
    public static class AutoMapperFactory
    {
        public static IMapper CreateMap()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            return config.CreateMapper();
        }
    }
}
