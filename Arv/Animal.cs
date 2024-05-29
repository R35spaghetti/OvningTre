namespace ÖvningTre.Arv;

public abstract class Animal
{
    private string Name;
    private double Weight;
    private int Age;

    public abstract void DoSound();
    
    protected Animal(string name, double weight, int age)
    {
        Name = name;
        Weight = weight;
        Age = age;
    }
}