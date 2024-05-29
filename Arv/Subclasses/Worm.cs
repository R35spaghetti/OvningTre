namespace ÖvningTre.Arv.Subclasses;

public class Worm : Animal
{
    private bool hasBazooka;
    
    public Worm(string name, double weight, int age, bool hasBazooka) : base(name, weight, age)
    {
        this.hasBazooka = this.hasBazooka;
    }

    public override void DoSound()
    {
        Console.WriteLine("Fire!");
    }
}