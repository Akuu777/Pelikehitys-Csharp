using System;

namespace Kertaus_tehtävä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Tervetuloa ritari peliin!");

            int RitariHitPoints = 20;
            int ÖrkkiHitPoints = 20;

            while (RitariHitPoints > 0 && ÖrkkiHitPoints > 0)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Ritari HP: " + RitariHitPoints);
                Console.WriteLine("Örkki HP: " + ÖrkkiHitPoints);
                Console.WriteLine("Valitse toiminto:");
                Console.WriteLine("1 - Hyökkää");
                Console.WriteLine("2 - Puolusta");

                string vastaus = "";

                // Kysy komentoa kunnes se on oikein
                while (vastaus != "1" && vastaus != "2")
                {
                    Console.Write("Komento: ");
                    vastaus = Console.ReadLine();
                }

                // Pelaajan vuoro
                if (vastaus == "1")
                {
                    int ritariVahinko = random.Next(1, 6);
                    ÖrkkiHitPoints -= ritariVahinko;
                    Console.WriteLine("Hyökkäät ja teet örkkiin " + ritariVahinko + " vahinkoa.");
                }
                else if (vastaus == "2")
                {
                    Console.WriteLine("Puolustaudut kilvellä.");
                }

                // Örkin vuoro
                if (ÖrkkiHitPoints > 0)
                {
                    int örkkiVahinko = random.Next(1, 6);

                    if (vastaus == "2")
                    {
                        örkkiVahinko = örkkiVahinko / 2;
                    }

                    RitariHitPoints -= örkkiVahinko;
                    Console.WriteLine("Örkki hyökkää ja tekee sinuun " + örkkiVahinko + " vahinkoa.");
                }

                Console.WriteLine();
            }

            if (RitariHitPoints > 0)
            {
                Console.WriteLine("Voitit taistelun! Örkki on kukistettu.");
            }
            else
            {
                Console.WriteLine("Hävisit taistelun. Örkki voitti.");
            }

            Console.ReadKey();
        }
    }
}