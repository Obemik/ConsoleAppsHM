using System;
using CreditCardExample;

class Program
{
    static void Main()
    {
        try
        {
            var card = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2025, 12, 31));

            Console.WriteLine(card.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}