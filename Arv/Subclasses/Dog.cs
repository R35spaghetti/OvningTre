namespace ÖvningTre.Arv.Subclasses;

public class Dog : Animal
{
    private bool _sleeps;

    public bool Sleeps
    {
        get => _sleeps;
        set => _sleeps = value;
    }

    public Dog(string name, double weight, int age, bool sleeps) : base(name, weight, age)
    {
        _sleeps = sleeps;
    }

    public override void DoSound()
    {
        Console.WriteLine("*barks*");
    }
}