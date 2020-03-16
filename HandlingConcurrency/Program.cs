using HandlingConcurrency.Entities;
using HandlingConcurrency.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingConcurrency
{
    class Program
    {

        static void Main(string[] args)
        {
            Seed();
            
            var context = new DatabaseContext();
            context.Departments.ToList().ForEach(x =>
            {                
                Console.WriteLine($"Name: {x.Name}, Budget: {x.Budget}, Rowversion: {x.RowVersion.ToInt32()}");
            });

            Console.ReadLine();
        }



        static void Seed()
        {
            using (DatabaseContext context = new DatabaseContext())
            {

                if (context.Departments.Any())
                    return;

            var departments = new List<Department>() {
            new Department()
            {
                Name = "Department 1",
                Budget = 1400,
                StartDate = DateTime.Now
            },
            new Department()
            {
                Name = "Department 2",
                Budget = 2400,
                StartDate = DateTime.Now.AddDays(9)
            },
            new Department()
            {
                Name = "Department 3",
                Budget = 5400,
                StartDate = DateTime.Now.AddDays(10)
            }
            };
                context.Departments.AddRange(departments);
                context.SaveChanges();
            }
        }
    }
}
