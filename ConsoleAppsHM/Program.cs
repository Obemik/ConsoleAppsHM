class Program
{
    static void Main(string[] args)
    {
        MyArray myArray = new MyArray(new int[] { 5, 2, 9, 1, 5, 6 });

        myArray.Show("My array");
        
        Console.WriteLine("Max: " + myArray.Max());
        Console.WriteLine("Min: " + myArray.Min());
        Console.WriteLine("Avg: " + myArray.Avg());

        Console.WriteLine("Search 5: " + myArray.Search(5));
        
        myArray.SortAsc();
        myArray.Show("Sorted Ascending");
        
        myArray.SortDesc();
        myArray.Show("Sorted Descending");

        myArray.SortByParam(true);
        myArray.Show("Sorted by Param Ascending");

        myArray.SortByParam(false);
        myArray.Show("Sorted by Param Descending");
    }
}