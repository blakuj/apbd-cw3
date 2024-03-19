namespace ConsoleApp2;

public class Kontener
{
    private float _masaLadunku { get; set; }
    private float _wysokosc { get; set; }
    
    //samego kontenera
    private float _wagaWlasna { get; set; }
    private float _glebokosc { get; set; }
    private String _nrSeryjny { get; set; }
    
    private float _ladownosc { get; set; }

    private static int i;
    
    

    public Kontener(float masaLadunku, float wysokosc, float wagaWlasna, float glebokosc, float ladownosc)
    {
        _masaLadunku = masaLadunku;
        _wysokosc = wysokosc;
        _wagaWlasna = wagaWlasna;
        _glebokosc = glebokosc;
        _ladownosc = ladownosc;
        i++;
        _nrSeryjny = generujNrSeryjny();
    }

    public virtual void oproznijLadunek()
    {
        _masaLadunku = 0;
    }

    public virtual void zaladuj(float masaLadowana)
    {
        if (_masaLadunku+masaLadowana > _ladownosc)
        {
            Console.WriteLine("Nie mozna zaladowac tyle do kontenera");
        }
        else
        {
            _masaLadunku += masaLadowana;
        }

    }





    private String generujNrSeryjny()
    {
        return "KON-C" + i;


    }
    
    
    public override string ToString()
    {
        return $"Numer seryjny: {_nrSeryjny}, " +
               $"Masa ładunku: {_masaLadunku} kg, " +
               $"Wysokość: {_wysokosc} cm, " +
               $"Waga własna: {_wagaWlasna} kg, " +
               $"Głębokość: {_glebokosc} cm";
    }
    
    

    
    
    
}