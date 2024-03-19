namespace ConsoleApp2;

public class LiquidKontener : Kontener, IHazardNotifier
{


    private String _nrSeryjny { get; set; }

    private String _rodzajLadunku { get; set; }

    public LiquidKontener(float masaLadunku, float wysokosc, float wagaWlasna, float glebokosc, float ladownosc,
        String rodzajLadunku)
        : base(masaLadunku, wysokosc, wagaWlasna, glebokosc, ladownosc)
    {
        _rodzajLadunku = rodzajLadunku;
        _nrSeryjny = generujNrSeryjny();
    }


    public void dangerNotifier()
    {
        Console.WriteLine("Kontener: " + ToString() + "\nMoze byc zagrozony nadmiernym ładunkiem");
    }

    public override String generujNrSeryjny()
    {
        return "KON-" + "L" + "-" + i++;
    }


    public override void zaladujKontener(float masaLadowana)
    {
        if (_rodzajLadunku.Equals("niebezpieczny") && masaLadowana+MasaLadunku > Ladownosc * 0.5)
        {
            dangerNotifier();
        }

        if (_rodzajLadunku.Equals("bezpieczny") && masaLadowana+MasaLadunku > Ladownosc * 0.9)
        {
            dangerNotifier();
        }

        base.zaladujKontener(masaLadowana);

    }

    public override void oproznijKontener()
    {
        base.oproznijKontener();
    }

    public override string ToString()
    {
        return base.ToString() + $" Rodzaj ładunku: {_rodzajLadunku}.";
    }
}