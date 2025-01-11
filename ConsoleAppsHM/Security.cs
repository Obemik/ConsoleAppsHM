namespace WorkerNamespace
{
    public class Security : Worker
    {
        public Security(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Security: {Name} - Ensures safety and security at the workplace.");
        }
    }
}