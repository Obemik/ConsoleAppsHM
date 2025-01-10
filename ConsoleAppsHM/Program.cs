using System;
using PassportSystem;

class Program
{
    static void Main()
    {
        var passport = new Passport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1));
        Console.WriteLine(passport.GetInfo());

        var foreignPassport = new ForeignPassport("John Doe", "AB1234567", "CountryX", new DateTime(1990, 1, 1), new DateTime(2030, 1, 1), "FP9876543");
        foreignPassport.AddVisa("USA");
        foreignPassport.AddVisa("Canada");
        Console.WriteLine(foreignPassport.GetInfo());

        foreignPassport.RemoveVisa("USA");
        Console.WriteLine(foreignPassport.GetInfo());
    }
}