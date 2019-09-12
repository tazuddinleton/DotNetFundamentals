using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConcepts
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Author() { }
        public Author(int id, string firstName, string lastName, Address address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
    }

    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Address() { }
        public Address(string city, string state, string country)
        {
            City = city;
            State = state;
            Country = country;
        }
    }
}
