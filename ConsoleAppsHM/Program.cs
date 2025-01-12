using System;
using CreditCardApp;

namespace CreditCardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new CreditCard("1234567890123456", "John Doe", new DateTime(2025, 12, 31), "1234", 5000);

            card.AccountDeposited += amount => Console.WriteLine($"Account deposited with {amount}.");
            card.AccountSpent += amount => Console.WriteLine($"Spent {amount}.");
            card.CreditLimitUsed += () => Console.WriteLine("Credit limit reached.");
            card.PinChanged += () => Console.WriteLine("PIN has been changed.");

            Console.WriteLine("Depositing money...");
            card.Deposit(1000);

            Console.WriteLine("Spending money...");
            card.Spend(500);

            Console.WriteLine("Changing PIN...");
            card.ChangePin("5678");

            Console.WriteLine("Depositing more money...");
            card.Deposit(3000);
            card.Spend(4000);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}