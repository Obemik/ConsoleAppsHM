namespace MusicalInstrumentNamespace
{
    public class Cello : MusicalInstrument
    {
        public Cello(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Cello sound: Deep and resonant tones...");
        }

        public override void History()
        {
            Console.WriteLine("The cello was developed in the 16th century in Italy.");
        }
    }
}