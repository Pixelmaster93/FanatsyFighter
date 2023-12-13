namespace FanatsyFighter
{
    internal class Goblin : Character, ICanDefend, ICanAttack
    {
        public Goblin(string name) : base(name, health: 30, attackPoints: 3, defensePoint: 2)
        {
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defense()
        {
            throw new NotImplementedException();
        }
    }
}
