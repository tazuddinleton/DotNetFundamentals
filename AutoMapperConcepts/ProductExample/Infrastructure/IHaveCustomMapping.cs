using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts.ProductExample.Infrastructure
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
