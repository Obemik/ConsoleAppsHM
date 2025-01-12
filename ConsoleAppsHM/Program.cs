using ArrayManagement;

class Program
{
    static void Main()
    {
        int[] elements = { 1, 5, 8, 3, 7, 2, 6 };
        var array = new MyArray(elements); 

        int lessCount = array.Less(5);
        int greaterCount = array.Greater(5);

        Console.WriteLine($"Number of elements less than 5: {lessCount}");
        Console.WriteLine($"Number of elements greater than 5: {greaterCount}");
    }
}