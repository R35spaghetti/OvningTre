using System.Text;

namespace ÖvningTre.Arv.Subclasses.SubclassBirds;

public class Flamingo : Bird
{
    private bool _isPink;

    public bool isPink
    {
        get => _isPink;
        set => _isPink = value;
    }

    public Flamingo(string name, double weight, int age, int feathers, int eggs, bool isPink) : base(name, weight, age, feathers, eggs)
    {
        _isPink = isPink;
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
}