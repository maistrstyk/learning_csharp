// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string a,b;
int cislo;
/*Console.WriteLine("Napis neco:");
a = Console.ReadLine();

Console.WriteLine(a + " napis cislo:");

b = Console.ReadLine();
cislo = int.Parse(b);
cislo= cislo * 2;
Console.WriteLine(cislo);
Console.WriteLine("---------------------------");
Console.WriteLine("Napis jmeno:");
a = Console.ReadLine();
Console.WriteLine("Napis vlastnost:");
b = Console.ReadLine();
Console.WriteLine(a + " " + b);
Console.WriteLine("---------------------------\n" +
    "Napis cislo:");

cislo = int.Parse(Console.ReadLine());
Console.WriteLine("Druha mocnina:" + (cislo * cislo));
Console.WriteLine("Napis polomer kruhu");
cislo = int.Parse(Console.ReadLine());
float obvod = 2 * cislo * 3.1415F;
float obsah = cislo * cislo * 3.1415F;
Console.WriteLine("Obvod kruhu je: " + obvod + 
  "\nObsah kruhu je: " + obsah);*/

Console.WriteLine("Zadejte první číslo:");
float c;
while (!float.TryParse(Console.ReadLine(), out c))
    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");





