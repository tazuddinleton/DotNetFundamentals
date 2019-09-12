using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO.NetConcepts
{
    public static class StudentMapper
    {
        public static Student Map(SqlDataReader row)
        {            
            return new Student((int)row["Id"], (string)row["Name"], (string)row["Email"], DateTime.Parse((string)row["AdmissionDate"]));
        }

        public static object Map<T>(SqlDataReader row)
        {
            throw new NotImplementedException();
            /*
            var obj = typeof(T);
            var props = obj.GetProperties();
            
            return null;
            */
        }
    }
}
