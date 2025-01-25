public class Zombie : Enemy
{
    public Zombie(string difficulty)
    {
        Difficulty = difficulty;
        switch (difficulty)
        {
            case "Easy":
                Health = 50;
                Damage = 5;
                break;
            case "Normal":
                Health = 100;
                Damage = 10;
                break;
            case "Hard":
                Health = 150;
                Damage = 15;
                break;
        }
    }

    public override void Attack()
    {
        Console.WriteLine($"Zombie attacks with {Damage} damage. [Health: {Health}]");
    }
}