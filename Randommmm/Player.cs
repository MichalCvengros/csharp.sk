using Randommmm;

namespace Randommmm
{
    public class player
    {
        private const int MaxHP = 100;
        private const int MinHP = 0;

        private string Name;
        private int currentHP = MaxHP;
        private int PlayerDamage = 20;
        private List<string> inventory = new List<string>();

        internal void TakeDamage(int monsterDamage)
        {
            currentHP -= monsterDamage;
        }

        public bool DealDamage(Monster opponent)
        {
            opponent.TakeDamage(PlayerDamage);
            return true;
        }

        internal void SetName(string? playerName)
        {
            Name = playerName;
        }
    }
}