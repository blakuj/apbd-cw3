using System.Collections;
using System.Text;

namespace ConsoleApp2;

public class Statek
{
    private List<Kontener>? _konteners = new List<Kontener>();
    private string nazwa;

    private float predkosc { get; set; }

    private int maxIloscKontenerow { get; set; }

    private float maxWaga { get; set; }


    private float obecnaMasa { get; set; }


    public Statek(string nazwa,float predkosc, int maxIloscKontenerow,float maxWaga)
    {
        this.nazwa = nazwa;
        this.predkosc = predkosc;
        this.maxIloscKontenerow = maxIloscKontenerow;
        obecnaMasa = obliczenieMasy();
        this.maxWaga = maxWaga;
        
    }
    

    private float obliczenieMasy()
    {
        float obliczona = 0;
        foreach (Kontener kontener in _konteners)
        {
            obliczona += kontener.WagaWlasna + kontener.MasaLadunku;
        }

        obliczona /= 1000;
        return obliczona;
    }




    public void zaladujStatek(Kontener kontener)
    {
       
        if (obecnaMasa+(kontener.MasaLadunku/1000)+(kontener.WagaWlasna/1000) > maxWaga || _konteners.Count > maxIloscKontenerow)
        {
            Console.WriteLine("Nie mozna dodac tego kontenera, statek bedzie za ciezki");
            Console.WriteLine($"Obecna masa (tony) {obecnaMasa}");
        }
        else
        {
            _konteners.Add(kontener);
            obecnaMasa = (int)obliczenieMasy();
            Console.WriteLine("Zaladowano kontener: " + kontener);
            Console.WriteLine($"Obecna masa (tony) {obecnaMasa}");
        }



        

        
        
    }
    
    public void zaladujStatek(List<Kontener> kontenery)
    {
        foreach (Kontener kontener in kontenery)
        {
            if (obecnaMasa + (kontener.MasaLadunku / 1000) + (kontener.WagaWlasna / 1000) > maxWaga || _konteners.Count > maxIloscKontenerow)
            {
                obecnaMasa = obliczenieMasy();
                Console.WriteLine("Nie mozna dodac tego kontenera, statek bedzie za ciezki");
                Console.WriteLine($"Obecna masa (tony) {obecnaMasa}");
            }
            else
            {
                _konteners.Add(kontener);
                obecnaMasa = obliczenieMasy();
                Console.WriteLine("Zaladowano kontener: " + kontener);
                Console.WriteLine($"Obecna masa (tony) {obecnaMasa}");
            }


           
        }

        obecnaMasa = obliczenieMasy();

    }

    public void usunKontenerZeStatku(Kontener kontener)
    {
        _konteners.Remove(kontener);
        Console.WriteLine("Usunieto kontener: " + kontener);
        
        obecnaMasa = (int)obliczenieMasy();
    }

    public void zastapKontener(string zastepowanyNrSeryjny, Kontener nowy)
    {
        for (int i = 0; i < _konteners.Count; i++)
        {
            if (_konteners[i].NrSeryjny.Equals(zastepowanyNrSeryjny))
            {
                _konteners[i] = nowy;
                return;
            }
        }

     
    }



    public override string ToString()
    {
        return $"Statek {nazwa} ( "
               + $"predkosc: {predkosc} węzłów, "
               + $"Maksymalna ilosc kontenerow: {maxIloscKontenerow}, "
               + $"Maksymalna waga: {maxWaga} ton )" +
                "\nZAWARTOSC: " + wyswietlKontenery(_konteners);
    }

    public string wyswietlKontenery(List<Kontener>? konteners)
    {
        if (konteners == null || konteners.Count == 0)
        {
            return "Brak kontenerów.";
        }

        StringBuilder sb = new StringBuilder();
        foreach (Kontener kontener in konteners)
        {
            sb.AppendLine(kontener.ToString());
        }

        return sb.ToString();
    }



    public void PrzeniesKontenerMiedzyStatkami(Statek innyStatek, string nrSeryjnyKontenera)
    {
        Kontener kontenerDoPrzeniesienia = null;

       
        foreach (Kontener kontener in _konteners)
        {
            if (kontener.NrSeryjny.Equals(nrSeryjnyKontenera))
            {
                kontenerDoPrzeniesienia = kontener;
                break;
            }
        }

       
        if (kontenerDoPrzeniesienia != null)
        {
           
            if (innyStatek.obecnaMasa + (kontenerDoPrzeniesienia.MasaLadunku / 1000) + (kontenerDoPrzeniesienia.WagaWlasna / 1000) > innyStatek.maxWaga)
            {
                Console.WriteLine("Nie można przenieść tego kontenera, statek docelowy będzie za ciężki.");
            }
            else
            {
                
                _konteners.Remove(kontenerDoPrzeniesienia);
            
                
                innyStatek._konteners.Add(kontenerDoPrzeniesienia);

               
                obecnaMasa = (int)obliczenieMasy();
                innyStatek.obecnaMasa = (int)innyStatek.obliczenieMasy();

                Console.WriteLine($"Przeniesiono kontener o numerze seryjnym {nrSeryjnyKontenera} do innego statku.");
            }
        }
        else
        {
            Console.WriteLine($"Nie znaleziono kontenera o numerze seryjnym {nrSeryjnyKontenera} na tym statku.");
        }
    }

    
    
    
}