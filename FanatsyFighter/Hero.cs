using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanatsyFighter
{
    public class Hero : Character
    {
        public Roles Role { get; set; } = Roles.Warrior;
        public Hero(string name, string health, string atatckPoints, string defencePoint) : base(name, health, atatckPoints, defencePoint)
        {
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
