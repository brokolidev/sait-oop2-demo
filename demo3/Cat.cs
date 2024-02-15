namespace demo3;

public class Cat: Animal
{
    public Cat()
    {}

    public override string ToString()
    {
        return $"The name of this cat is: {base.Name}";
    }

    public override void MakeSound()
    {
        throw new NotImplementedException();
    }
}