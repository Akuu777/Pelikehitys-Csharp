using System;

enum Ovi
{
    Auki,
    Kiinni,
    Lukossa
}

class Program
{
    static void Main()
    {
        Ovi tila = Ovi.Lukossa;

        while (true)
        {
            Console.WriteLine($"Ovi on {tila}. Mitä haluat tehdä?");
            string komento = Console.ReadLine();

            bool onnistui = false;

            if (komento == "avaa lukko" && tila == Ovi.Lukossa)
            {
                tila = Ovi.Kiinni;
                onnistui = true;
            }
            else if (komento == "avaa" && tila == Ovi.Kiinni)
            {
                tila = Ovi.Auki;
                onnistui = true;
            }
            else if (komento == "sulje" && tila == Ovi.Auki)
            {
                tila = Ovi.Kiinni;
                onnistui = true;
            }
            else if (komento == "lukitse" && tila == Ovi.Kiinni)
            {
                tila = Ovi.Lukossa;
                onnistui = true;
            }

            if (!onnistui)
            {
                Console.WriteLine("Väärä vastaus");
            }
        }
    }
}