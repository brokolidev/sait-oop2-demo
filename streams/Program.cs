using System.Text;

namespace streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            const string PATH = "C:\\dev\\dotnet\\oop2\\demos\\streams\\res\\textfile.txt";

            WriteToTextFile(PATH);
            ReadFromFile(PATH);

            // print out apsolute path of raw directory
            WriteToBinFile(PATH);
            ReadFromBinFile(PATH);

            // using FileStream
            ReadWithFileStream(PATH);
            WriteWithSeek(PATH);

        }

        private static void WriteToTextFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("This is C# class");
                writer.WriteLine("writing something in a file.");
                writer.WriteLine(211);
            }
        }

        private static void ReadFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                string remainLines = reader.ReadToEnd();

                Console.WriteLine("Printing using Stream Reader");
                Console.WriteLine(line);
                Console.WriteLine(remainLines);
            }
        }

        private static void WriteToBinFile(string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(211); // int
                writer.Write(20.5); // double 
                writer.Write("This is CPRG 211"); // string 
            }
        }

        private static void ReadFromBinFile(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int i = reader.ReadInt32();
                double d = reader.ReadDouble();
                string s = reader.ReadString();

                Console.WriteLine("\n Reading from binary Files");
                Console.WriteLine(i);
                Console.WriteLine(d);
                Console.WriteLine(s);
            }
        }

        // using filestream
        // this is completcated compare to using StreamWriter and StreamReader
        // but it is fater than those two
        private static void ReadWithFileStream(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                int bytesRead = fileStream.Read(buffer, 0, buffer.Length);

                while(bytesRead > 0)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                }
            }
        }

        // using seek
        private static void WriteWithSeek(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fileStream.Seek(10, SeekOrigin.Begin);

                byte[] buffer = Encoding.UTF8.GetBytes("Today is the day. Hello World.");

                fileStream.Write(buffer, 0, buffer.Length);
            }
        }

    }
}
