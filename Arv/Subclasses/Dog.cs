namespace ÖvningTre.Arv.Subclasses;

public class Dog : Animal
{
    private bool sleeps;
    
    public Dog(string name, double weight, int age, bool sleeps) : base(name, weight, age)
    {
        this.sleeps = sleeps;
    }

    public override void DoSound()
    {
        Console.WriteLine("*barks*");
    }
}