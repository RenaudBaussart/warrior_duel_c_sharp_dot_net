﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{
    internal class Elfe : Warrior
    {
        public Elfe(string name,int pv, int nbAttack) : base(name,pv,nbAttack)
        {
        }
        public override int Attack()
        {
            CColorEasy.Choice(WitchPlayer, true);
            Random rnd = new Random();
            int attackOut = rnd.Next(6 * NumberOfAttack + 1);
            if (attackOut > 1)
            {
                Console.WriteLine($"le guerrier Elfe du nom de {Name} a infliger un coup qui a fait {attackOut}!");
                CColorEasy.Choice(0, true);
                return attackOut;
            }
            else if (attackOut >= 0) 
            {
                Console.WriteLine($"le guerrier Elfe du nom de {Name} a infliger un coup inextremis qui a fait 1!");
                CColorEasy.Choice(0, true);
                return 1;
            }
            Console.WriteLine($"le guerrier du nom de {Name} est une quiche!");
            CColorEasy.Choice(0, true);
            return 0;
        }
    }
}