namespace MoneyNamespace
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ReducePrice(Money reductionAmount)
        {
            Price = Price - reductionAmount;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {Name}");
            Console.Write("Price: ");
            Price.DisplayAmount();
        }
    }
}