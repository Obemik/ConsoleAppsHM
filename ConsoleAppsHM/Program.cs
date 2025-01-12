using System;
using CreditCardExample;

class Program
{
    static void Main()
    {
        try
        {
            var card = new CreditCard("1234567890123456", "John Doe", "123", new DateTime(2025, 12, 31), 1000m);

            Console.WriteLine("Initial card details:");
            Console.WriteLine(card.ToString());

            card = card + 500m;
            Console.WriteLine("\nAfter deposit of 500:");
            Console.WriteLine(card.ToString());

            card = card - 200m;
            Console.WriteLine("\nAfter withdrawal of 200:");
            Console.WriteLine(card.ToString());

            var card2 = new CreditCard("9876543210987654", "Jane Doe", "123", new DateTime(2025, 12, 31), 2000m);
            Console.WriteLine($"\nAre CVCs equal? {card == card2}");

            Console.WriteLine($"Is card1 balance greater than card2? {card > card2}");
            Console.WriteLine($"Is card1 balance less than card2? {card < card2}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}