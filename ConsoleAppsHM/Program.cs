using StoreNamespace;  

class Program
{
    static void Main()
    {
        var store = new Store();

        store.SetStoreData("Tech Store", "123 Main St, City", "A store selling electronics and gadgets.", "123-456-7890", "contact@techstore.com");

        Console.WriteLine(store.GetStoreInfo());
    }
}