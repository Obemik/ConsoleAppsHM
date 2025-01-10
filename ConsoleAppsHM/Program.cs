using System;
using AnimalKingdom;

class Program
{
    static void Main()
    {
        var tiger = new Tiger("Bengal Tiger", "Forests", "Carnivore", "Orange with Black Stripes");
        Console.WriteLine(tiger.GetDescription());
        Console.WriteLine(tiger.Roar());

        var crocodile = new Crocodile("Nile Crocodile", "Rivers and Swamps", "Carnivore", 5.5);
        Console.WriteLine(crocodile.GetDescription());
        Console.WriteLine(crocodile.Swim());

        var kangaroo = new Kangaroo("Red Kangaroo", "Grasslands", "Herbivore", 3.0);
        Console.WriteLine(kangaroo.GetDescription());
        Console.WriteLine(kangaroo.Jump());
    }
}