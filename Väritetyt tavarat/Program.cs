using System;

public class Tavara
{
    public override string ToString()
    {
        return this.GetType().Name;
    }
}

public class Miekka : Tavara { }
public class Jousi : Tavara { }
public class Kirves : Tavara { }

public class VaritettyTavara<T>
{
    public T Tavara { get; }
    public ConsoleColor Vari { get; }

    public VaritettyTavara(T tavara, ConsoleColor vari)
    {
        Tavara = tavara;
        Vari = vari;
    }

    public void NaytaTavara()
    {
        var vanha = Console.ForegroundColor;
        Console.ForegroundColor = Vari;

        Console.WriteLine(Tavara.ToString());

        Console.ForegroundColor = vanha;
    }
}

class Program
{
    static void Main()
    {
        var miekka = new VaritettyTavara<Miekka>(new Miekka(), ConsoleColor.Blue);
        var jousi = new VaritettyTavara<Jousi>(new Jousi(), ConsoleColor.Red);
        var kirves = new VaritettyTavara<Kirves>(new Kirves(), ConsoleColor.Green);

        miekka.NaytaTavara();
        jousi.NaytaTavara();
        kirves.NaytaTavara();
    }
}
