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

        }
    }
}
