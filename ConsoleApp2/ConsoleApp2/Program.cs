


using ConsoleApp2;

Kontener kontener = new Kontener(10,10,10,10,20);

Kontener kontener2 = new Kontener(10,10,10,10,20);


Console.WriteLine(kontener);

Console.WriteLine(kontener2);

kontener.oproznijLadunek();
kontener.zaladuj(20);
Console.WriteLine(kontener.ToString()); 