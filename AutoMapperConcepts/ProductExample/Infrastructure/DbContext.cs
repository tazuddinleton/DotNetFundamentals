using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts
{
    public class DbContext
    {
        List<Product> _products;
        public DbContext() {
            _products = new List<Product>();
            _products.Add(new Product(1, "Product 1"));
            _products.Add(new Product(2, "Product 2"));
            _products.Add(new Product(3, "Product 3"));
            _products.Add(new Product(4, "Product 4"));
            _products.Add(new Product(5, "Product 5"));
        }

        public IQueryable<Product> Products => _products.AsQueryable();
    }
}
