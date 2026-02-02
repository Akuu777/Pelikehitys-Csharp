namespace Ruoka_annos_generaattori
{
    // Enumeraattorit
    enum PaaraakaAine { nautaa, kanaa, kasviksia }
    enum Lisuke { perunaa, riisiä, pastaa }
    enum Kastike { pippuri, chili, tomaatti, curry }

    // Ateria-luokka
    class Ateria
    {
        public PaaraakaAine PaaraakaAine;
        public Lisuke Lisuke;
        public Kastike Kastike;
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Pääraaka-aine (nautaa, kanaa, kasviksia): ");
            PaaraakaAine paaraakaAine =
                (PaaraakaAine)Enum.Parse(typeof(PaaraakaAine), Console.ReadLine());

            Console.Write("Lisukkeet (perunaa, riisiä, pastaa): ");
            Lisuke lisuke =
                (Lisuke)Enum.Parse(typeof(Lisuke), Console.ReadLine());

            Console.Write("Kastike (pippuri, chili, tomaatti, curry): ");
            Kastike kastike =
                (Kastike)Enum.Parse(typeof(Kastike), Console.ReadLine());

            Ateria ateria = new Ateria
            {
                PaaraakaAine = paaraakaAine,
                Lisuke = lisuke,
                Kastike = kastike
            };

            Console.WriteLine();
            Console.WriteLine($"{ateria.PaaraakaAine} ja {ateria.Lisuke} {ateria.Kastike}-kastikkeella");
        }
    }
}