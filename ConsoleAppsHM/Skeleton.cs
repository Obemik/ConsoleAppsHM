public class Skeleton : Enemy
{
    public Skeleton(string difficulty)
    {
        Difficulty = difficulty;
        switch (difficulty)
        {
            case "Easy":
                Health = 40;
                Damage = 7;
                break;
            case "Normal":
                Health = 80;
                Damage = 12;
                break;
            case "Hard":
                Health = 120;
                Damage = 18;
                break;
        }
    }

    public override void Attack()
    {
        Console.WriteLine($"Skeleton attacks with {Damage} damage. [Health: {Health}]");
    }
}