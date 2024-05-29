namespace ÖvningTre.Arv.Subclasses;

public class Bird : Animal
{
    private int feathers;

    public Bird(string name, double weight, int age, int feathers) : base(name, weight, age)
    {
        this.feathers = this.feathers;
    }

    public override void DoSound()
    {
        Console.WriteLine("Tweet!");
    }
}