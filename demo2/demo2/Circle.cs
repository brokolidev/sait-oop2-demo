namespace demo2;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle()
    {
        this.Radius = 10;
    }
    
    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public Circle(double radius, string color, bool isFilled):base(color, isFilled)
    {
        this.Radius = radius;
    }
        
    public override double CalculateArea()
    {
        return Double.Pi * this.Radius * this.Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Double.Pi * this.Radius;
    }
    
    public override string ToString()
    {
        return $"Details of the circle: \n" +
               $"Color: {this.Color}\n" +
               $"Filling: {this.IsFilled}\n" +
               $"Radius: {this.Radius}";
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing {this.Color} of the " +
                          $"circle with {this.IsFilled} filling and " +
                          $"radius of {this.Radius}");
    }
}