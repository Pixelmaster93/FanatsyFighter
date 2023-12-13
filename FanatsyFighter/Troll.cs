namespace FanatsyFighter
{
    internal class Troll : Character, ICanAttack, ICanDefend
    {
        public Troll(string name, int health, int atatckPoints, int defencePoint) : base(name, health, atatckPoints, defencePoint)
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
