using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetConcepts
{
    public class Student
    {

        public Student(int id, string name, string email, DateTime admissionDate)
        {
            Id = id;
            Name = name;
            Email = email;
            AdmissionDate = admissionDate;
        }
        public Student(string name, string email, DateTime admissionDate)
        {            
            Name = name;
            Email = email;
            AdmissionDate = admissionDate;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime AdmissionDate { get; private set; }
    }
}
