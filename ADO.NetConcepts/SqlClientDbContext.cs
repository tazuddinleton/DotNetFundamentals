using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO.NetConcepts
{
    public class SqlClientDbContext
    {
        private SqlConnection _conn;
        private SqlCommand _command;

        public SqlClientDbContext()
        {
            _conn = new SqlConnection("data source=DESKTOP-IG45RTH\\SQLEXPRESS; database=Sample; integrated security=SSPI");
            _command = new SqlCommand();
            _conn.Open();
            string createTable = @"
                                IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'Student')
                            BEGIN
                                CREATE TABLE Student(
                                Id INT NOT NULL IDENTITY(100, 1), 
                                Name VARCHAR(100) NOT NULL, Email VARCHAR(100), 
                                AdmissionDate VARCHAR(100))
                            END";
            _command.CommandText = createTable;
            _command.Connection = _conn;
            _command.ExecuteNonQuery();
            _conn.Close();
        }

        public SqlConnection Connection => _conn;
        public SqlCommand Command => _command;
    }
}
