using System.Text;

namespace ÖvningTre.Arv.Subclasses.SubclassBirds;

public class Pelican : Bird
{
    private bool _openBeak;

    public bool OpenBeak
    {
        get => _openBeak;
        set => _openBeak = value;
    }

    public Pelican(string name, double weight, int age, int feathers, bool openBeak) : base(name, weight, age, feathers)
    {
        _openBeak = openBeak;
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