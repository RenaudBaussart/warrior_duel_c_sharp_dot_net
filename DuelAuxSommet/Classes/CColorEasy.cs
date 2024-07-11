using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelAuxSommet.Classes
{
    public static class CColorEasy
    {
        public static void Choice(int witchPlayer,bool isAttacking)
        {
            switch (witchPlayer)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (isAttacking)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (isAttacking)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
