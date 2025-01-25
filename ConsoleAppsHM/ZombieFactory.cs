public class ZombieFactory : EnemyFactory
{
    public override Enemy CreateEnemy(string difficulty)
    {
        return new Zombie(difficulty);
    }
}