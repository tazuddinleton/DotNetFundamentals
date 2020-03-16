using HandlingConcurrency.Entities;
using HandlingConcurrency.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

            Department user1 = null;
            Department user2 = null;

            RunConcurrentUpdate();

            Console.ReadLine();
        }


        static void RunConcurrentUpdate()
        {
            Department user1 = null;
            Department user2 = null;

            using (var context = new DatabaseContext())
            {
                user1 = context.Departments.Find(2);

            }

            using (var context = new DatabaseContext())
            {
                user2 = context.Departments.Find(2);
            }

            using (var context = new DatabaseContext())
            {
                context.Departments.Attach(user1);
                user1.Budget = 10;
                context.SaveChanges();
            }

            using (var context = new DatabaseContext())
            {

                context.Departments.Attach(user2);
                user2.Budget = 200;

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    var entity = e.Entries.Single();
                    var original = (entity.OriginalValues["RowVersion"] as byte[]).ToInt32();
                    var current = (entity.GetDatabaseValues()["RowVersion"] as byte[]).ToInt32();

                    Console.WriteLine($"Update failed : databse: {current}, original: {original}" );
                }
            }
        }


        static void DisplayAll()
        {
            using (var context = new DatabaseContext())
            {
                context.Departments.ToList().ForEach(x =>
                {
                    Console.WriteLine($"Name: {x.Name}, Budget: {x.Budget}, Rowversion: {x.RowVersion.ToInt32()}");
                });
            }
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
