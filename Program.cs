/*C# Övningssamling - Inkapsling, arv och polymorfism*/

using ÖvningTre.Handlers;
using ÖvningTre.Inkapsling;

PersonHandler personHandler = new PersonHandler();
ICollection<Person> Personer = new List<Person>();
Person subject1 = personHandler.CreatePerson(201, "Test", "Testsson", 200, 406);
Person subject2 = personHandler.CreatePerson(100, "Larry", "Loops", 200, 304);
Person subject3 = personHandler.CreatePerson(208, "Terry", "Terminal", 180, 100);
Person subject4 = personHandler.CreatePerson(26, "Sam", "Scripting", 180, 100);
Person subject5 = personHandler.CreatePerson(45, "Rick", "Router", 180, 100);
Person subject6 = personHandler.CreatePerson(65, "Harry", "Hard Drive", 180, 100);
Person subject7 = personHandler.CreatePerson(76, "Fred", "Firewall", 170, 90);
Person subject8 = personHandler.CreatePerson(87, "foo", "Fubar", 190, 70);
Person subject9 = personHandler.CreatePerson(14, "Vince", "Virtual", 346, 124);
Personer.Add(subject1);
Personer.Add(subject2);
Personer.Add(subject3);
Personer.Add(subject4);
Personer.Add(subject5);
Personer.Add(subject6);
Personer.Add(subject7);
Personer.Add(subject8);
Personer.Add(subject9);
foreach (var item in Personer)
{
    Console.WriteLine(
        $"Name: {item._fName} {item._lName}, Age: {item._age}, Height: {item._height} cm, Weight: {item._weight} kg");
}


// Person person = new Person
// {
//     _age = 0,
//     _fName = "test",
//     _lName = "test",
//     _height = 0,
//     _weight = 0,
//  
// };