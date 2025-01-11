namespace WorkerNamespace
{
    public abstract class Worker
    {
        public string Name { get; private set; }

        public Worker(string name)
        {
            Name = name;
        }

        public abstract void Print();
    }
}