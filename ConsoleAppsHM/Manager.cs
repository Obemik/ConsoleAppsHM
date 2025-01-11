namespace WorkerNamespace
{
    public class Manager : Worker
    {
        public Manager(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Manager: {Name} - Manages teams and projects.");
        }
    }
}