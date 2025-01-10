using System;
using StoreNamespace;

class Program
{
    static void Main()
    {
        var store1 = new Store();
        var store2 = new Store();

        store1.SetStoreData("Tech Store", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "contact@techstore.com");
        store2.SetStoreData("Book Haven", "456 Elm St, City", "A cozy bookstore with a variety of books.", "987-654-3210", "contact@bookhaven.com");

        store1 += 120.5;
        store2 += 85.0;

        Console.WriteLine("Store 1 Info:");
        Console.WriteLine(store1.GetStoreInfo());
        Console.WriteLine();

        Console.WriteLine("Store 2 Info:");
        Console.WriteLine(store2.GetStoreInfo());
        Console.WriteLine();

        Console.WriteLine("Comparison Results:");
        Console.WriteLine($"Store 1 == Store 2: {store1 == store2}");
        Console.WriteLine($"Store 1 != Store 2: {store1 != store2}");
        Console.WriteLine($"Store 1 > Store 2: {store1 > store2}");
        Console.WriteLine($"Store 1 < Store 2: {store1 < store2}");
        Console.WriteLine();

        store1 -= 20.5;
        Console.WriteLine("Store 1 Info After Area Reduction:");
        Console.WriteLine(store1.GetStoreInfo());
        Console.WriteLine();

        Console.WriteLine($"Store 1 Equals Store 2: {store1.Equals(store2)}");
    }
}