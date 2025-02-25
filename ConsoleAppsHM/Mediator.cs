public interface IMediator  
{
    void SendMessage(string message, Colleague sender);
}

public abstract class Colleague  
{
    protected IMediator mediator;
    public Colleague(IMediator mediator) => this.mediator = mediator;
}

public class User : Colleague  
{
    public string Name { get; }
    public User(IMediator mediator, string name) : base(mediator) => Name = name;

    public virtual void Send(string message)  
    {
        Console.WriteLine($"{Name} sends message: {message}");
        mediator.SendMessage(message, this);
    }

    public virtual void Receive(string message)  
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}

public class ChatMediator : IMediator  
{
    private List<User> users = new();
    public void Register(User user) => users.Add(user);

    public void SendMessage(string message, Colleague sender)
    {
        foreach (var user in users)
            if (user != sender)
                user.Receive(message);
    }
}