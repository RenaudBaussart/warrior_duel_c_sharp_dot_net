using DuelAuxSommet.Classes;
using System.Collections.Generic;
using System.Runtime.InteropServices;
#region function
void GameMenu(string witchOne)
{
    switch (witchOne)
    {
        case "main":
            Console.Clear();
            Console.WriteLine("--------------- Menu ------------------");
            Console.WriteLine("[1] creation d'un guerrier");
            Console.WriteLine("[2] Voir la liste des guerrier");
            Console.WriteLine("[3] Combat entre 2 guerrier");
            Console.WriteLine("[4] Tournoi entre tout les guerrier");
            Console.WriteLine("[5] Suprimer un guerrier");
            Console.WriteLine("---------------------------------------");
            Console.Write("Qu'elle est votre selection: ");
            break;
        case "caraCreation":
            Console.Clear();
            Console.WriteLine("Bienvenue dans le menu de creation d'un personnage");
            Console.WriteLine("Quelle est la race de votre personnage ?");
            Console.Write("[elfe] / [nain] :");
            break;
    }
}
Warrior CaracterCreation()
{
    string CaracterRace;
    bool caracterGettingCreate = true;
    string caracterName;
    int caracterConstitution;
    string weaponName;
    int weaponNumberOfHit;
    int weaponDamage;
    int armorHitPoint;
    #region caracter race selection
    GameMenu("caraCreation");
    restartRaceChoice:
    switch (Console.ReadLine())
    {
        case "elfe":
            CaracterRace = "elfe";
            break;
        case "nain":
            CaracterRace = "nain";
            break;
        default:
            Console.WriteLine("Erreur Ce Choix n'est pas reconue");
            Console.ReadKey();
            goto restartRaceChoice;
    }
    #endregion
    #region caracter constitution selection
    Console.Clear();
        restartConstitutionAnchor:
        Console.Write($"Quelle est la constitution de ce {CaracterRace}\n[faible] /[commune] / [bonne]: ");
        switch (Console.ReadLine())
        {
            case "faible":
                caracterConstitution = 50;
                break;
            case "commune":
                caracterConstitution = 80;
                break;
            case "bonne":
                caracterConstitution = 120;
                break;
            default:
                Console.WriteLine("Erreur Ce Choix n'est pas reconue");
                Console.ReadKey();
                goto restartConstitutionAnchor;
        }
    #endregion
    #region caracter weapon creation
    Console.Clear();
restartWeaponAnchor:
    Console.Write($"Quelle est l'arme de ce {CaracterRace}\n[marteau] / [hache] / [épée]");
    switch (Console.ReadLine())
    {
        case "marteau":
            weaponName = NameChoice();
            weaponNumberOfHit = 1;
            weaponDamage = 12;
            break;
        case "hache":
            weaponName = NameChoice();
            weaponNumberOfHit = 2;
            weaponDamage = 6;
            break;
        case "épée":
            weaponName = NameChoice();
            weaponNumberOfHit = 3;
            weaponDamage = 4;
            break;
        default:
            Console.WriteLine("Erreur Ce Choix n'est pas reconue");
            Console.ReadKey();
            goto restartWeaponAnchor;
    }
    Arme caracterWeapon = new Arme(weaponName, weaponNumberOfHit, weaponDamage);
    #endregion
    #region caracter armor creation
    Console.Clear();
        restartArmorAnchor:
        Console.Write($"Quelle est la qualité de l'armure de ce {CaracterRace}\n[commune] / [rare] / [epic]");
        switch (Console.ReadLine())
        {
            case "commune":
                armorHitPoint = 20;
                break;
            case "rare":
                armorHitPoint = 45;
                break;
            case "epic":
                armorHitPoint = 80;
                break;
            default:
                Console.WriteLine("Erreur Ce Choix n'est pas reconue");
                Console.ReadKey();
                goto restartArmorAnchor;
        }
        Armure caracterArmor = new Armure(armorHitPoint);
    #endregion
    #region caracter naming
    Console.Write($"Votre {CaracterRace} est presque pret ");
    caracterName = NameChoice();
    #endregion
    #region return
    switch (CaracterRace)
    {
        case "elfe":
            Elfe elvenOutput = new Elfe(caracterName, caracterConstitution, caracterWeapon, caracterArmor);
            return elvenOutput;
        case "nain":
            Nain dwarfOutput = new Nain(caracterName, caracterConstitution, caracterWeapon, caracterArmor);
            return dwarfOutput;
        default:
            return null;
    }
    #endregion
}
string NameChoice()
    {
    restartNameChoice:
        Console.Write("qu'elle est sont nom: ");
        string outName = Console.ReadLine();
        switch (outName)
        {
            case null:
            case "":
                Console.WriteLine("Nom invalide");
                Console.ReadKey();
                goto restartNameChoice;
            default:
                return outName;
        }
    
    }
