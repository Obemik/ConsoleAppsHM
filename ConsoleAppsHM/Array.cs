using System;

public class Array : IMath, IOutput
{
    private int[] _data;

    public Array(int[] data)
    {
        _data = data ?? throw new ArgumentNullException(nameof(data));
    }

    public void Show()
    {
        Console.WriteLine("Array elements: " + string.Join(", ", _data));
    }

    public void Show(string info)
    {
        Console.WriteLine(info + ": " + string.Join(", ", _data));
    }

    public int Max()
    {
        if (_data.Length == 0)
            throw new InvalidOperationException("Array is empty.");
        return System.Linq.Enumerable.Max(_data);
    }

    public int Min()
    {
        if (_data.Length == 0)
            throw new InvalidOperationException("Array is empty.");
        return System.Linq.Enumerable.Min(_data);
    }

    public float Avg()
    {
        if (_data.Length == 0)
            throw new InvalidOperationException("Array is empty.");
        return (float)System.Linq.Enumerable.Average(_data);
    }

    public bool Search(int valueToSearch)
    {
        return System.Array.Exists(_data, x => x == valueToSearch);
    }
}