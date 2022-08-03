// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Alimente;
using ConsoleApp1.InfoApa;

int cantitateapa;
string luni = "2 Aug 2022 07:35:00 GMT";
DateTime data = DateTime.Parse(luni);
Console.WriteLine(data);
var alimente = new Alimente("Paine", "moara", DateTime.ParseExact("03.08.2022", "dd.MM.yyyy",null),10);
Console.WriteLine(alimente.Pret);
var infoapa = new InfoApa();
infoapa.Run();
int cantitateapa1 = infoapa.cantitateapa;