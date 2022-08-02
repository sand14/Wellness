// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Alimente;
int scor =0;
int cantitateapa;
string luni = "2 Aug 2022 07:35:00 GMT";
DateTime data = DateTime.Parse(luni);
Console.WriteLine(data);
var alimente = new Alimente("Paine", "moara", DateTime.ParseExact("01.08.2022", "dd.MM.yyyy",null),10);
Console.WriteLine(alimente.Pret);
Console.WriteLine("How much water do you drink in a day:");
var cantitateapanevalidata = Console.ReadLine();
while ((!(int.TryParse(cantitateapanevalidata, out cantitateapa))) && cantitateapa<=0 || cantitateapa>5 )
{
    Console.WriteLine("Introduce-ti o valoare intre 0 si 5:");
    cantitateapanevalidata = Console.ReadLine();
}

scor += cantitateapa;
Console.WriteLine(scor);
