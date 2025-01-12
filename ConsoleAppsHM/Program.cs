using System;
using ArrayManagement; 

class Program
{
    static void Main()
    {
        var intArray = new IntArray(new[] { 1, 2, 3, 4, 5, 6 });

        intArray.ShowEven();
        intArray.ShowOdd();
    }
}