namespace DuelAuxSommet.Classes
{
    internal class Duel
    {
        public static string ItIsTime(Warrior guerrier1, Warrior guerrier2)
        {
            guerrier1.WitchPlayer = 1;
            guerrier2.WitchPlayer = 2;
            string winner = "";
            int indexCombat = 0;
            while (guerrier1.Hp >= 0 && guerrier2.Hp >= 0 && indexCombat != 100)
            {
                CColorEasy.Choice(0, true);
                #region attack guerrier 1
                guerrier2.Defence(guerrier1.Attack());
                if (guerrier2.Hp < 1)
                {
                    winner = guerrier1.Name;
                    break;
                }
                if (guerrier1.Hp < 1)
                {
                    winner = guerrier2.Name;
                    break;
                }
                #endregion
                #region attack guerrier 2
                guerrier1.Defence(guerrier2.Attack());
                if(guerrier1.Hp < 1)
                {
                    winner = guerrier2.Name;
                }
                if(guerrier2.Hp < 1)
                {
                    winner = guerrier1.Name;
                }
                #endregion
                indexCombat++;
            }
            if (indexCombat == 100)
            {
                return $"{guerrier1.Name} et {guerrier2.Name} ont été incapable de s'entretuer in sont donc 2 quiche!";
            }
            return winner + " est le gagnant du combat!";
        }
    }
}
