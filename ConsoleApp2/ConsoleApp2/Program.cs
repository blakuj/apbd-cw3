


using ConsoleApp2;




GazowyKontener gazowyKontener = new GazowyKontener
    (0,10,1000,50,20000,450);

gazowyKontener.zaladujKontener(10000);

LiquidKontener liquidKontener = new LiquidKontener
    (0, 23, 1500, 23, 20000, "bezpieczny");
liquidKontener.zaladujKontener(10000);


ChlodniczyKontener chlodniczyKontener = new ChlodniczyKontener
    (10000, 12, 100, 30, 10000, "Bananas");

Statek statek = new Statek("Black Pearl",100,10,30);

List<Kontener> list = new();

list.Add(chlodniczyKontener);
list.Add(gazowyKontener);
list.Add(liquidKontener);

statek.zaladujStatek(list);


Statek statek2 = new Statek("Titanic",200, 10, 40);

statek.PrzeniesKontenerMiedzyStatkami(statek2,"KON-C-4");

// statek.zastapKontener("KON-L-2",chlodniczyKontener);


Console.WriteLine(statek);
Console.WriteLine(statek2);