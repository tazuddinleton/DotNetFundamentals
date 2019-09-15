using AutoMapperConcepts.ProductExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts
{
    public class DbContext
    {
        private List<Product> _products;
        private List<Order> _orders;

        public DbContext()
        {
            _products = new List<Product>();
            _products.Add(new Product(1, "Product 1"));
            _products.Add(new Product(2, "Product 2"));
            _products.Add(new Product(3, "Product 3"));
            _products.Add(new Product(4, "Product 4"));
            _products.Add(new Product(5, "Product 5"));

            _orders = new List<Order>();
            _orders.Add(new Order(1, "Order 1"));
            _orders.Add(new Order(2, "Order 2"));
            _orders.Add(new Order(3, "Order 3"));
            _orders.Add(new Order(4, "Order 4"));
            _orders.Add(new Order(5, "Order 5"));

        }

        public IQueryable<Product> Products => _products.AsQueryable();
        public IQueryable<Order> Orders => _orders.AsQueryable();
    }
}
