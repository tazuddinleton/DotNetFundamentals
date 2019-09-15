using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperConcepts.ProductExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts
{
    public class ProductsController
    {
        IMapper _mapper;
        DbContext _dbContext;
        public ProductsController(IMapper mapper, DbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public ProductDto GetProduct(int id)
        {
            var dto = _dbContext.Products
                .Where(x => x.Id == id)
                .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                .SingleOrDefault();
            return dto;
        }

        public OrderDto GetOrder(int id)
        {
            var dto = _dbContext.Orders
                .Where(x => x.Id == id)
                .ProjectTo<OrderDto>(_mapper.ConfigurationProvider)
                .SingleOrDefault();
            return dto;
        }
    }
}
