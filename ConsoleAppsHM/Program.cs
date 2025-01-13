using System;

namespace BackpackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var backpack = new Backpack("Black", "Nike", "Nike Inc.", "Polyester", 1.2, 25);

                Console.WriteLine(backpack);

                backpack.AddItem("Laptop", 5);
                backpack.AddItem("Books", 10);
                backpack.AddItem("Water Bottle", 2);

                Console.WriteLine(backpack);

                backpack.AddItem("Tent", 20); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}