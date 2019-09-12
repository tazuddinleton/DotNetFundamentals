namespace AutoMapperConcepts
{
    public class ProductDto
    {
        public ProductDto() { }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierContact { get; set; }
    }
}