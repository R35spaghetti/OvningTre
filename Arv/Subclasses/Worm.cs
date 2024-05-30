using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Worm : Animal
{
    private bool _hasBazooka;

    public bool HasBazooka
    {
        get => _hasBazooka;
        set => _hasBazooka = value;
    }

    public Worm(string name, double weight, int age, bool hasBazooka) : base(name, weight, age)
    {
        _hasBazooka = hasBazooka;
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
        Console.WriteLine("Fire!");
    }
}