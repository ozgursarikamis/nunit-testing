namespace Calculator
{
    public class EnemyFactory
    {
        public object Create(bool isBoss)
        {
            if (isBoss)
                return new BossEnemy();
            return new NormalEnemy();
        }
    }

    public class Enemy
    {

    }
    public class NormalEnemy: Enemy
    {
    }

    public class BossEnemy : Enemy
    {
        public int ExtraPower => 42;
    }
}
