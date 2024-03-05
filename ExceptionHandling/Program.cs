namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle();

            try
            {
                circle.Radius = -5;
            }
            finally
            {
                Console.WriteLine(circle);
            }



        }
    }
}
