using System.Text;

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
    
    
    public virtual string Stats()
    {
        var properties = GetType().GetProperties();
        var sb = new StringBuilder();

        foreach (var property in properties)
        {
            var value = property.GetValue(this).ToString() ?? "";
            sb.AppendLine($"{property.Name}: {value}");
        }

        return sb.ToString();
    }   
    public string StatsAnother()
    {
        var properties = GetType().GetProperties();
        var sb = new StringBuilder();

        foreach (var property in properties)
        {
            var value = property.GetValue(this).ToString() ?? "";
            sb.AppendLine($"{property.Name}: {value}");
        }

        return sb.ToString();
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