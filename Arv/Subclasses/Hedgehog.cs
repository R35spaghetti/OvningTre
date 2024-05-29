namespace ÖvningTre.Arv.Subclasses;

public class Hedgehog : Animal
{
    private bool rolls;
    
    public Hedgehog(string name, double weight, int age, bool rolls) : base(name, weight, age)
    {
        this.rolls = rolls;
    }

    public override void DoSound()
    {
        Console.WriteLine("AAAAAAH");
    }
}