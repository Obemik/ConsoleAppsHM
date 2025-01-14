using System;

namespace BackpackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var backpack = new Backpack("Red", "BrandX", "ManufacturerY", "FabricA", 1.5, 10);

            backpack.ItemAdded += (sender, e) =>
            {
                Console.WriteLine($"Item added: {e.Item.Name}, Volume: {e.Item.Volume}");
            };

            try
            {
                backpack.AddItem(new BackpackItem("Laptop", 3));
                backpack.AddItem(new BackpackItem("Book", 1));
                backpack.AddItem(new BackpackItem("Water Bottle", 2));
                backpack.AddItem(new BackpackItem("Jacket", 4));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}