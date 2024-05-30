using System.Text;
using ÖvningTre.Arv.Subclasses;
using ÖvningTre.Interfaces;

namespace ÖvningTre.Arv;

public class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, double weight, int age, bool canSwim) : base(name, weight, age, canSwim)
    {
    }

    public void Talk()
    {
        Console.WriteLine("Jag har både ett arv och ett kontrakt.");
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