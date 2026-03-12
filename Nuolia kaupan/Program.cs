class Program
{
    static void Main()
    {
        Console.WriteLine("Tervetuloa nuolikauppaan.");
        Console.WriteLine("Haluatko:");
        Console.WriteLine("1. Teettää nuolen tilaustyönä?");
        Console.WriteLine("2. Ostaa valmiin nuolen?");
        Console.Write("Valinta: ");
        string valinta = Console.ReadLine();

        Nuoli nuoli;

        if (valinta == "1")
        {
            Console.Write("Valitse kärki (puu, teräs, timantti): ");
            Karki karki = (Karki)Enum.Parse(typeof(Karki), Console.ReadLine(), true);

            Console.Write("Valitse perä (lehti, kanansulka, kotkansulka): ");
            Pera pera = (Pera)Enum.Parse(typeof(Pera), Console.ReadLine(), true);

            Console.Write("Nuolen pituus (60–100): ");
            int pituus = int.Parse(Console.ReadLine());

            nuoli = new Nuoli(karki, pera, pituus);
        }
        else if (valinta == "2")
        {
            Console.WriteLine("Valitse valmis nuoli:");
            Console.WriteLine("1. Eliittinuoli");
            Console.WriteLine("2. Aloittelijanuoli");
            Console.WriteLine("3. Perusnuoli");
            Console.Write("Valinta: ");
            string valmis = Console.ReadLine();

            if (valmis == "1")
                nuoli = Nuoli.LuoEliittiNuoli();
            else if (valmis == "2")
                nuoli = Nuoli.LuoAloittelijaNuoli();
            else
                nuoli = Nuoli.LuoPerusNuoli();
        }
        else
        {
            Console.WriteLine("Virheellinen valinta.");
            return;
        }

        double hinta = nuoli.PalautaHinta();
        Console.WriteLine($"Valitsemasi nuolen hinta on {hinta} kultarahaa.");
    }
}
