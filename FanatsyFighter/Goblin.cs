namespace FanatsyFighter
{
    internal class Goblin : Character, ICanDefend, ICanAttack
    {
        public Goblin(string name, int health, int atatckPoints, int defencePoint) : base(name, health, atatckPoints, defencePoint)
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