#endregion
bool appIsActive = true;
while (appIsActive)
{
    Console.Write("Vous Voulez enter dans l'environement de test[1 ou test] ou lancer le jeux[2 ou start]");
    switch(Console.ReadLine())
    {
        #region testEnv
        case "1":
        case "test":
            AnchorTestStart:
            Console.Clear();
            Arme guerrier1weapon = new Arme("un Marteau", 1, 7);
            Armure guerrier1armor = new Armure(10);
            Arme guerrier2weapon = new Arme("Trancheuse", 1, 6);
            Armure guerrier2armor = new Armure(10);
            Nain guerrier2 = new Nain("Gimli", 100, guerrier1weapon, guerrier1armor);
            Elfe guerrier1 = new Elfe("Perceval", 100, guerrier2weapon, guerrier1armor);
            Console.WriteLine(Duel.ItIsTime(guerrier1, guerrier2));
            Console.WriteLine("on relance un combat ? (y(Default)/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    Console.Clear();
                    goto AnchorTestStart;
                case "n":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    goto AnchorTestStart;
            }
            break;
        #endregion
        #region gameEnv
        case "2":
        case "start":
            bool gameIsActive = true;
            List<Warrior> warriorsList = new List<Warrior>();
            //----testing
            Arme warrior1weapon = new Arme("un Marteau", 1, 7);
            Armure warrior1armor = new Armure(10);
            warriorsList.Add(new Nain("jhon",100,warrior1weapon,warrior1armor));
            warriorsList.Add(new Nain("robert", 100, warrior1weapon, warrior1armor));
            warriorsList.Add(new Nain("eldri", 100, warrior1weapon, warrior1armor));
            warriorsList.Add(new Nain("corki", 100, warrior1weapon, warrior1armor));
            warriorsList.Add(new Elfe("er", 100, warrior1weapon, warrior1armor));
            warriorsList.Add(new Elfe("errt", 100, warrior1weapon, warrior1armor));
            warriorsList.Add(new Elfe("eri", 100, warrior1weapon, warrior1armor));
            warriorsList.Add(new Elfe("ereri", 100, warrior1weapon, warrior1armor));
            //end of testing
            
            while (gameIsActive)
            {
                int menuMainSelect;
                restartMainMenu:
                GameMenu("main");
                if(int.TryParse(Console.ReadLine(),out menuMainSelect))
                {
                    switch (menuMainSelect)
                    {
                        case 1:
                            Warrior newWarrior = CaracterCreation();
                            switch (newWarrior)
                            {
                                case null:
                                    Console.WriteLine("Erreur lors de la creation du personnage");
                                    Console.ReadKey();
                                    goto restartMainMenu;
                                default:
                                    Console.WriteLine($"{newWarrior.Name} a été generer avec succes!");
                                    warriorsList.Add(newWarrior);
                                    Console.ReadKey();
                                    goto restartMainMenu;
                            }
                        case 2:
                            Console.Clear();
                            Console.Write("-----List des guerrier-----\n");
                            for (int i = 0; i < warriorsList.Count; i++)
                            {
                                Console.WriteLine($"[id:{i + 1}] un Guerrier {warriorsList[i].Race} du nom de {warriorsList[i].Name}:");
                            }
                            Console.WriteLine("Appuyer sur une touche pour continue...");
                            Console.ReadKey();
                            break;
                        case 3:
                            string fighterString;
                            List<string> activeFighter = new List<string>();
                            Console.Clear();
                            Console.WriteLine("---- Combat ----");
                        restartIdReading:
                            Console.Write("Selectioner les 2 id comme si desous\n[id1] [id2]\npour annuler tapez cancel | selection:");
                            fighterString = Console.ReadLine();
                            if(fighterString == null || fighterString == " ")
                            {
                                Console.WriteLine("Erreur pas d'id entrée");
                                Console.ReadKey();
                                goto restartIdReading;
                            }
                            else
                            {
                                if (fighterString == "cancel")
                                {
                                    break;
                                }
                                int fighter1;
                                int fighter2;
                                activeFighter.AddRange(fighterString.Split(' '));
                                if(activeFighter.Count <= 1)
                                {
                                    Console.WriteLine("Erreur pas assez d'id entrée");
                                    Console.ReadKey();
                                    goto restartIdReading;
                                }
                                bool isParsed = int.TryParse(activeFighter[0], out fighter1);
                                if (!isParsed)
                                {
                                    Console.WriteLine($"Erreur {activeFighter[0]} n'est pas une valeur commune");
                                    Console.ReadKey();
                                    goto restartIdReading;
                                }
                                isParsed = int.TryParse(activeFighter[1], out fighter2);
                                if (!isParsed)
                                {
                                    Console.WriteLine($"Erreur {activeFighter[1]} n'est pas une valeur commune");
                                    Console.ReadKey();
                                    goto restartIdReading;
                                }
                                Duel.ItIsTime(warriorsList[fighter1], warriorsList[fighter2]);
                            }
                            break;
                        case 4:
                            Duel.TournamentTime(warriorsList);
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.Write("Entrée l'id du guerrier que vous voulez supprimez:");
                            int warriorIdToRemove;
                            if (!int.TryParse(Console.ReadLine(), out warriorIdToRemove))
                            {
                                Console.WriteLine("Erreur ce nest pas un id");
                                Console.ReadKey();
                                break;
                            }
                            restartSupressionDemande:
                            Console.Write($"Vous étes sur de vouloir supprimez {warriorsList[warriorIdToRemove - 1].Name}?: oui / non");
                            switch (Console.ReadLine())
                            {
                                case "oui":
                                    break;
                                case "non":
                                    break;
                                default:
                                    Console.WriteLine("entrée invalide");
                                    goto restartSupressionDemande;
                            }
                            break;
                        case 6:
                            System.Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Veuillez entrée un entier\nAppuyer sur un touche pour continuer");
                    Console.ReadKey();
                }
                
            }
            break;
        #endregion
    }
}

