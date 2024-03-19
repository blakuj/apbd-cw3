namespace ConsoleApp2;

public class GazowyKontener : Kontener, IHazardNotifier
{
    private String _nrSeryjny { get; set; }
    private double _cisnienie { get; set; }

    public GazowyKontener(float masaLadunku, float wysokosc, float wagaWlasna, float glebokosc, float ladownosc, double cisnienie) : 
        base(masaLadunku, wysokosc, wagaWlasna, glebokosc, ladownosc)
    {
        _cisnienie = cisnienie;
        _nrSeryjny = generujNrSeryjny();
    }


    public override void oproznijKontener()
    {
        dangerNotifier();
        MasaLadunku = (float)(MasaLadunku * 0.05);
    }

    public override void zaladujKontener(float masaLadowana)
    {
        base.zaladujKontener(masaLadowana);
    }

    public override string generujNrSeryjny()
    {
        return "KON-" + "G" + "-" + i++;
    }

    public override string ToString()
    {
        return base.ToString() +
               $" Ciśnienie: {_cisnienie} hPa.";
    }

    
    
    public void dangerNotifier()
    {
        Console.WriteLine("Kontener: " + ToString() + "\nMa w sobie jeszcze troche gazu!");
    }
    
}