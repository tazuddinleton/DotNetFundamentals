using EFCore.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DbSet<Person> People { get; }
    }
}
