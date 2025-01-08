using System;
class Program
{
    static void Main()
    {
        var arrayFilter = new ArrayFilter();
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        
        int[] result = arrayFilter.FilterArray(originalArray, filterArray);
        
        Console.WriteLine("Filtered Array: " + string.Join(", ", result));
    }
}