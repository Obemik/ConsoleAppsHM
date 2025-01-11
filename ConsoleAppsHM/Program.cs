using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var array = new Array(numbers);

        array.Show();
        array.Show("Current array elements");
    }
}