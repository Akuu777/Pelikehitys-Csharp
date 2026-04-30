using System;

struct Koordinaatti
{
    public int X { get; }
    public int Y { get; }

    public Koordinaatti(int x, int y)
    {
        X = x;
        Y = y;
    }
    public bool OnVieressa(Koordinaatti toinen, int etaisyys)
    {
        int dx = Math.Abs(X - toinen.X);
        int dy = Math.Abs(Y - toinen.Y);

        return dx <= etaisyys && dy <= etaisyys && !(dx == 0 && dy == 0);
    }
}

class Program
{
    static void Main()
    {
        Koordinaatti keskus = new Koordinaatti(0, 0);

        int etaisyys = 1;

        for (int x = -etaisyys; x <= etaisyys; x++)
        {
            for (int y = -etaisyys; y <= etaisyys; y++)
            {
                Koordinaatti k = new Koordinaatti(x, y);

                if (k.X == 0 && k.Y == 0)
                {
                    Console.WriteLine($"Annettu koordinaatti {x},{y} on koordinaatissa 0,0.");
                }
                else if (k.OnVieressa(keskus, etaisyys))
                {
                    Console.WriteLine($"Annettu koordinaatti {x},{y} on koordinaatin 0,0 vieressä.");
                }
            }
        }
    }
}
