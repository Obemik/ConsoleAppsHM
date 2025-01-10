namespace DeviceNamespace
{
    public class Car : Device
    {
        public Car(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Car sound: Vroom vroom...");
        }
    }
}