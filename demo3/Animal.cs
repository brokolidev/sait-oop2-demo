namespace demo3;

public abstract class Animal
{
    public string Name { get; set; }
    
    public Animal()
    {}

    public void ChangeName(string s)
    {
        Name = s;
    }

    public abstract void MakeSound();

    public override string ToString()
    {
        return $"The name of the animal is: {Name}";
    }
}

