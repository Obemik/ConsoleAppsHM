public class Memento  
{
    public string State { get; }
    public Memento(string state) => State = state;
}

public class Originator  
{
    public string State { get; set; }
    public Memento Save() => new(State);
    public void Restore(Memento memento) => State = memento.State;
}

public class Caretaker  
{
    private Stack<Memento> history = new();
    public void Backup(Originator originator) => history.Push(originator.Save());
    public void Undo(Originator originator)
    {
        if (history.Count > 0)
            originator.Restore(history.Pop());
    }
}