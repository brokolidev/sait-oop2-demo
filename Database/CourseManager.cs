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
    }
}
