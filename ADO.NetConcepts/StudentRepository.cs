using System;
using System.Collections.Generic;

namespace ADO.NetConcepts
{


    public class StudentRepository
    {

        private SqlClientDbContext _db;

        public StudentRepository(SqlClientDbContext sqlClientDb)
        {
            _db = sqlClientDb;
        }
        
        public Student GetById(int id)
        {
            string selectStudents = $"SELECT * FROM Student WHERE Id = {id}";
            _db.Command.CommandText = selectStudents;
            _db.Connection.Open();
            var result = _db.Command.ExecuteReader();
            
            List<Student> students = new List<Student>();
            while (result.Read())
            {

                students.Add(new Student((int)result["Id"], (string)result["Name"], (string)result["Email"], DateTime.Parse((string)result["AdmissionDate"])));
            }
            _db.Connection.Close();
            return students[0];
        }

        public List<Student> GetStudents()
        {
            return new List<Student>();
        }

        public void Insert(Student student)
        {
            string insertIntoTable = $"INSERT INTO Student VALUES('{student.Name}', '{student.Email}', '{student.AdmissionDate}')";
            _db.Command.CommandText = insertIntoTable;
            _db.Connection.Open();
            _db.Command.ExecuteNonQuery();
            _db.Connection.Close();
        }

        public void Delete(int id)
        {

        }
    }

    
}