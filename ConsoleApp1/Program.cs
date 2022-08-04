// See https://aka.ms/new-console-template for more information

using System.Globalization;
using ConsoleApp1.Alimente;
using ConsoleApp1.InfoApa;
using ConsoleApp1;
using Enums;
using Lists.Classes;




/*List<Customer> customers = new();
customers.Add(new Customer());
customers = CreateCustomers();
List<Customer> result = new List<Customer>();
result.Add(customers[0]);
Console.WriteLine(result[0].Name);
result.AddRange(customers);
List<Customer> subRange = customers.GetRange((customers.Count - 1)/2, customers.Count/2+1);
Customer aCustomer = customers[2];




#region linq
var duplicates = customers.Concat(customers).OrderBy(c => c.Name);
List<string> names = duplicates.Select(c => c.Name).Distinct().ToList();
Console.WriteLine(names[0]);
#endregion linq

    static List<Customer> CreateCustomers()
    {
    List<Customer> customers = new List<Customer>()
    {
        new Customer
        {
            Name = "Customer One",
            ContractDate = DateTime.Today.AddYears(-1)
        },
        new Customer
        {
            Name = "Customer Two",
            ContractDate = DateTime.Today.AddYears(-2)
        },
        new Customer
        {
            Name = "Customer Three",
            ContractDate = DateTime.Today.AddYears(-3)
        },
        new Customer
        {
            Name = "Customer Four",
            ContractDate = DateTime.Today.AddYears(-4)
        },
        new Customer
        {
            Name = "Customer Five",
            ContractDate = DateTime.Today.AddYears(-5)
        },
    };

    return customers;
}

//bool? myBool = null;
//int? myInt = 1;
//string myString = null;
//int myOtherInt = 2;

//myInt = myOtherInt;
//Console.WriteLine(myInt);
//myOtherInt = myInt ?? 3;

//int? x = null;
//int? y = 9;
//int? result = x + y;
/*int[] myArray = new int[100];

for (int i = 0; i<100; i++)
{
    myArray[i] = i+1;
    if (i >= 90)
    {
        myArray[i] = myArray[i] * 5;
    }
}

int dwa = 0;



//var manyDays = WeekDay.Monday | WeekDay.Tuesday | WeekDay.Thursday;
//Console.WriteLine(manyDays.HasFlag(WeekDay.Friday));
/*Console.WriteLine(WeekDay.Monday);
int myNum = 500;
WeekDay friday = (WeekDay)myNum;
Console.WriteLine(friday);
/*Cities cities = new Cities();
int cantitateapa;
string luni = "2 Aug 2022 07:35:00 GMT";
DateTime data = DateTime.Parse(luni);
Console.WriteLine(data);
var alimente = new Alimente("Paine", "moara", DateTime.ParseExact("03.08.2022", "dd.MM.yyyy",null),10);
Console.WriteLine(alimente.Pret);
var infoapa = new InfoApa();
infoapa.Run();
int cantitateapa1 = infoapa.cantitateapa;*/

/*Span<int> sir=new int[25];

int suma = 0;
int i = 0;

foreach (ref int index in sir)
{
    index = i++;
    sir[i-1] = i;
    suma +=sir[i-1];
}

Console.WriteLine(suma);*/

Span<int> sir=new int[25];
int index2 = 0;
int i = 0;
int suma = 0;
int[] sir2 = new int[25];

foreach (ref int index in sir)
{
    index = i++;
    sir[i-1] = i;
    suma +=sir[i-1];
    if (sir[i - 1] % 2 == 0)
    {
        sir2[index2] = sir[i - 1];
        index2++;
    }
}


Console.WriteLine(suma);

