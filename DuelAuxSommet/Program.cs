using DuelAuxSommet.Classes;
AnchorStart:
Console.Clear();
Nain guerrier2 = new Nain("Gimli", 100, 1, 40);
Elfe guerrier1 = new Elfe("Perceval", 100, 1);
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


