namespace demo2;

public class Shape
{
    protected string Color { get; set; }
    protected bool IsFilled { get; set; }

    public Shape()
    {
        this.Color = "Magenta";
        this.IsFilled = false;
    }

    public Shape(string color, bool isFilled)
    {
        this.Color = color;
        this.IsFilled = isFilled;
    }

    public void ChangeColor(string c)
    {
        this.Color = c;
    }

    public virtual double CalculateArea()
    {
        return 0.0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0.0;
    }

    public override string ToString()
    {
        return $"Details of the shape: \n" +
               $"Color: {this.Color}\n" +
               $"Filling: {this.IsFilled}";
    }

    public virtual void Draw()
    {
        Console.WriteLine($"Drawing {this.Color} of the shape with {this.IsFilled}");
    }
}