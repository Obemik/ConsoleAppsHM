namespace WorkerNamespace
{
    public class President : Worker
    {
        public President(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"President: {Name} - Oversees the entire organization.");
        }
    }
}