using System;
using System.Linq;

public class MyArray : IMath, IOutput, ISort
{
    private int[] _data;

    public MyArray(int[] data)
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
        return _data.Max();
    }

    public int Min()
    {
        if (_data.Length == 0)
            throw new InvalidOperationException("Array is empty.");
        return _data.Min();
    }

    public float Avg()
    {
        if (_data.Length == 0)
            throw new InvalidOperationException("Array is empty.");
        return (float)_data.Average();
    }

    public bool Search(int valueToSearch)
    {
        return _data.Contains(valueToSearch);
    }

    public void SortAsc()
    {
        Array.Sort(_data);
    }

    public void SortDesc()
    {
        Array.Sort(_data);
        Array.Reverse(_data);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }

    public int[] GetData()
    {
        return _data;
    }
}