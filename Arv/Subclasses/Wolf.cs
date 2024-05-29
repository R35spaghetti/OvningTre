namespace ÖvningTre.Arv.Subclasses;

public class Wolf : Animal
{
    private bool _canSwim;

    public bool CanSwim
    {
        get => _canSwim;
        set => _canSwim = value;
    }

    public Wolf(string name, double weight, int age, bool canSwim) : base(name, weight, age)
    {
        _canSwim = canSwim;
    }

    public override void DoSound()
    {
        Console.WriteLine("voff");
    }
}