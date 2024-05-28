namespace ÖvningTre.Inkapsling;

public class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    public int _age
    {
        get => age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age is less than 0");
            }
        }
    }

    public required string _fName
    {
        get => fName;
        set
        {
            if (value.Length is < 2 or > 10)
            {
                throw new ArgumentException("First name must be between 2 and 10 characters long");
            }

            fName = value;
        }
    }

    public required string _lName
    {
        get => lName;
        set
        {
            if (value.Length is < 3 or > 15)
            {
                throw new ArgumentException("Last name must be between 3 and 15 characters long");
            }

            lName = value;
        }
    }

    public double _height
    {
        get => height;
        set => height = value;
    }

    public double _weight
    {
        get => weight;
        set => weight = value;
    }
}