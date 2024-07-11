using DuelAuxSommet.Classes;
AnchorStart:
Console.Clear();
Arme guerrier1weapon = new Arme("Marteau", 1, 6);
Armure guerrier1armor = new Armure(10);
Arme guerrier2weapon = new Arme("épée", 1, 6);
Armure guerrier2armor = new Armure(10);
Nain guerrier2 = new Nain("Gimli", 100, guerrier1weapon, guerrier1armor);
Elfe guerrier1 = new Elfe("Perceval", 100, guerrier1weapon, guerrier1armor);
Console.WriteLine(Duel.ItIsTime(guerrier1, guerrier2));
Console.WriteLine("on relance un combat ? (y(Default)/n)");
switch (Console.ReadLine())
{
    case "y":
        goto AnchorStart;
    case "n":
        System.Environment.Exit(0);
        break;
    default:
        goto AnchorStart;
}


