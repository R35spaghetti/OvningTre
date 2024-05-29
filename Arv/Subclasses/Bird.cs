namespace ÖvningTre.Arv.Subclasses;

public class Bird : Animal
{
    private int _feathers;

    public int Feathers
    {
        get => _feathers;
        set => _feathers = value;
    }

    public Bird(string name, double weight, int age, int feathers) : base(name, weight, age)
    {
        _feathers = feathers;
    }

    public override void DoSound()
    {
        Console.WriteLine("Tweet!");
    }
}