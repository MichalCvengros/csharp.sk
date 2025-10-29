namespace Randommmm
{
    public class Monster
    {
        private const int maxHP = 100;
        private const int minHP = 0;

        private int currentHP = maxHP;
        private int MonsterDamage = 10;

        internal void DealDamage(player player)
        {
            player.TakeDamage(MonsterDamage);
        }

        internal void TakeDamage(int damage)
        {
            currentHP -= damage;
        }
    }
}