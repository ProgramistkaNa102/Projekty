using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Leczenie
    {
        public static int[] Przysmak(int[] character, int maxHp, int maxMana)
        {
            Console.WriteLine("a - Lecznie");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "a":
                    return leczenie(character, maxHp, maxMana);
                default:
                    return character;
            }
        }

        public static int[] leczenie(int[] character, int maxHp, int maxMana)
        {
            if (character[2] >= 50)
            {
                character[0] = maxHp;
                character[2] -= 50;
                Console.WriteLine("Masz max hp");
                return character;
            }
            else
            {
                Console.WriteLine("Brak many");
            }

            return character;
        }
    }
}
