using ÖvningTre.Inkapsling;

namespace ÖvningTre.Handlers;

public class PersonHandler
{
    public Person CreatePerson(int age, string fname, string lname, double height, double weight)
    {
        Person person = new Person
        {
            _age = age,
            _fName = fname,
            _lName = lname,
            _height = height,
            _weight = weight,
        };
        return person;
    }

    public void SetAge(Person pers, int age)
    {
        pers._age = age;
    }

    public void SetFName(Person pers, string fname)
    {
        pers._fName = fname;
    }

    public void SetLname(Person pers, string lname)
    {
        pers._lName = lname;
    }

    public void SetHeight(Person pers, double height)
    {
        pers._height = height;
    }

    public void SetWeight(Person pers, double weight)
    {
        pers._height = weight;
    }
}