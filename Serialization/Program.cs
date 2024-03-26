using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student s = new Student()
            {
                Name = "Hyunseung",
            };

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            Console.WriteLine(path);
            string binPath = path + "/student.bin";
            string jsonPath = path + "/student.json";

            //SerializeStudent(binPath, s);

            string serializedStudent = JsonSerializer.Serialize(s);
            File.WriteAllText(jsonPath, serializedStudent);

            var utf8Reader = new Utf8JsonReader();
            Student s2 = JsonSerializer.Deserialize<Student>(File.ReadAllText(jsonPath));

            Console.WriteLine(s2.Name);
        }

        public static void SerializeStudent(string path, Student s)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, s);
            }
            Console.WriteLine("Binary Serialization Completed");

        }

        //public static void JsonSerializeStudent(string path, Student s)
        //{
            
        //}
    }
}
