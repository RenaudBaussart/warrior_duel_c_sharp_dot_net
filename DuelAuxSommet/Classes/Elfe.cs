using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{
    internal class Elfe : Warrior
    {
        public Elfe(string name,int pv, Arme weapon, Armure armor) : base(name, pv, weapon, armor)
        {
            Race = "elfe";
            HpMax = pv;
        }
        public override int Attack()
        {
            CColorEasy.Choice(WitchPlayer, true);
            Random rnd = new Random();
            int attackOut = rnd.Next(Weapon.DamageDice * Weapon.NumberOfHits + 1);
            if (attackOut > 1)
            {
                Console.WriteLine($"le guerrier du nom de {Name} a infliger un coup avec {Weapon.Name} qui a fait {attackOut}!");
                CColorEasy.Choice(0, true);
                return attackOut;
            }
            else if (attackOut >= 0) 
            {
                Console.WriteLine($"le guerrier du nom de {Name} a infliger un coup avec {Weapon.Name} inextremis qui a fait 1!");
                CColorEasy.Choice(0, true);
                return 2;
            }
            Console.WriteLine($"le guerrier du nom de {Name} est une quiche!");
            CColorEasy.Choice(0, true);
            return 0;
        }
        public override int TournamentAttack()
        {
            CColorEasy.Choice(WitchPlayer, true);
            Random rnd = new Random();
            int attackOut = rnd.Next(Weapon.DamageDice * Weapon.NumberOfHits + 1);
            if (attackOut > 1)
            {
                return attackOut;
            }
            else if (attackOut >= 0)
            {
                return 2;
            }
            CColorEasy.Choice(0, true);
            return 0;
        }
    }
}
