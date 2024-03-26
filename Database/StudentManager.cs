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

        public void DeleteStudent(Student student)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "DELETE FROM students WHERE id=@Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "Update students SET name=@Name, email=@Email, address=@Address WHERE id=@Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Id", student.Id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddStudent(Student student)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "INSERT INTO students(name, email, address) VALUES (@Name, @Email, @Address)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Email", student.Email);

                    command.ExecuteNonQuery();
                }
            }
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
