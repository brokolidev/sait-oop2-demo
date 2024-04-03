using MySqlConnector;
using System.Data.Entity;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            CourseManager courseManager = 
                new CourseManager($"Data Source={path}/database.db; Version = 3; New = True; Compress = True;");

            
            // create Courses table, once created comment this line
            courseManager.CreateTable();
        }
    }
}
