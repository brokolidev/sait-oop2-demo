namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle positiveCircle = new Circle(5);
                //Circle negativeCircle = new Circle(-5);
                Circle zeroCircle = new Circle(0);
            }
            finally
            {
                Console.WriteLine("Everything works fine.");
            }



        }
    }
}
