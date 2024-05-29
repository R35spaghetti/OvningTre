namespace ÖvningTre.Arv.Subclasses.SubclassBirds;

public class Pelican : Bird
{
    private bool _openBeak;

    public bool OpenBeak
    {
        get => _openBeak;
        set => _openBeak = value;
    }

    public Pelican(string name, double weight, int age, int feathers,int eggs, bool openBeak) : base(name, weight, age, feathers, eggs)
    {
        _openBeak = openBeak;
    }
}