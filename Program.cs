﻿/*C# Övningssamling - Inkapsling, arv och polymorfism*/
using ÖvningTre.Arv;
using ÖvningTre.Arv.Subclasses;
using ÖvningTre.Arv.Subclasses.SubclassBirds;
using ÖvningTre.Handlers;
using ÖvningTre.Inkapsling;
using ÖvningTre.Interfaces;
using ÖvningTre.Polymorfism;

//Inkapsling-delen
PersonHandler personHandler = new PersonHandler();
ICollection<Person> personer = new List<Person>();
Person subject1 = personHandler.CreatePerson(201, "Test", "Testsson", 200, 406);
Person subject2 = personHandler.CreatePerson(100, "Larry", "Loops", 200, 304);
Person subject3 = personHandler.CreatePerson(208, "Terry", "Terminal", 180, 100);
Person subject4 = personHandler.CreatePerson(26, "Sam", "Scripting", 180, 100);
Person subject5 = personHandler.CreatePerson(45, "Rick", "Router", 180, 100);
Person subject6 = personHandler.CreatePerson(65, "Harry", "Hard Drive", 180, 100);
Person subject7 = personHandler.CreatePerson(76, "Fred", "Firewall", 170, 90);
Person subject8 = personHandler.CreatePerson(87, "foo", "Fubar", 190, 70);
Person subject9 = personHandler.CreatePerson(14, "Vince", "Virtual", 346, 124);
personer.Add(subject1);
personer.Add(subject2);
personer.Add(subject3);
personer.Add(subject4);
personer.Add(subject5);
personer.Add(subject6);
personer.Add(subject7);
personer.Add(subject8);
personer.Add(subject9);
foreach (var item in personer)
{
    Console.WriteLine(
        $"Name: {item._fName} {item._lName}, Age: {item._age}, Height: {item._height} cm, Weight: {item._weight} kg");
}
Console.WriteLine("---");

personHandler.SetAge(subject9, 1);
personHandler.SetFName(subject9, "AAA");
personHandler.SetLname(subject9, "BBBB");
personHandler.SetHeight(subject9, 0);
personHandler.SetWeight(subject9, 0);
Console.WriteLine(
    $"Name: {subject9._fName} {subject9._lName}, Age: {subject9._age}, Height: {subject9._height} cm, Weight: {subject9._weight} kg");
Console.WriteLine("---");



// Person person = new Person
// {
//     _age = 0,
//     _fName = "test",
//     _lName = "test",
//     _height = 0,
//     _weight = 0,
//  
// };

//Polymorfism-delen
List<UserError> listOfErrors = new List<UserError>();
listOfErrors.Add(new NumericInputError());
listOfErrors.Add(new TextInputError());

listOfErrors.Add(new DateInputError());
listOfErrors.Add(new EmailInputError());
listOfErrors.Add(new SpecialInputError());

foreach (var item in listOfErrors)
{
    Console.WriteLine(item.UEMessage());
}
Console.WriteLine("---");

List<Animal> djur = new List<Animal>();
djur.Add(new Worm("mask", 25, 25, true));
djur.Add(new Dog("hund", 10, 7, false));
djur.Add(new Bird("AAAAAH", 25, 10, 25332));
djur.Add(new Wolfman("Ett", 125, 50, false));
foreach (var item in djur)
{
    if (item is IPerson person)
    {
       person.Talk();
    }
    Console.Write(item.Stats());
    item.DoSound();
    
}
Console.WriteLine("---");


//En lista för hundar
List<Dog> hundar = new List<Dog>();
//Detta funkar inte då häst är ett annat objekt. Det behöver vara en lista med animals då den är föräldern till dessa objekt
// hundar.Add(new Horse("hästen", 25, 25, "Mustang"));

List<Animal> allAnimals = new List<Animal>(); //För att kunna lagra alla klasser
//Skapa objekten och lägg dessa i listan
allAnimals.Add(new Wolfman("WOLFMAN", 0,0,false));
allAnimals.Add(new Worm("WORM", 0,0,false));
allAnimals.Add(new Wolf("WOLF",0,0,false));
allAnimals.Add(new Horse("HORSE",0,0,"something"));
allAnimals.Add(new Hedgehog("HEDGEHOG",0,0,true));
allAnimals.Add(new Dog("DOG",0,0,true));
allAnimals.Add(new Bird("BIRD",0,0,2359));
allAnimals.Add(new Swan("SWAN",0,0,599,true));
allAnimals.Add(new Pelican("PELICAN",0,0,125,true));
allAnimals.Add(new Flamingo("FLAMINGO",0,0,1,false));
//Kalla sedan på dess metod
foreach (var item in allAnimals) 
{
    Console.WriteLine(item.Stats());
    //Då de djuren inte har ärvt denna metod
    if (item is Dog thatDog)
    {
        Console.WriteLine($"\t{thatDog.DoSomething()}");
    }
}

Console.WriteLine("---");
var dogsOnly = allAnimals.OfType<Dog>();
foreach (var item in dogsOnly)
{
    Console.WriteLine(item.Stats());
}


Worm Testar = new Worm("UTAN", 35, 35, true);
Console.WriteLine("HÄR TESTAS MASKEN");
Console.WriteLine($"{Testar.StatsAnother()}");