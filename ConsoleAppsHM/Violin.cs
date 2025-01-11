namespace MusicalInstrumentNamespace
{
    public class Violin : MusicalInstrument
    {
        public Violin(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Violin sound: Melodious string music...");
        }

        public override void History()
        {
            Console.WriteLine("The violin originated in the 16th century in Italy.");
        }
    }
}