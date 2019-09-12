namespace AutoMapperConcepts
{
    public class Supplier
    {
        public Supplier(string companyName, string contact)
        {
            CompanyName = companyName;
            Contact = contact;
        }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
    }
}