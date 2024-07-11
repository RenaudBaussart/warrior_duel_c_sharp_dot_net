using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{
    internal class Arme
    {
        #region attribut
        private String _name;
        private int _numberOfHits;
        private int _DamageDice;
        #endregion
        #region getter/setter
        public string Name { get => _name; set => _name = value; }
        public int NumberOfHits { get => _numberOfHits; set => _numberOfHits = value; }
        public int DamageDice { get => _DamageDice; set => _DamageDice = value; }
        #endregion
        #region constructor
        public Arme(string name, int numberOfHits, int damageDice)
        {
            Name = name;
            NumberOfHits = numberOfHits;
            DamageDice = damageDice;
        }
        #endregion
        #region methode

        #endregion
    }
}
