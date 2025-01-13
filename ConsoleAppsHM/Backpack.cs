using System;
using System.Collections.Generic;

namespace BackpackApp
{
    public class Backpack
    {
        public string Color { get; private set; }
        public string Brand { get; private set; }
        public string Manufacturer { get; private set; }
        public string Fabric { get; private set; }
        public double Weight { get; private set; }
        public double Volume { get; private set; }
        public List<(string Name, double ItemVolume)> Contents { get; private set; }

        private double CurrentVolume { get; set; }

        public delegate void ItemAddedEventHandler(string itemName, double itemVolume);
        public event ItemAddedEventHandler ItemAdded;

        public Backpack(string color, string brand, string manufacturer, string fabric, double weight, double volume)
        {
            Color = color;
            Brand = brand;
            Manufacturer = manufacturer;
            Fabric = fabric;
            Weight = weight;
            Volume = volume;
            Contents = new List<(string Name, double ItemVolume)>();
            CurrentVolume = 0;

            ItemAdded += delegate (string itemName, double itemVolume)
            {
                Console.WriteLine($"Item added: {itemName}, Volume: {itemVolume} liters.");
            };
        }

        public void AddItem(string itemName, double itemVolume)
        {
            if (itemVolume <= 0)
            {
                throw new ArgumentException("Item volume must be greater than zero.");
            }

            if (CurrentVolume + itemVolume > Volume)
            {
                throw new InvalidOperationException("Adding this item exceeds the backpack's capacity.");
            }

            Contents.Add((itemName, itemVolume));
            CurrentVolume += itemVolume;
            ItemAdded?.Invoke(itemName, itemVolume);
        }

        public override string ToString()
        {
            return $"Backpack Details:\n" +
                   $"- Color: {Color}\n" +
                   $"- Brand: {Brand}\n" +
                   $"- Manufacturer: {Manufacturer}\n" +
                   $"- Fabric: {Fabric}\n" +
                   $"- Weight: {Weight} kg\n" +
                   $"- Volume: {Volume} liters\n" +
                   $"- Current Load: {CurrentVolume} liters\n" +
                   $"- Contents: {string.Join(", ", Contents)}";
        }
    }
}
