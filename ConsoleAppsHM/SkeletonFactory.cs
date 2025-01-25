public class SkeletonFactory : EnemyFactory
{
    public override Enemy CreateEnemy(string difficulty)
    {
        return new Skeleton(difficulty);
    }
}