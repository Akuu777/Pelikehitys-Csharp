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

    class Nuoli
    {
        private Karki karki;
        private Pera pera;
        private int pituus;

        public Nuoli(Karki k, Pera p, int pit)
        {
            karki = k;
            pera = p;
            pituus = pit;
        }
        public Karki GetKarki()
        {
            return karki;
        }

        public Pera GetPera()
        {
            return pera;
        }

        public int GetPituus()
        {
            return pituus;
        }

        public double PalautaHinta()
        {
            double hinta = 0;

            if (karki == Karki.Puu)
                hinta += 3;
            else if (karki == Karki.Teräs)
                hinta += 5;
            else if (karki == Karki.Timantti)
                hinta += 50;

            if (pera == Pera.Lehti)
                hinta += 0;
            else if (pera == Pera.Kanansulka)
                hinta += 1;
            else if (pera == Pera.Kotkansulka)
                hinta += 5;

            hinta += pituus * 0.05;

            return hinta;
        }
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
