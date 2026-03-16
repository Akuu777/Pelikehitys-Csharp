public class Tavara
{
    public double Paino { get; }
    public double Tilavuus { get; }

    public Tavara(double paino, double tilavuus)
    {
        Paino = paino;
        Tilavuus = tilavuus;
    }
}

public class Nuoli : Tavara
{
    public Nuoli() : base(0.1, 0.05) { }
    public override string ToString() => "Nuoli";
}

public class Jousi : Tavara
{
    public Jousi() : base(1, 4) { }
    public override string ToString() => "Jousi";
}

public class Koysi : Tavara
{
    public Koysi() : base(1, 1.5) { }
    public override string ToString() => "Köysi";
}

public class Vesi : Tavara
{
    public Vesi() : base(2, 2) { }
    public override string ToString() => "Vesi";
}

public class Ruoka : Tavara
{
    public Ruoka() : base(1, 0.5) { }
    public override string ToString() => "Ruoka";
}

public class Miekka : Tavara
{
    public Miekka() : base(5, 3) { }
    public override string ToString() => "Miekka";
}

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
