namespace DeviceNamespace
{
    public class Device
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Default device sound.");
        }

        public void Show()
        {
            Console.WriteLine($"Device Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }
    }
}