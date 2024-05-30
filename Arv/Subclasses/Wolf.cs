using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Wolf : Animal
{
    private bool _canSwim;

    public bool CanSwim
    {
        get => _canSwim;
        set => _canSwim = value;
    }

    public Wolf(string name, double weight, int age, bool canSwim) : base(name, weight, age)
    {
        _canSwim = canSwim;
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
        Console.WriteLine("voff");
    }
}