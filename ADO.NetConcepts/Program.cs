using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ADO.NetConcepts
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var studentRepository = new StudentRepository(new SqlClientDbContext());
            Student student = new Student("Student 1", "s1@email.com", DateTime.Now);
            studentRepository.Insert(student);

            var student_ = studentRepository.GetById(100);
            
        }
    }
}
