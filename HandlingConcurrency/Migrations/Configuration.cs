namespace HandlingConcurrency.Migrations
{
    using HandlingConcurrency.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HandlingConcurrency.Persistence.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HandlingConcurrency.Persistence.DatabaseContext context)
        {

            var departments = new List<Department>() {
            new Department()
            {
                Name = "Department 1",
                Budget = 1400,
                StartDate = DateTime.Now,
                InstructorID = null,
                Courses = new List<Course>()
            },
            new Department()
            {
                Name = "Department 2",
                Budget = 2400,
                StartDate = DateTime.Now.AddDays(9),
                InstructorID = null,
                Courses = new List<Course>()
            },
            new Department()
            {
                Name = "Department 3",
                Budget = 5400,
                StartDate = DateTime.Now.AddDays(10),
                InstructorID = null,
                Courses = new List<Course>()
            }
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
