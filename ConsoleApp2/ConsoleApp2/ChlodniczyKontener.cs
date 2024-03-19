namespace ConsoleApp2;

public class ChlodniczyKontener : Kontener
{
    private String _nrSeryjny { get; set; }
    private float _temperatura { get; set; }
    private string _rodzajProduktu { get; set; }

    public ChlodniczyKontener(float masaLadunku, float wysokosc, float wagaWlasna, float glebokosc,
        float ladownosc, string rodzajProduktu ) : 
        base(masaLadunku, wysokosc, wagaWlasna, glebokosc, ladownosc)
    {
        _nrSeryjny = generujNrSeryjny();
        _rodzajProduktu = rodzajProduktu;
        switch (rodzajProduktu)
        {
            case "Bananas":
                _temperatura = (float) 13.3;
                break;
            case "Chocolate":
                _temperatura = 18;
                break;
            case "Fish":
                _temperatura = 2;
                break;
            case "Meat":
                _temperatura = -15;
                break;
            case "Ice_Cream":
                _temperatura = -18;
                break;
            case "Frozen_pizza":
                _temperatura = -30;
                break;
            case "Cheese":
                _temperatura = (float)7.2;
                break;
            case "Sausages":
                _temperatura = 5;
                break;
            case "Butter":
                _temperatura = (float)20.5;
                break;
            case "Eggs":
                _temperatura = 19;
                break;
            default:
                _temperatura = 0;
                Console.WriteLine("Brak podanego produktu w magazynie.");
                break;
        }
    }


    public override string ToString()
    {
        return base.ToString()
        +$"Temperatura: {_temperatura}, "
        +$"Rodzaj produktu: {_rodzajProduktu}.";
    }

    public override string generujNrSeryjny()
    {
        return "KON-" + "C" + "-" + i++;
    }
    
    
    
    
    
}