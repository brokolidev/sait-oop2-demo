using MySqlConnector;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder 
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Database = "oop2",
            };

            Console.WriteLine(builder);

            StudentManager studentManager = new StudentManager(builder.ConnectionString);
            List<Student> students = studentManager.GetAllStudents();

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Student newStudent = new Student
            {
                Name = "Matt Damon",
                Email = "matt@sait.ca",
                Address = "Address Matt Damon 1234",
            };

            //studentManager.AddStudent(newStudent);

            newStudent.Email = "matt@gmail.com";
            newStudent.Name = "Mat Daemon";
            newStudent.Address = "1234 Aspen Glan";
            newStudent.Id = 12;

            //studentManager.UpdateStudent(newStudent);


            studentManager.DeleteStudent(newStudent);
        }
    }
}
