namespace ÖvningTre.Arv.Subclasses;

public class Horse : Animal
{
    private string race;
    
    public Horse(string name, double weight, int age, string race) : base(name, weight, age)
    {
        this.race = race;
    }

    public override void DoSound()
    {
        Console.WriteLine("*Neighs*");
    }
}