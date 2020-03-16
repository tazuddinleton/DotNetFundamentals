using HandlingConcurrency.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingConcurrency.Persistence
{
    public class DatabaseContext : DbContext
    {
        private static string connString = @"Server=DESKTOP-O2E45CT;Database=Concurrency;Trusted_Connection=True;user id=sa;password=1234;";
        public DbSet<Department> Departments { get; set; }

        public DatabaseContext():base(connString)
        {   
        }
        public DatabaseContext(string connString):base(connString)
        {            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DatabaseContext).Assembly);            
        }
    }
}
