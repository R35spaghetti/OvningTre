﻿using System.Text;

namespace ÖvningTre.Arv.Subclasses;

public class Horse : Animal
{
    private string _race;

    public string Race
    {
        get => _race;
        set => _race = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Horse(string name, double weight, int age, string race) : base(name, weight, age)
    {
        _race = race;
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