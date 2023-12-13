namespace FanatsyFighter
{
    internal class Slime : Character, ICanDefend
    {
        public Slime(string name) : base(name, health: 8, attackPoints: 0, defensePoint: 2)
        {
        }

        public void Defense()
        {
            throw new NotImplementedException();
        }
    }
}
