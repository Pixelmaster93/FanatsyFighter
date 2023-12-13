namespace FanatsyFighter
{
    internal class Slime : Character, ICanDefend
    {
        public Slime(string name, int health, int attackPoints, int defensePoint) : base(name, health, attackPoints, defensePoint)
        {
        }

        public void Defense()
        {
            throw new NotImplementedException();
        }
    }
}
