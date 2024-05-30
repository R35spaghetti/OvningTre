using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Dog : Animal
{
    private bool _sleeps;

    public bool Sleeps
    {
        get => _sleeps;
        set => _sleeps = value;
    }

    public Dog(string name, double weight, int age, bool sleeps) : base(name, weight, age)
    {
        _sleeps = sleeps;
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
        Console.WriteLine("*barks*");
    }
}