using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanatsyFighter
{
    public class Hero : Character, ICanDefend, ICanAttack
    {
        public Roles Role { get; set; } = Roles.Warrior;
        public Hero(string name, int health, int attackPoints, int defensePoint) : base(name, health, attackPoints, defensePoint)
        {
        }

        public void Defense()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }


    public enum Roles //elenco per enum aiuta a non sbagliare con le stringhe
    {
        Warrior,
        Cleric,
        Rogue,
        Mage
    }
}
