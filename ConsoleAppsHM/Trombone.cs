namespace MusicalInstrumentNamespace
{
    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Trombone sound: Powerful brass tones...");
        }

        public override void History()
        {
            Console.WriteLine("The trombone has its origins in the 15th century as a sackbut.");
        }
    }
}