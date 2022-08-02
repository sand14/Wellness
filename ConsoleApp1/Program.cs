// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Alimente;
int scor =0;
int cantitateapa;

Console.WriteLine("Wellness");

Console.WriteLine("How much water do you drink in a day:");
var cantitateapanevalidata = Console.ReadLine();
while ((!(int.TryParse(cantitateapanevalidata, out cantitateapa))) && cantitateapa<=0 || cantitateapa>5 )
{
    Console.WriteLine("Introduce-ti o valoare intre 0 si 5:");
    cantitateapanevalidata = Console.ReadLine();
}

scor += cantitateapa;
Console.WriteLine(scor);

