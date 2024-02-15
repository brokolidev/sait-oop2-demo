namespace demo3;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Name = "Happy";
        dog.Environment = "Any Env";

        // Method from abstract class
        dog.MakeSound();

        // Method from interfaces
        dog.Live();
        dog.Eat();

        Console.WriteLine(dog);

        dog.ChangeName("Sad");

        Console.WriteLine(dog);

        // Polymorphism works with abstract class 
        Animal animal = new Dog();

        // Polymorphism works with interfaces
        // In this case, habitat object can only call the methods within interface class itself.
        IHabitat habitat = new Dog();
        habitat.Live();
    }
}