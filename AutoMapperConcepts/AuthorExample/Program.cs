using AutoMapper;
using System;

namespace AutoMapperConcepts
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorDTO, Author>()
                .ForMember(d => d.Address, map => map.MapFrom(
                    s => new Address(s.City, s.State, s.Country)
                    ));
                });


            IMapper mapper = config.CreateMapper();
            var _source = new AuthorDTO() {
                Id = 1, 
                FirstName = "Taz",
                LastName = "Uddin",
                City = "Dhaka",
                State = "Uttara",
                Country= "BD"
            };

            var author = mapper.Map<Author>(_source);            
        }
    }
}
