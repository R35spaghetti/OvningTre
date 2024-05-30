using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Horse : Animal
{
    private string _breed;

    public string Breed
    {
        get => _breed;
        set => _breed = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Horse(string name, double weight, int age, string breed) : base(name, weight, age)
    {
        _breed = breed;
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
        Console.WriteLine("*Neighs*");
    }
}