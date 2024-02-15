namespace demo3_abstract;

public abstract class Shape
{
    public string Name { get; set; }
    
    public Shape()
    {}

    public abstract double Volume();
    public abstract double SurfaceArea();

    public virtual void ShapeInfo()
    {
        Console.WriteLine($"The name of the shape is: {Name}");
    }
}