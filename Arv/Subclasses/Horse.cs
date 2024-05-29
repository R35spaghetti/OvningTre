namespace ÖvningTre.Arv.Subclasses;

public class Horse : Animal
{
    private string _race;

    public string Race
    {
        get => _race;
        set => _race = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Horse(string name, double weight, int age, string race) : base(name, weight, age)
    {
        _race = race;
    }

    public override void DoSound()
    {
        Console.WriteLine("*Neighs*");
    }
}