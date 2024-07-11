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
        public Nain(string name,int pv, Arme weapon, Armure armor) : base(name,pv,weapon,armor) 
        {
            Armor.NumberOfArmorPoint = armor.NumberOfArmorPoint + 50;
        }
    }
}
