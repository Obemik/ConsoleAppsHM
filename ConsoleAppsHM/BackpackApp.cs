using System;
using System.Collections.Generic;

public class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Manufacturer { get; set; }
    public string Fabric { get; set; }
    public double Weight { get; set; }
    public double Capacity { get; set; } 
    public List<BackpackItem> Contents { get; set; }

    public event EventHandler<ItemAddedEventArgs> ItemAdded;

    public Backpack(string color, string brand, string manufacturer, string fabric, double weight, double capacity)
    {
        Color = color;
        Brand = brand;
        Manufacturer = manufacturer;
        Fabric = fabric;
        Weight = weight;
        Capacity = capacity;
        Contents = new List<BackpackItem>();
    }

    public void AddItem(BackpackItem item)
    {
        if (item.Volume + GetTotalVolume() > Capacity)
        {
            throw new InvalidOperationException("Not enough capacity in the backpack.");
        }

        Contents.Add(item);
        OnItemAdded(new ItemAddedEventArgs(item));
    }

    private double GetTotalVolume()
    {
        double totalVolume = 0;
        foreach (var item in Contents)
        {
            totalVolume += item.Volume;
        }
        return totalVolume;
    }

    protected virtual void OnItemAdded(ItemAddedEventArgs e)
    {
        ItemAdded?.Invoke(this, e);
    }
}

public class BackpackItem
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public BackpackItem(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}

public class ItemAddedEventArgs : EventArgs
{
    public BackpackItem Item { get; }

    public ItemAddedEventArgs(BackpackItem item)
    {
        Item = item;
    }
}
