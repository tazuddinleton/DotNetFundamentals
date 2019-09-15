using AutoMapperConcepts.ProductExample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts.ProductExample.Entities
{
    public class OrderDto : IMapFrom<Order>
    {
        public OrderDto() { }

        public int Id { get; private set; }
        public string OrderNo { get; private set; }
    }
}
