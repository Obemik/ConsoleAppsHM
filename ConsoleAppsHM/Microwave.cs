namespace DeviceNamespace
{
    public class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Microwave sound: Beep beep...");
        }
    }
}