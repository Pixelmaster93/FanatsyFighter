namespace FanatsyFighter
{
    internal class RatKing : Character, ICanAttack, ICanDefend
    {
        public RatKing(string name, int health, int attackPoints, int defensePoint) : base(name, health, attackPoints, defensePoint)
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
