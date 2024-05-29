using System.ComponentModel.DataAnnotations;

namespace ÖvningTre.Arv.Subclasses;

public class Bird : Animal
{
    //Om fåglarna behöver ett nytt attribut
    [Display(Name = "Amount of eggs")] 
    private int _eggs;
    private int _feathers;

    public int Eggs
    {
        get => _eggs;
        set => _eggs = value;
    }

    public int Feathers
    {
        get => _feathers;
        set => _feathers = value;
    }

    public Bird(string name, double weight, int age, int feathers, int eggs) : base(name, weight, age)
    {
        _feathers = feathers;
        _eggs = eggs;
    }

    public override void DoSound()
    {
        Console.WriteLine("Tweet!");
    }
}