// See https://aka.ms/new-console-template for more information

using System.IO.Compression;
using demo2;

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Shape();
        Console.WriteLine(shape1);
        
        Circle circle1 = new Circle();
        circle1.Draw();
        
        Circle circle2 = new Circle(20, "White", true);
        circle2.Draw();
        
        Console.WriteLine($"The area of the Circle is:" +
                          $" {circle1.CalculateArea()}");
        
        Shape morphedCircle = new Circle(1000);
        
        morphedCircle.Draw();
    }
}