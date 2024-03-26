using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class StudentManager
    {
        private string connectionString;

        public StudentManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM students";

                using(var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader()) 
                    { 
                        while (reader.Read())
                        {
                            students.Add(new Student()
                            {
                                Id = reader.GetInt32("Id"),
                                Name = reader.GetString("Name"),
                                Email = reader.GetString("Email"),
                                Address = reader.GetString("Address"),
                            });
                        }
                    }
                }
            }

            return students;
        }
    }
}
