namespace ÖvningTre.Arv;

public abstract class Animal
{
    private string Name;
    private double Weight;
    private int Age;
    
    public string _Name
    {
        get => Name;
        set => Name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double _Weight
    {
        get => Weight;
        set => Weight = value;
    }

    public int _Age
    {
        get => Age;
        set => Age = value;
    }

    

    public abstract void DoSound();
    
    protected Animal(string name, double weight, int age)
    {
        Name = name;
        Weight = weight;
        Age = age;
    }
}