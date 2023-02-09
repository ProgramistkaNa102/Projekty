using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] charakter = Charakter.Selection();
            int round = 0;

            int maxHp = charakter[0];
            int maxMana = charakter[2];
            {
                while (charakter[0]>0)
                {
                    if ((charakter[2] > 1000))
                    {
                        charakter[0] -= charakter[0];
                        
                    }
                    Informacje.informations(charakter, round);
                    string inp = Console.ReadLine().ToLower();
                    switch (inp)
                    {
                        case "a":
                            Console.WriteLine("Wlaka z kotem");
                            Koty.walka(charakter);
                            break;
                        case "s":
                            Console.WriteLine("Leczenie");
                            Leczenie.leczenie(charakter, maxHp, maxMana);
                            break;

                        default:
                            Console.WriteLine("Taka komenda nie istnieje");
                            break;
                    }
                    if ((charakter[2] > 1000))
                    {
                        charakter[0] -= charakter[0];
                        Console.WriteLine("Zdobyłeś pieniądze na przysmak, uciekasz z gry");

                    }
                    round += 1;
                }

                Console.WriteLine("Dziekuje za gre");
                Console.ReadKey();
            }
        }
    }
}