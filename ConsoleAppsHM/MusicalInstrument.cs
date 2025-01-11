namespace MusicalInstrumentNamespace
{
    public class MusicalInstrument
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public MusicalInstrument(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Default musical instrument sound.");
        }

        public void Show()
        {
            Console.WriteLine($"Instrument Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public virtual void History()
        {
            Console.WriteLine("This is a generic musical instrument.");
        }
    }
}