namespace Demo1;

public class Course
{
    public string Name { get; set; }
    public string CourseID { get; set; }
    public string Description { get; set; }

    public Course(string name, string id, string desc)
    {
        this.Name = name;
        this.CourseID = id;
        this.Description = desc;
    }

    public override string ToString()
    {
        return $"Course Name : {this.Name} \n" + 
               $"Course ID : {this.CourseID} \n" +
               $"Details : {this.Description}";
    }
}