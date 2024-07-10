using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{
    internal class Nain : Warrior
    {
        private int _armorPoint;
        public int Armor { get => _armorPoint; set => _armorPoint = value; }
        public Nain(string name,int pv,int nbAttack, int bouclier) : base(name,pv,nbAttack) 
        {
            Armor = bouclier;
        }
        public override void Defence(int numberOfDamage)
        {
            CColorEasy.Choice(WitchPlayer, false);
            if (Armor <= numberOfDamage)
            {
                numberOfDamage -= Armor;
                Armor = 0;
                Hp -= numberOfDamage;
            }
            else if (Armor >= numberOfDamage)
            { 
                Armor =- numberOfDamage;
            }
            Console.WriteLine($"le guerrier nain du nom de {Name} a desormé {Hp} et {Armor} point d'armur!");
            CColorEasy.Choice(0, true);
        }
    }
}
