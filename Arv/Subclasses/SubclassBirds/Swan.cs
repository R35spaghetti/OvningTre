using System.Text;

namespace ÖvningTre.Arv.Subclasses.SubclassBirds;

public class Swan : Bird
{
    private bool _flying;

    public bool Flying
    {
        get => _flying;
        set => _flying = value;
    }

    public Swan(string name, double weight, int age, int feathers, bool flying) : base(name, weight, age, feathers)
    {
        _flying = flying;
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