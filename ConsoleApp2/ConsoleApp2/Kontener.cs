
namespace ConsoleApp2;

public class Kontener
{
    private float _masaLadunku;
    private float _wysokosc;


    private float _wagaWlasna;
    private float _glebokosc;
    private String _nrSeryjny;

    private float _ladownosc;


    public static int i;
    
    

    public Kontener(float masaLadunku, float wysokosc, float wagaWlasna, float glebokosc, float ladownosc)
    {
        _masaLadunku = masaLadunku;
        _wysokosc = wysokosc;
        _wagaWlasna = wagaWlasna;
        _glebokosc = glebokosc;
        _ladownosc = ladownosc;
        _nrSeryjny = generujNrSeryjny();
        
    }

    public virtual void oproznijKontener()
    {
        _masaLadunku = 0;
    }

    public virtual void zaladujKontener(float masaLadowana)
    {
        if (_masaLadunku+masaLadowana > _ladownosc)
        {
            throw new OverflowException("Chcesz zaladowac zbyt duzo");
        }
        else
        {
            _masaLadunku += masaLadowana;
        }

    }


    public virtual String generujNrSeryjny()
    {
        return "KON"+"-" + "ABSTRACT" +"-" + i++;


    }
    
    
    public override string ToString()
    {
        return $"Numer seryjny: {_nrSeryjny}, " +
               $"Masa ładunku: {_masaLadunku} kg, " +
               $"Wysokość: {_wysokosc} cm, " +
               $"Waga własna: {_wagaWlasna} kg, " +
               $"Głębokość: {_glebokosc} cm, " +
               $"Ładowność: {_ladownosc} kg, ";
    }

    public float MasaLadunku
    {
        get => _masaLadunku;
        set => _masaLadunku = value;
    }

    public float Wysokosc
    {
        get => _wysokosc;
        set => _wysokosc = value;
    }

    public float WagaWlasna
    {
        get => _wagaWlasna;
        set => _wagaWlasna = value;
    }

    public float Glebokosc
    {
        get => _glebokosc;
        set => _glebokosc = value;
    }

    public string NrSeryjny
    {
        get => _nrSeryjny;
        set => _nrSeryjny = value;
    }

    public float Ladownosc
    {
        get => _ladownosc;
        set => _ladownosc = value;
    }
}