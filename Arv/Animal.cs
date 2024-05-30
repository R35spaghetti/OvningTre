namespace ÖvningTre.Arv;

public abstract class Animal
{
    private string Name;
    private double Weight;
    private int Age;
    //Om alla djur behöver den nya egenskapen så läggs den här likt resterande egenskaper
    // private string Health;
    //
    // public string _Health
    // {
    //     get => Health;
    //     set => Health = value ?? throw new ArgumentNullException(nameof(value));
    // }


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
        // Health = health; och sen som parametervärde
    }
}