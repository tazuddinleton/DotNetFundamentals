using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts
{
    public class ProductsControllerTest
    {
        public void Run()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>();
            });
            var productsController = new ProductsController(config, new DbContext());

            var product_1 = productsController.GetProduct(1);
            var product_2 = productsController.GetProduct(2);
            var product_3 = productsController.GetProduct(5);
        }

        public static void Main(string[] args)
        {
            var testRunner = new ProductsControllerTest();
            testRunner.Run();                
        }

    }
}
