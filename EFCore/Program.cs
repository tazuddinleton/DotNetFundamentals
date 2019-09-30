using EFCore.Entities;
using EFCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {

            DataContext dataContext = new DataContext();

            dataContext.People.Add(new Person());



        }
    }
}
