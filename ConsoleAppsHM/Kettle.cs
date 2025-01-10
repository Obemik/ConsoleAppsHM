namespace DeviceNamespace
{
    public class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Kettle sound: Whistling...");
        }
    }
}