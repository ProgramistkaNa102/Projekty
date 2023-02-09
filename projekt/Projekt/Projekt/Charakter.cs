using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Charakter
    {

        public static int[] Selection()
        {
            while (true)
            {
                Console.WriteLine("Buldog francuzki - a \t Dog niemiecki - b \t Owczarek niemiecki - c");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    int[] m = { 450, 10, 900, 0 };
                    return m;
                }
                else if (inp == "b")
                {
                    int[] w = { 300, 30, 25, 0 };
                    return w;
                }
                else if (inp == "c")
                {
                    int[] c = { 200, 40, 25, 0 };
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
