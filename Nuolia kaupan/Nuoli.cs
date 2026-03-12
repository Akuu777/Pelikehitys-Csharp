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
        public Karki karki { get; }
        public Pera pera { get; }
        public int pituus { get; }

        public Nuoli(Karki k, Pera p, int pit)
        {
            karki = k;
            pera = p;
            pituus = pit;
        }

        public static Nuoli LuoEliittiNuoli()
        {
            return new Nuoli(Karki.Timantti, Pera.Kotkansulka, 100);
        }

        public static Nuoli LuoAloittelijaNuoli()
        {
            return new Nuoli(Karki.Puu, Pera.Kanansulka, 70);
        }

        public static Nuoli LuoPerusNuoli()
        {
            return new Nuoli(Karki.Teräs, Pera.Kanansulka, 85);
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
}
