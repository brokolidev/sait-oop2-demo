namespace Demo1;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(20, "John");
        
        student1.Courses.Add(new Course(
            "Web Dev", "CPRG1234", 
            "Web Development and Basic HTML"));
        
        student1.Courses.Add(new Course(
            "DB", "CPRG2333", 
            "Database Basic"));

    }
}