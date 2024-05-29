namespace ÖvningTre.Arv.Subclasses.SubclassBirds;

public class Swan : Bird
{
    private bool _flying;

    public bool Flying
    {
        get => _flying;
        set => _flying = value;
    }

    public Swan(string name, double weight, int age, int feathers,int eggs, bool flying) : base(name, weight, age, feathers, eggs)
    {
        _flying = flying;
    }
}