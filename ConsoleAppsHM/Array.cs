using System;

public class Array : IOutput
{
    private int[] _elements;

    public Array(int[] elements)
    {
        _elements = elements ?? throw new ArgumentNullException(nameof(elements), "Array cannot be null.");
    }

    public void Show()
    {
        Console.WriteLine(string.Join(", ", _elements));
    }

    public void Show(string info)
    {
        Console.WriteLine($"{info}: {string.Join(", ", _elements)}");
    }

    public int[] GetElements() => _elements;
}