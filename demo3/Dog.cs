namespace demo3;

public class Dog: Animal, IHabitat, IFeedable
{
    public string Environment { get; set; }

    public Dog()
    {}

    public override string ToString()
    {
        return $"The name of this dog is: {base.Name}";
    }

    public override void MakeSound()
    {
        Console.WriteLine("A dog barks");
    }

    public void Eat()
    {
        Console.WriteLine("The dog like to eat meat");
    }

    public void Live()
    {
        Console.WriteLine("The dog lives in a shelter");
    }
}