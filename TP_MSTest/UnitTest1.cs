[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ObserverReceivesNotification()
    {
        var subject = new Subject();
        var observer = new TestObserver();
        subject.Attach(observer);

        subject.Notify("Test Message");

        Assert.AreEqual("Test Message", observer.LastMessage);
    }

    private class TestObserver : IObserver
    {
        public string LastMessage { get; private set; }
        public void Update(string message) => LastMessage = message;
    }

    [TestMethod]
    public void MementoRestoresPreviousState()
    {
        var originator = new Originator();
        var caretaker = new Caretaker();

        originator.State = "Initial State";
        caretaker.Backup(originator);

        originator.State = "New State";
        caretaker.Undo(originator);

        Assert.AreEqual("Initial State", originator.State);
    }

    [TestMethod]
    public void MediatorSendsMessages()
    {
        var mediator = new ChatMediator();
        var user1 = new TestUser(mediator, "User1");
        var user2 = new TestUser(mediator, "User2");

        mediator.Register(user1);
        mediator.Register(user2);

        user1.Send("Hello!");

        Assert.AreEqual("Hello!", user2.LastMessage);
    }

    private class TestUser : User
    {
        public string LastMessage { get; private set; }
        public TestUser(IMediator mediator, string name) : base(mediator, name) { }
        public override void Receive(string message) => LastMessage = message;
    }
}