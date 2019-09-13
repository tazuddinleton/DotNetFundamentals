using AutoMapper;
using AutoMapperConcepts.ProductExample.Infrastructure;

namespace AutoMapperConcepts
{
    public class ProductDto : IHaveCustomMapping
    {
        public ProductDto() { }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Product, ProductDto>()
                .ForMember(pDto => pDto.SupplierContact, opt => opt.MapFrom(p => p.Supplier != null ? p.Supplier.Contact : string.Empty))
                .ForMember(pDto => pDto.SupplierName, opt => opt.MapFrom(p => p.Supplier != null ? p.Supplier.CompanyName : string.Empty));
        }
    }
}