namespace ÖvningTre.Arv.Subclasses;

public class Worm : Animal
{
    private bool _hasBazooka;

    public bool HasBazooka
    {
        get => _hasBazooka;
        set => _hasBazooka = value;
    }

    public Worm(string name, double weight, int age, bool hasBazooka) : base(name, weight, age)
    {
        _hasBazooka = hasBazooka;
    }

    public override void DoSound()
    {
        Console.WriteLine("Fire!");
    }
}