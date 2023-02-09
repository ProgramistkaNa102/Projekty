using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class CharacterClass
    {

        public static int[] characterClassSelection()
        {
            while (true)
            {
                Console.WriteLine("Buldog francuzki - a \t Dog niemiecki - b \t Owczarek niemiecki - c");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    int[] m = { 100, 10, 25, 20 };
                    return m;
                }
                else if (inp == "b")
                {
                    int[] w = { 300, 30, 25, 20 };
                    return w;
                }
                else if (inp == "c")
                {
                    int[] c = { 200, 40, 25, 20 }
                }
                else
                {
                    Console.WriteLine("Brak takiej klasy");
                }
            }
        }
        //---------------------------------------------------------
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}