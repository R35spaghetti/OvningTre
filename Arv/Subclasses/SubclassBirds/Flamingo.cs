namespace ÖvningTre.Arv.Subclasses.SubclassBirds;

public class Flamingo : Bird
{
    private bool _isPink;

    public bool isPink
    {
        get => _isPink;
        set => _isPink = value;
    }

    public Flamingo(string name, double weight, int age, int feathers, int eggs, bool isPink) : base(name, weight, age, feathers, eggs)
    {
        _isPink = isPink;
    }
}