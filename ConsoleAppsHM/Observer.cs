public interface IObserver  
{
    void Update(string message);
}

public class Subject  
{
    private List<IObserver> observers = new();
    public void Attach(IObserver observer) => observers.Add(observer);
    public void Detach(IObserver observer) => observers.Remove(observer);
    public void Notify(string message)
    {
        foreach (var observer in observers)
            observer.Update(message);
    }
}

public class ConcreteObserver : IObserver  
{
    private string name;
    public ConcreteObserver(string name) => this.name = name;
    public void Update(string message) => Console.WriteLine($"{name} received notification: {message}");
}