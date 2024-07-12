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
        private int _witchPlayer;
        private Arme _weapon;
        private Armure _armor;
        private string _race;
        #endregion
        #region getter/setter
        public string Name {  get =>  _Name; set => _Name = value; }
        public int Hp { get => _Hp; set => _Hp = value; }
        public int WitchPlayer { get => _witchPlayer; set => _witchPlayer = value; }
        internal Arme Weapon { get => _weapon; set => _weapon = value; }
        internal Armure Armor { get => _armor; set => _armor = value; }
        public string Race { get => _race; set => _race = value; }
        #endregion
        #region constructor
        public Warrior(string name, int pv, Arme weapon, Armure armor)
        {
            Name = name;
            Hp = pv;
            WitchPlayer = 0;
            Weapon = weapon;
            Armor = armor;
            
        }
        #endregion
        #region methode
        public virtual int Attack()
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
            Console.WriteLine($"le guerrier du nom de {Name} est une quiche!");
            CColorEasy.Choice(0, true);
            return 0;
        }
        public virtual void Defence(int numberOfDamage)
        {
            CColorEasy.Choice(WitchPlayer, false);
            if (Armor.NumberOfArmorPoint <= 0)
            {
                Hp -= numberOfDamage;
            }
            else if (Armor.NumberOfArmorPoint >= numberOfDamage)
            {
                Armor.NumberOfArmorPoint -= numberOfDamage;
            }
            else if (Armor.NumberOfArmorPoint < numberOfDamage)
            {
                Armor.NumberOfArmorPoint = 0;
            }
            Console.WriteLine($"le guerrier du nom de {Name} a desormé {Hp} point de vie et {Armor.NumberOfArmorPoint} point d'armure!");
            CColorEasy.Choice(0, true);
        }
        #endregion
    }

}
