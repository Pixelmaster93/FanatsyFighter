using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanatsyFighter
{
    public class Hero : Character, ICanDefend, ICanAttack
    {
        public Roles Role { get; private set; } = Roles.Warrior;
        public Hero(string name, Roles role) : base(name, health: 100, attackPoints: 10, defensePoint: 10)
        {
            this.Role = role;
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
