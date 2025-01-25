using System;
using System.Collections.Generic;

public abstract class Employee
{
    protected Employee _next;

    public void SetNext(Employee next)
    {
        _next = next;
    }

    public abstract void HandleTask(string task, int priority);
}

public class Intern : Employee
{
    public override void HandleTask(string task, int priority)
    {
        if (priority <= 2)
        {
            Console.WriteLine($"Intern handles task: {task}");
        }
        else if (_next != null)
        {
            _next.HandleTask(task, priority);
        }
        else
        {
            Console.WriteLine($"Task '{task}' cannot be handled!");
        }
    }
}

public class Manager : Employee
{
    public override void HandleTask(string task, int priority)
    {
        if (priority <= 5)
        {
            Console.WriteLine($"Manager handles task: {task}");
        }
        else if (_next != null)
        {
            _next.HandleTask(task, priority);
        }
        else
        {
            Console.WriteLine($"Task '{task}' cannot be handled!");
        }
    }
}

public class Director : Employee
{
    public override void HandleTask(string task, int priority)
    {
        if (priority > 5)
        {
            Console.WriteLine($"Director handles task: {task}");
        }
        else if (_next != null)
        {
            _next.HandleTask(task, priority);
        }
        else
        {
            Console.WriteLine($"Task '{task}' cannot be handled!");
        }
    }
}

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

public class TaskIterator : IIterator<string>
{
    private readonly List<string> _tasks;
    private int _index;

    public TaskIterator(List<string> tasks)
    {
        _tasks = tasks;
        _index = 0;
    }

    public bool HasNext()
    {
        return _index < _tasks.Count;
    }

    public string Next()
    {
        return HasNext() ? _tasks[_index++] : null;
    }
}

public class TaskCollection
{
    private readonly List<string> _tasks = new List<string>();

    public void AddTask(string task)
    {
        _tasks.Add(task);
    }

    public IIterator<string> CreateIterator()
    {
        return new TaskIterator(_tasks);
    }
}

public interface ICommand
{
    void Execute();
}

public class PrintTaskCommand : ICommand
{
    private readonly string _task;

    public PrintTaskCommand(string task)
    {
        _task = task;
    }

    public void Execute()
    {
        Console.WriteLine($"Executing task: {_task}");
    }
}

public class CommandInvoker
{
    private readonly Queue<ICommand> _commands = new Queue<ICommand>();

    public void AddCommand(ICommand command)
    {
        _commands.Enqueue(command);
    }

    public void ExecuteAll()
    {
        while (_commands.Count > 0)
        {
            ICommand command = _commands.Dequeue();
            command.Execute();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Chain of Responsibility ===");
        Employee intern = new Intern();
        Employee manager = new Manager();
        Employee director = new Director();

        intern.SetNext(manager);
        manager.SetNext(director);

        intern.HandleTask("Prepare coffee", 1); 
        intern.HandleTask("Prepare report", 4);
        intern.HandleTask("Approve budget", 6); 

        Console.WriteLine();

        Console.WriteLine("=== Iterator ===");
        TaskCollection taskCollection = new TaskCollection();
        taskCollection.AddTask("Task 1: Fix bug");
        taskCollection.AddTask("Task 2: Update documentation");
        taskCollection.AddTask("Task 3: Deploy to production");

        IIterator<string> taskIterator = taskCollection.CreateIterator();

        while (taskIterator.HasNext())
        {
            Console.WriteLine(taskIterator.Next());
        }

        Console.WriteLine();

        Console.WriteLine("=== Command ===");
        CommandInvoker invoker = new CommandInvoker();
        invoker.AddCommand(new PrintTaskCommand("Fix critical bug"));
        invoker.AddCommand(new PrintTaskCommand("Prepare presentation"));
        invoker.AddCommand(new PrintTaskCommand("Conduct meeting"));

        invoker.ExecuteAll();

        Console.ReadKey();
    }
}
