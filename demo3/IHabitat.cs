namespace demo3;

public interface IHabitat
{
    // fields cannot be variable or instance members
    // string environment;

    string Environment { get; set; }
    void Live();
}