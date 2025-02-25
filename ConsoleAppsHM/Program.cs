using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Observer Pattern ===");
        var subject = new Subject();
        var observer1 = new ConcreteObserver("Observer 1");
        var observer2 = new ConcreteObserver("Observer 2");

        subject.Attach(observer1);
        subject.Attach(observer2);

        subject.Notify("Update 1");
        subject.Detach(observer1);
        subject.Notify("Update 2");

        Console.WriteLine("\n=== Memento Pattern ===");
        var originator = new Originator();
        var caretaker = new Caretaker();

        originator.State = "State 1";
        caretaker.Backup(originator);

        originator.State = "State 2";
        caretaker.Backup(originator);

        originator.State = "State 3";
        Console.WriteLine($"Current State: {originator.State}");

        caretaker.Undo(originator);
        Console.WriteLine($"Restored to: {originator.State}");

        caretaker.Undo(originator);
        Console.WriteLine($"Restored to: {originator.State}");

        Console.WriteLine("\n=== Mediator Pattern ===");
        var mediator = new ChatMediator();

        var user1 = new User(mediator, "Alice");
        var user2 = new User(mediator, "Bob");

        mediator.Register(user1);
        mediator.Register(user2);

        user1.Send("Hello, everyone!");
        user2.Send("Hi, Alice!");
    }
}