using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts.ProductExample.Entities
{
    public class Order
    {
        public Order() { }
        public Order(int id, string orderNo)
        {
            Id = id;
            OrderNo = orderNo;
        }
        public int Id { get; private set; }
        public string OrderNo { get; set; }
    }
}
