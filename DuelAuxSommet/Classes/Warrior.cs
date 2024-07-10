using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{ 
    internal class Warrior
    {
        #region attribut
        private string _Name;
        private int _Hp;
        private int _numberOfAttack;
        private int _witchPlayer;
        #endregion
        #region getter/setter
        public string Name {  get =>  _Name; set => _Name = value; }
        public int Hp { get => _Hp; set => _Hp = value; }
        public int NumberOfAttack { get => _numberOfAttack; set => _numberOfAttack = value; }
        public int WitchPlayer { get => _witchPlayer; set => _witchPlayer = value; }
        #endregion
        #region constructor
        public Warrior(string name,int pv, int nbAttack) 
        {
            Name = name;
            Hp = pv;
            NumberOfAttack = nbAttack;
            WitchPlayer = 0;
        }
        #endregion
        #region methode
        public virtual int Attack()
        {
            CColorEasy.Choice(WitchPlayer, true);
            Random rnd = new Random();
            int attackOut = rnd.Next(6 * NumberOfAttack + 1);
            if (attackOut > 1)
            {
                Console.WriteLine($"le guerrier du nom de {Name} a infliger un coup qui a fait {attackOut}!");
                CColorEasy.Choice(0, true);
                return attackOut;
            }
            Console.WriteLine($"le guerrier du nom de {Name} est une quiche!");
            CColorEasy.Choice(0, true);
            return 0;
        }
        public virtual void Defence(int numberOfDamage)
        {
            CColorEasy.Choice(WitchPlayer, false);
            Console.WriteLine($"le guerrier du nom de {Name} a desormé {Hp} point de vie");
            Hp =  Hp - numberOfDamage;
            CColorEasy.Choice(0, true);
        }
        #endregion
    }

}
