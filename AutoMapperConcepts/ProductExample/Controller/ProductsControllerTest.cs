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
        public void RunTest()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDto>();
            });
            var productController = new ProductsController(config, new DbContext());

            var product_1 = productController.GetProduct(1);
            var product_2 = productController.GetProduct(2);
            var product_3 = productController.GetProduct(5);

        }

        public static void Main(string[] args)
        {
            var testRunner = new ProductsControllerTest();
            testRunner.RunTest();
        }

    }
}
