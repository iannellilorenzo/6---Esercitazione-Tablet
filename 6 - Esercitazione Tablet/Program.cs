using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Tablet[] tabl = new Tablet[5];
        int index = 0;

        int[] punteggi = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Tablet numero {i + 1}: ");
            Console.Write("Inserire la marca: ");
            string marca = Console.ReadLine();

            Console.Write("Inserire la velocita' in GHz (x,y): ");
            double valGHz = double.Parse(Console.ReadLine());

            Console.Write("Inserire la dimensione dello schermo in pollici (x,y): ");
            double dimPol = double.Parse(Console.ReadLine());

            Console.Write("Inserire la capacita' della batteria in mAh: ");
            double durBatmAh = double.Parse(Console.ReadLine());

            tabl[i] = new Tablet(marca, valGHz, dimPol, durBatmAh);
            
            Console.Clear();
        }

        foreach (var tablet in tabl)
        {
            Console.WriteLine($"Punteggio tablet numero {index + 1}:");
            var tupla = tablet.Punteggio(tablet);
            Console.WriteLine($"Punteggio velocita' processore: {tupla.Item1}; Punteggio dimensioni schermo: {tupla.Item2}; Punteggio capacita' batteria: {tupla.Item3}.\n");

            punteggi[index] = tupla.Item1 + tupla.Item2 + tupla.Item3;

            index++;
        }

        int puntMax = punteggi.Max();
        int puntMin = punteggi.Min();

        Console.WriteLine($"Il miglior punteggio è: {puntMax}; ottenuto dal tablet: {Array.IndexOf(punteggi, puntMax) + 1}");
        Console.WriteLine($"Il peggior punteggio è: {puntMin}; ottenuto dal tablet: {Array.IndexOf(punteggi, puntMin) + 1}");

        Console.CursorVisible = false;
        Console.ReadKey();
    }
}

class Tablet
{
    private string _marca;
    private double _velGHz;
    private double _dimPol;
    private double _durBatmAh;

    public Tablet()
    {
        _marca = Marca;
        _velGHz = VelGHz;
        _dimPol = DimPol;
        _durBatmAh = DurBatmAh;
    }

    public Tablet(string marca, double velGHz, double dimPol, double durBatmAh)
    {
        _marca = marca;
        _velGHz = velGHz;
        _dimPol = dimPol;
        _durBatmAh = durBatmAh;
    }

    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }

    public double VelGHz
    {
        get { return _velGHz; }
        set { _velGHz = value; }
    }

    public double DimPol
    {
        get { return _dimPol; }
        set { _dimPol = value; }
    }

    public double DurBatmAh
    {
        get { return _durBatmAh; }
        set { _durBatmAh = value; }
    }

    public Tuple<int, int, int> Punteggio(Tablet tab)
    {
        int puntGHz = (int)Math.Round((decimal)tab._velGHz, MidpointRounding.AwayFromZero) * 10;
        int puntPol = (int)Math.Round((decimal)tab._dimPol, MidpointRounding.AwayFromZero);
        int puntmAh = (int)Math.Round((decimal)tab._durBatmAh / 1000, MidpointRounding.AwayFromZero);

        var ret = new Tuple<int, int, int>(puntGHz, puntPol, puntmAh);

        return ret;
    }
}
