using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class CourseManager
    {
        private string connectionString;

        // constructor with connection string
        public CourseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // create table using SQLite
        public void CreateTable()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = "CREATE TABLE Courses(CourseId INT primary key, Name VARCHAR(20), Credits INT)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // add course to the table
        public void AddCourse(Course course)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = "INSERT INTO Courses(CourseId, Name, Credits) VALUES (@CourseId, @Name, @Credits)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", course.CourseId);
                    command.Parameters.AddWithValue("@Name", course.Name);
                    command.Parameters.AddWithValue("@Credits", course.Credits);

                    command.ExecuteNonQuery();
                }
            }
        }

        // delete course from the table
        public void DeleteCourse(Course course)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = "DELETE FROM Courses WHERE CourseIdd=@CourseId";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", course.CourseId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // update course in the table
        public void UpdateStudent(Course course)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = "UPDATE Courses SET CourseId=@CourseId, Name=@Name, Credits=@Credits WHERE id=@Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", course.CourseId);
                    command.Parameters.AddWithValue("@Name", course.Name);
                    command.Parameters.AddWithValue("@Credits", course.Credits);

                    command.ExecuteNonQuery();
                }
            }
        }

        // get all courses from the table
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM Courses";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course()
                            {
                                CourseId = reader.GetInt32(1),
                                Name = reader.GetString(2),
                                Credits = reader.GetInt32(3),
                            });
                        }
                    }
                }
            }

            return courses;
        }
    }
}
