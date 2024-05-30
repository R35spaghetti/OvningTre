using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Hedgehog : Animal
{
    private bool _rolls;

    public bool Rolls
    {
        get => _rolls;
        set => _rolls = value;
    }

    public Hedgehog(string name, double weight, int age, bool rolls) : base(name, weight, age)
    {
        _rolls = rolls;
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
        Console.WriteLine("AAAAAAH");
    }
}