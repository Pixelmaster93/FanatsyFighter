﻿namespace FanatsyFighter
{
    internal class Dragon : Character, ICanAttack, ICanDefend
    {
        public Dragon(string name, int health, int atatckPoints, int defencePoint) : base(name, health, atatckPoints, defencePoint)
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
