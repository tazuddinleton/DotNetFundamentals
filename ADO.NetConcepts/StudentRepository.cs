using System;
using System.Collections.Generic;
using System.Linq;

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
                students.Add(StudentMapper.Map(result));
            }
            _db.Connection.Close();
            return students.FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            string selectStudents = $"SELECT * FROM Student";
            _db.Command.CommandText = selectStudents;
            _db.Connection.Open();
            var result = _db.Command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (result.Read())
            {
                var student = StudentMapper.Map(result);
                //var student_ = StudentMapper.Map<Student>(result);
                students.Add(student);
            }
            _db.Connection.Close();
            return students;
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
            throw new NotImplementedException();
        }
    }    
}