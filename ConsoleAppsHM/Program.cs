using System;
using WorkerNamespace;

class Program
{
    static void Main()
    {
        Worker[] workers = {
            new President("Alice"),
            new Security("Bob"),
            new Manager("Charlie"),
            new Engineer("Diana")
        };

        foreach (var worker in workers)
        {
            worker.Print();
        }
    }
}