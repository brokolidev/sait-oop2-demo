namespace demo3_abstract;

public class Cube : Shape
{
    public double Length { get; set; }

    public Cube(double length, string name)
    {
        this.Length = length;
        Name = name;
    }

    public override double Volume()
    {
        throw new NotImplementedException();
    }

    public override double SurfaceArea()
    {
        throw new NotImplementedException();
    }
}