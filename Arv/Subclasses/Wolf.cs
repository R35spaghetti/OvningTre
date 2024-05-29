namespace ÖvningTre.Arv.Subclasses;

public class Wolf : Animal
{
    private bool canSwim;
    
    public Wolf(string name, double weight, int age, bool canSwim) : base(name, weight, age)
    {
        this.canSwim = canSwim;
    }

    public override void DoSound()
    {
        Console.WriteLine("voff");
    }
}