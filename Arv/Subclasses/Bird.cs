using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Bird : Animal
{
    //Om fåglarna behöver ett nytt attribut
    // [Display(Name = "Amount of eggs")] 
    // private int _eggs;
    private int _feathers;

    // public int Eggs
    // {
    //     get => _eggs;
    //     set => _eggs = value;
    // }

    public int Feathers
    {
        get => _feathers;
        set => _feathers = value;
    }
    //här läggs eggs, ser dylikt ut hos dess barn också
    public Bird(string name, double weight, int age, int feathers) : base(name, weight, age)
    {
        _feathers = feathers;
        //_eggs = eggs;
    }
    public override string Stats()
    {
        var baseProperties = base.Stats();
        var childProperties = GetType().GetProperties().Where(x => !baseProperties.Contains(x.Name));
        var sb = new StringBuilder(baseProperties);

        foreach (var property in childProperties)
        {
            var value = property.GetValue(this).ToString() ?? "";
            sb.AppendLine($" {property.Name}: {value}");
        }

        return sb.ToString();
    }
    public override void DoSound()
    {
        Console.WriteLine("Tweet!");
    }
}