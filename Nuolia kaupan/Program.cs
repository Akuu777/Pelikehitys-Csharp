namespace Nuolia_kaupan
{
    enum Karki
    {
        Puu,
        Teräs,
        Timantti
    }

    enum Pera
    {
        Lehti,
        Kanansulka,
        Kotkansulka
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Minkälainen kärki (puu, teräs, timantti)?: ");
            string karkiSyote = Console.ReadLine();
            Karki karki = (Karki)Enum.Parse(typeof(Karki), karkiSyote, true);

            Console.Write("Minkälaiset sulat (lehti, kanansulka, kotkansulka)?: ");
            string peraSyote = Console.ReadLine();
            Pera pera = (Pera)Enum.Parse(typeof(Pera), peraSyote, true);

            Console.Write("Nuolen pituus sentteinä (60-100): ");
            int pituus = int.Parse(Console.ReadLine());

            Nuoli nuoli = new Nuoli(karki, pera, pituus);

            double hinta = nuoli.PalautaHinta();
            Console.WriteLine("Tämän nuolen hinta on " + hinta + " kultarahaa.");
        }
    }
}
