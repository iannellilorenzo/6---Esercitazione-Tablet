using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Tablet[] tabl = new Tablet[5]; // Array di oggetti per contenere i 5 tablet
        int index = 0; // Indice usato per stampa

        int[] punteggi = new int[5]; // Array di interi per salvare i punteggi totali di ogni tablet

        // Ciclo per inizializzare tutti gli oggetti dell'array
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
            double capBatmAh = double.Parse(Console.ReadLine());

            tabl[i] = new Tablet(marca, valGHz, dimPol, capBatmAh);
            
            Console.Clear();
        }

        // Stampa di tutti i punteggi + calcolo punteggi totali che vengono salvati nell'array di int
        foreach (var tablet in tabl)
        {
            Console.WriteLine($"Punteggio tablet numero {index + 1}:");
            var tupla = tablet.Punteggio(tablet);
            Console.WriteLine($"Punteggio velocita' processore: {tupla.Item1}; Punteggio dimensioni schermo: {tupla.Item2}; Punteggio capacita' batteria: {tupla.Item3}.\n");

            punteggi[index] = tupla.Item1 + tupla.Item2 + tupla.Item3;

            index++;
        }

        // Trovo massimo e minimo punteggio dell'array
        int puntMax = punteggi.Max();
        int puntMin = punteggi.Min();

        // Stampa del miglior punteggio e del peggior punteggio con i rispettivi indici tablet
        Console.WriteLine($"Il miglior punteggio è: {puntMax}; ottenuto dal tablet: {Array.IndexOf(punteggi, puntMax) + 1}");
        Console.WriteLine($"Il peggior punteggio è: {puntMin}; ottenuto dal tablet: {Array.IndexOf(punteggi, puntMin) + 1}");

        // Estetica
        Console.CursorVisible = false;
        Console.ReadKey();
    }
}

class Tablet
{
    // Attributi della classe
    private string _marca;
    private double _velGHz;
    private double _dimPol;
    private double _capBatmAh;

    /// <summary>
    /// Costruttre senza parametri
    /// </summary>
    public Tablet()
    {
        _marca = Marca;
        _velGHz = VelGHz;
        _dimPol = DimPol;
        _capBatmAh = capBatmAh;
    }

    /// <summary>
    /// Costruttore con parametri
    /// </summary>
    /// <param name="marca"> Marca tablet </param>
    /// <param name="velGHz"> Velocità processore tablet in GHz </param>
    /// <param name="dimPol"> Dimensione schermo tablet in pollici </param>
    /// <param name="capBatmAh"> Capacità batteria in mAh </param>
    public Tablet(string marca, double velGHz, double dimPol, double capBatmAh)
    {
        _marca = marca;
        _velGHz = velGHz;
        _dimPol = dimPol;
        _capBatmAh = capBatmAh;
    }

    /// <summary>
    /// Metodo Accessor attributo _marca
    /// </summary>
    public string Marca
    {
        get { return _marca; }
        set { _marca = value; }
    }

    /// <summary>
    /// Metodo Accessor attributo _velGHz
    /// </summary>
    public double VelGHz
    {
        get { return _velGHz; }
        set { _velGHz = value; }
    }

    /// <summary>
    /// Metodo Accessor attributo _dimPol
    /// </summary>
    public double DimPol
    {
        get { return _dimPol; }
        set { _dimPol = value; }
    }

    /// <summary>
    /// Metodo Accessor attributo _capBatmAh
    /// </summary>
    public double capBatmAh
    {
        get { return _capBatmAh; }
        set { _capBatmAh = value; }
    }

    /// <summary>
    /// Metodo che restituisce i tre punteggi per ogni tablet
    /// </summary>
    /// <param name="tab"> Tablet iterato </param>
    /// <returns> Tupla formata da tre variabili interi, ognuna delle quali contiene un punteggio </returns>
    public Tuple<int, int, int> Punteggio(Tablet tab)
    {
        int puntGHz = (int)Math.Round((decimal)tab._velGHz, MidpointRounding.AwayFromZero) * 10;
        int puntPol = (int)Math.Round((decimal)tab._dimPol, MidpointRounding.AwayFromZero);
        int puntmAh = (int)Math.Round((decimal)tab._capBatmAh / 1000, MidpointRounding.AwayFromZero);

        var ret = new Tuple<int, int, int>(puntGHz, puntPol, puntmAh);

        return ret;
    }
}
