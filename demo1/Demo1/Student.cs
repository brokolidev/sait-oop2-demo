namespace Demo1;

public class Student
{
    private int Age { get; set; }
    private string Name { get; set; }
    private Semester CurrentSemester { get; set; }
    private Course CurrentCourse { get; set; }
    public List<Course> Courses;


    public void SetAge(int age)
    {
        this.Age = age;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }

    public void SetSemester(Semester semester)
    {
        this.CurrentSemester = semester;
    }

    public void SetCourse(Course course)
    {
        this.CurrentCourse = course;
    }

    public Student(int age, string name)
    {
        this.Age = age;
        this.Name = name;
        this.Courses = new List<Course>();
    }

    public enum Semester
    {
        First, Second, Third, Fourth
    }

    public override string ToString()
    {
        return $"Name is {this.Name}, {this.Age} years old.";
    }
    
}