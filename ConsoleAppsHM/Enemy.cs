public abstract class Enemy
{
    public int Health { get; protected set; }
    public int Damage { get; protected set; }
    public string Difficulty { get; protected set; }

    public abstract void Attack();
}