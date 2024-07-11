using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{
    internal class Armure
    {
        #region attribut
        private int _numberOfArmorPoint;
        #endregion
        #region setter / getter
        public int NumberOfArmorPoint { get => _numberOfArmorPoint; set => _numberOfArmorPoint = value; }
        #endregion
        #region constructor
        public Armure(int numberOfArmorPoint)
        {
            NumberOfArmorPoint = numberOfArmorPoint;
        }
        #endregion
    }
}
