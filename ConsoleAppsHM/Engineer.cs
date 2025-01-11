namespace WorkerNamespace
{
    public class Engineer : Worker
    {
        public Engineer(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Engineer: {Name} - Designs, develops, and maintains systems.");
        }
    }
}