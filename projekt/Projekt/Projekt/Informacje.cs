using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Informacje
    {
        public static void informations(int[] charcer, int runda)
        {
            Console.WriteLine($"------------------- round - {runda} -------------------");
            Console.WriteLine($"Twoje hp {charcer[0]} atak {charcer[1]} mana {charcer[2]}");
            Console.WriteLine($"a - walcze | s - lecze sie");
            Thread.Sleep(900);
        }


    }
}

