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

            
            // Drop table before anything starts
            courseManager.DropTable();

            // create Courses table, once created comment this line
            courseManager.CreateTable();

            // insert data into Courses table
            courseManager.AddCourse(new Course { CourseId = 1001, Name = "Fundamentals of Web Development", Credits = 3 });
            courseManager.AddCourse(new Course { CourseId = 1002, Name = "Introduction to Full Stack Programming", Credits = 3 });
            courseManager.AddCourse(new Course { CourseId = 1003, Name = "Databases", Credits = 3 });
            courseManager.AddCourse(new Course { CourseId = 1004, Name = "Principles of Software Design and Analysis", Credits = 4 });
            courseManager.AddCourse(new Course { CourseId = 1005, Name = "Objected-Oriented Programming", Credits = 4 });

            List<Course> courses = courseManager.GetAllCourses();

            foreach (var item in courses)
            {
                Console.WriteLine(item);
            }
        }
    }
}
