namespace FanatsyFighter
{
    internal class Troll : Character, ICanAttack, ICanDefend
    {
        public Troll(string name) : base(name, health: 50, attackPoints: 8, defensePoint: 10)
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
