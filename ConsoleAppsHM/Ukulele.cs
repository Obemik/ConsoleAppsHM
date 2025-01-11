namespace MusicalInstrumentNamespace
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sound: Bright and cheerful strumming...");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele was developed in the 19th century in Hawaii.");
        }
    }
}