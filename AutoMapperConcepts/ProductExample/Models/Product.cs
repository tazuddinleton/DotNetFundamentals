namespace AutoMapperConcepts
{
    public class Product
    {
        public Product(int id, string name)
        {
            Id = id;
            ProductName = name;
            SetSupplier();
        }

        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public Supplier Supplier { get; set; }

        private void SetSupplier() {
            if (Id <= 3)
            {
                Supplier = new Supplier("Supplier 1", "Contact 1");
            }
            if (Id > 3)
            {
                Supplier = new Supplier("Supplier 2", "Contact 2");
            }
        }
    }
}