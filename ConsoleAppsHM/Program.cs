using System;
using MoneyNamespace;

class Program
{
    static void Main()
    {
        Money productPrice = new Money(10, 50);
        Product product = new Product("Laptop", productPrice);

        product.DisplayProductInfo();

        Money discount = new Money(2, 50);
        product.ReducePrice(discount);

        Console.WriteLine("\nAfter discount:");
        product.DisplayProductInfo();
    }
}