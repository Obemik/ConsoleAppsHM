namespace DeviceNamespace
{
    public class Steamboat : Device
    {
        public Steamboat(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Steamboat sound: Toot toot...");
        }
    }
}