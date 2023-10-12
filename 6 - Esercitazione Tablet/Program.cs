using System;

class Program
{
    static void Main()
    { 
        Tablet[] tabl = new Tablet[5];

        for (int i = 0; i < tabl.Length; i++)
        {
            Console.Clear();

            Console.WriteLine($"Tablet numero {i + 1}: ");
            Console.Write($"Inserire la marca: ");
            string marca = Console.ReadLine();

            Console.Write("Inserire la velocita' in GHz: ");
            int valGHz = int.Parse(Console.ReadLine());

            Console.Write("Inserire la dimensione dello schermo in pollici: ");
            int dimPol = int.Parse(Console.ReadLine());

            Console.Write("Inserire la durata della batteria in mAh: ");
            int durBatmAh = int.Parse(Console.ReadLine());

            tabl[i] = new Tablet(marca, valGHz, dimPol, durBatmAh);
        }



    }
}

class Tablet
{
    private string _marca;
    private int _velGHz;
    private int _dimPol;
    private int _durBatmAh;

    public Tablet()
    {
        _marca = Marca;
        _velGHz = VelGHz;
        _dimPol = DimPol;
        _durBatmAh = DurBatmAh;
    }

    public Tablet(string marca, int velGHz, int dimPol, int durBatmAh)
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

    public int VelGHz
    {
        get { return _velGHz; }
        set { _velGHz = value; }
    }

    public int DimPol
    {
        get { return _dimPol; }
        set { _dimPol = value; }
    }

    public int DurBatmAh
    {
        get { return _durBatmAh; }
        set { _durBatmAh = value; }
    }


}