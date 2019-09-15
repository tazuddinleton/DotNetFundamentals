using AutoMapper;
using AutoMapperConcepts.ProductExample.Infrastructure;
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
            IMapper mapper = AutoMapperFactory.CreateMap();
            var productsController = new ProductsController(mapper, new DbContext());

            var product_1 = productsController.GetProduct(1);
            var product_2 = productsController.GetProduct(2);
            var product_3 = productsController.GetProduct(5);

            var order_1 = productsController.GetOrder(1);
            var order_2 = productsController.GetOrder(3);
            var order_3 = productsController.GetOrder(5);
        }

        public static void Main(string[] args)
        {
            var testRunner = new ProductsControllerTest();
            testRunner.Run();                
        }

    }
}
