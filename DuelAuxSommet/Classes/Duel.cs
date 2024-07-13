using System.Collections.Generic;

namespace DuelAuxSommet.Classes
{
    internal class Duel
    {
        private static List<Warrior> WarriorListRandomiser(List<Warrior> listToRandom)
        {
            Random rnd = new Random();
            List<Warrior> listOutput = new List<Warrior>();
            while (listToRandom.Count > 0)
            { 
                int RandomIndex = rnd.Next(0 ,listToRandom.Count);
                listOutput.Add(listToRandom[RandomIndex]);
                listToRandom.RemoveAt(RandomIndex);
            }
            return listOutput;
        }
        public static string ItIsTime(Warrior guerrier1, Warrior guerrier2)
        {
            guerrier1.WitchPlayer = 1;
            guerrier2.WitchPlayer = 2;
            string winner = "";
            int indexCombat = 0;
            while (guerrier1.Hp > 0 && guerrier2.Hp > 0 && indexCombat != 100)
            {
                CColorEasy.Choice(0, true);
                #region attack guerrier 1
                guerrier2.Defence(guerrier1.Attack());
                if (guerrier2.Hp < 1)
                {
                    winner = guerrier1.Name;
                }
                else if (guerrier1.Hp < 1)
                {
                    winner = guerrier2.Name;
                }
                else
                {
                    #endregion
                    #region attack guerrier 2
                    guerrier1.Defence(guerrier2.Attack());
                    if (guerrier1.Hp < 1)
                    {
                        winner = guerrier2.Name;
                    }
                    if (guerrier2.Hp < 1)
                    {
                        winner = guerrier1.Name;
                    }
                    #endregion
                }
                indexCombat++;
            }
            if (indexCombat == 100)
            {
                return $"{guerrier1.Name} et {guerrier2.Name} ont été incapable de s'entretuer in sont donc 2 quiche!";
            }
            return winner + " est le gagnant du combat!";
        }
        public static void TournamentTime(List<Warrior> inputListWars)
        {
            List<Warrior> listWars = new List<Warrior>();
            listWars.AddRange(inputListWars);
            if (listWars.Count() < 2)
            {
                Console.Clear();
                Console.WriteLine("Le tournoi a été annulée faute de participant");
            }
            else
            {
                int tournamentRound = 1;
                if (listWars.Count() == 2) { goto startFinalRound; }
                while (listWars.Count() >= 3)
                {
                    List<Warrior> randomisedWarList = new List<Warrior>();
                    randomisedWarList = WarriorListRandomiser(listWars);
                    listWars.Clear();
                    Warrior? skipperThisRound = null;
                    bool unevenList = false;

                    if (randomisedWarList.Count() % 2 != 0)
                    {
                        skipperThisRound = randomisedWarList[randomisedWarList.Count() - 1];
                        randomisedWarList.RemoveAt(randomisedWarList.Count() - 1);
                        unevenList = true;
                    }
                    int randomisedWarListLength = randomisedWarList.Count();
                    for (int i = 0; i < randomisedWarListLength - 1; i += 2)
                    {
                        Warrior warrior1 = randomisedWarList[i];
                        Warrior warrior2 = randomisedWarList[i + 1];
                        warrior1.HpReset();
                        warrior2.HpReset();
                        string duelWinner = "";
                        int indexCombat = 0;
                        while (warrior1.Hp > 0 && warrior2.Hp > 0 && indexCombat != 100)
                        {
                            CColorEasy.Choice(0, true);
                            #region attack guerrier 1
                            warrior2.TournamentDefence(warrior1.TournamentAttack());
                            if (warrior2.Hp < 1)
                            {
                                listWars.Add(warrior1);
                                duelWinner = warrior1.Name;
                            }
                            else if (warrior1.Hp < 1)
                            {
                                listWars.Add(warrior2);
                                duelWinner = warrior2.Name;
                            }
                            else
                            {
                                #endregion
                                #region attack guerrier 2
                                warrior1.TournamentDefence(warrior2.TournamentAttack());
                                if (warrior1.Hp < 1)
                                {
                                    listWars.Add(warrior2);
                                    duelWinner = warrior2.Name;
                                }
                                if (warrior2.Hp < 1)
                                {
                                    listWars.Add(warrior1);
                                    duelWinner = warrior1.Name;
                                }
                                #endregion
                            }
                            indexCombat++;
                        }
                        Console.WriteLine($"Combat entre {warrior1.Name} et {warrior2.Name} lor du round {tournamentRound} le gagnant est {duelWinner}");
                    }

                    foreach (Warrior item in listWars) 
                    { 
                        Console.WriteLine(item.Name);
                    }
                    if (unevenList == true || skipperThisRound != null)
                    {
                        listWars.Add(skipperThisRound);
                    }
                    tournamentRound++;

                }
                startFinalRound:
                Console.WriteLine($"Voici venir le dernier combat entre {listWars[0].Name} et {listWars[1].Name}");
                Console.ReadKey();
                listWars[0].HpReset();
                listWars[1].HpReset();
                Console.WriteLine(ItIsTime(listWars[0], listWars[1]) + " Il est donc le grand gagnant de ce tournoit");
                Console.ReadKey();
            }

        }
    }
}
