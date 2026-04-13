public class Reppu
{
    private List<Tavara> tavarat = new List<Tavara>();

    public int MaxTavarat { get; }
    public double MaxPaino { get; }
    public double MaxTilavuus { get; }

    public int TavaraMaara => tavarat.Count;
    public double NykyPaino { get; private set; }
    public double NykyTilavuus { get; private set; }

    public Reppu(int maxTavarat, double maxPaino, double maxTilavuus)
    {
        MaxTavarat = maxTavarat;
        MaxPaino = maxPaino;
        MaxTilavuus = maxTilavuus;
    }

    public bool Lisaa(Tavara t)
    {
        if (TavaraMaara >= MaxTavarat) return false;
        if (NykyPaino + t.Paino > MaxPaino) return false;
        if (NykyTilavuus + t.Tilavuus > MaxTilavuus) return false;

        tavarat.Add(t);
        NykyPaino += t.Paino;
        NykyTilavuus += t.Tilavuus;
        return true;
    }

    public override string ToString()
    {
        if (tavarat.Count == 0)
            return "Reppu on tyhjä.";

        return "Reppussa on seuraavat tavarat: " +
               string.Join(", ", tavarat);
    }
}

class Program
{
    static void Main()
    {
        Reppu reppu = new Reppu(10, 30, 20);

        Console.WriteLine(reppu.ToString());

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Reppu:");
            Console.WriteLine("Tavaroita: " + reppu.TavaraMaara + "/" + reppu.MaxTavarat);
            Console.WriteLine("Paino: " + reppu.NykyPaino + "/" + reppu.MaxPaino);
            Console.WriteLine("Tilavuus: " + reppu.NykyTilavuus + "/" + reppu.MaxTilavuus);
            Console.WriteLine();

            Console.WriteLine("1 = Nuoli");
            Console.WriteLine("2 = Jousi");
            Console.WriteLine("3 = Köysi");
            Console.WriteLine("4 = Vesi");
            Console.WriteLine("5 = Ruoka");
            Console.WriteLine("6 = Miekka");

            string valinta = Console.ReadLine();

            Tavara t = null;

            if (valinta == "1") t = new Nuoli();
            else if (valinta == "2") t = new Jousi();
            else if (valinta == "3") t = new Koysi();
            else if (valinta == "4") t = new Vesi();
            else if (valinta == "5") t = new Ruoka();
            else if (valinta == "6") t = new Miekka();
            else
            {
                Console.WriteLine("Virheellinen valinta.");
                continue;
            }

            if (reppu.Lisaa(t))
            {
                Console.WriteLine("Lisättiin reppuun.");
                Console.WriteLine(reppu.ToString());
            }
            else
                Console.WriteLine("Ei mahdu.");
        }
    }
}
