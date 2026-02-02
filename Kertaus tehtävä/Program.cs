using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Tervetuloa ritari peliin!");
        Peli();
    }

    static void Peli()
    {
        int ritari = 20;
        int örkki = 20;

        while (ritari > 0 && örkki > 0)
        {
            Tulosta(ritari, örkki);
            string toiminto = PelaajaValinta();
            örkki = PelaajanVuoro(toiminto, örkki);
            if (örkki > 0) ritari = ÖrkinVuoro(toiminto, ritari);
            Console.WriteLine();
        }

        if (ritari > 0) Console.WriteLine("Voitit taistelun! Örkki on kukistettu.");
        else Console.WriteLine("Hävisit taistelun. Örkki voitti.");
        Console.ReadKey();
    }

    static void Tulosta(int ritari, int örkki)
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Ritari HP: " + ritari);
        Console.WriteLine("Örkki HP: " + örkki);
        Console.WriteLine("Valitse toiminto:");
        Console.WriteLine("1 - Hyökkää");
        Console.WriteLine("2 - Puolusta");
    }

    static string PelaajaValinta()
    {
        string valinta = "";
        while (valinta != "1" && valinta != "2")
        {
            Console.Write("Komento: ");
            valinta = Console.ReadLine();
        }
        return valinta;
    }

    static int PelaajanVuoro(string toiminto, int örkki)
    {
        if (toiminto == "1")
        {
            int vahinko = random.Next(1, 6);
            örkki -= vahinko;
            Console.WriteLine("Hyökkäät ja teet örkkiin " + vahinko + " vahinkoa.");
        }
        else
        {
            Console.WriteLine("Puolustaudut kilvellä.");
        }
        return örkki;
    }

    static int ÖrkinVuoro(string pelaaja, int ritari)
    {
        int vahinko = random.Next(1, 6);
        if (pelaaja == "2") vahinko /= 2;
        ritari -= vahinko;
        Console.WriteLine("Örkki hyökkää ja tekee sinuun " + vahinko + " vahinkoa.");
        return ritari;
    }
}