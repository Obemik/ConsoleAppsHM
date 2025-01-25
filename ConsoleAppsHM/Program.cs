using System;

class Program
{
    static void Main(string[] args)
    {
        EnemyFactory zombieFactory = new ZombieFactory();
        EnemyFactory skeletonFactory = new SkeletonFactory();

        Enemy easyZombie = zombieFactory.CreateEnemy("Easy");
        Enemy hardSkeleton = skeletonFactory.CreateEnemy("Hard");

        easyZombie.Attack();
        hardSkeleton.Attack();

        Enemy normalSkeleton = skeletonFactory.CreateEnemy("Normal");
        normalSkeleton.Attack();

        Console.ReadLine();
    }
}