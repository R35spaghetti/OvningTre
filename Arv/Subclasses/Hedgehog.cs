namespace ÖvningTre.Arv.Subclasses;

public class Hedgehog : Animal
{
    private bool _rolls;

    public bool Rolls
    {
        get => _rolls;
        set => _rolls = value;
    }

    public Hedgehog(string name, double weight, int age, bool rolls) : base(name, weight, age)
    {
        _rolls = rolls;
    }

    public override void DoSound()
    {
        Console.WriteLine("AAAAAAH");
    }
}