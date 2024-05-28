namespace ÖvningTre.Inkapsling;

public class Person
{
    private int age;
    private string fname;
    private string lname;
    private double height;
    private double weight;
    
    public int _age
    {
        get => age;
        set => age = value;
    }

    public string _fname
    {
        get => fname;
        set => fname = value ?? throw new ArgumentException(nameof(value));
    }

    public string _lname
    {
        get => lname;
        set => lname = value ?? throw new ArgumentException(nameof(value));
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