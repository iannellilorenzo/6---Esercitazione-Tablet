using System;

class Program
{
    static void Main()
    {

    }
}

class Tablet
{
    //  la marca, la velocità (espressa in GHz), la dimensione dello schermo (espresso in pollici) e la
    //  durata della batteria(espressa in mAh, milliampere-ora).

    private string _marca;
    private double _velGHz;
    private int _dimPol;
    private int _durBatmAh;

    public Tablet()
    {

    }

    public Tablet(string marca, double velGHz, int dimPol, int durBatmAh)
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