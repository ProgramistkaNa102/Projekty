using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Koty
    {

        public static int[] Kotecki()
        {
            Random rnd = new Random();
            int[] kot = new int[3];
            for (int i = 0; i < kot.Length; i++)
            {
                kot[i] = rnd.Next(10,40);
            }
            return kot;
        }
        public static int[] walka(int[] charakter)
        {

            int[] kotek = Kotecki();

 

            while (kotek[0] > 0)
            {
                charakter[0] -= kotek[1];
                kotek[0] -= charakter[1];
                if (charakter[0] <= 0)
                {
                    Console.WriteLine("Pokonany przez kota !!!");
                    break;

                }
                Thread.Sleep(900);
                Console.WriteLine($"Dostałaś {kotek[1]}, masz {charakter[0]} hp, zadalas/es {charakter[1]} kot ma tylko {kotek[0]} hp");
            }
            charakter[2] += kotek[2];
            return charakter;
        }
    }
}
