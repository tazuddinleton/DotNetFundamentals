using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts
{
    public class ProductsController
    {
        MapperConfiguration _config;
        DbContext _dbContext;
        public ProductsController(MapperConfiguration config, DbContext dbContext)
        {
            _config = config;
            _dbContext = dbContext;
        }

        public ProductDto GetProduct(int id)
        {
            var dto = _dbContext.Products.Where(x => x.Id == id).ProjectTo<ProductDto>(_config)
                 .SingleOrDefault();
            return dto;
        }
    }
}
