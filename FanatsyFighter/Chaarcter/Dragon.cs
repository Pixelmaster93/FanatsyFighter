namespace FanatsyFighter
{
    internal class Dragon : Character, ICanAttack, ICanDefend
    {
        public Dragon(string name) : base(name, health: 100, attackPoints: 20, defensePoint: 15)
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
