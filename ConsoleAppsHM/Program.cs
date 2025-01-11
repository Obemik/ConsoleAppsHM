class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 8, 4 };
        Array array = new Array(numbers);

        array.Show();
        array.Show("Array data");

        Console.WriteLine("Max: " + array.Max());
        Console.WriteLine("Min: " + array.Min());
        Console.WriteLine("Avg: " + array.Avg());
        Console.WriteLine("Search for 7: " + array.Search(7));
        Console.WriteLine("Search for 10: " + array.Search(10));
    }
}