using System.Runtime.Serialization.Formatters.Binary;

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

            SerializeStudent(binPath, s);
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
    }
}
