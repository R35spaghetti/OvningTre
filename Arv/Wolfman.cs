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
}