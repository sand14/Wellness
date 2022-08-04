using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cities
    {
        public Cities()
        {
            Tuple<string, DateTime, int, DateTime, int>[] cities =
                { Tuple.Create("Los Angeles", new DateTime(1940, 1, 1), 1504277,new DateTime(1950, 1, 1), 1970358),
                  Tuple.Create("New York", new DateTime(1940, 1, 1), 7454995,new DateTime(1950, 1, 1), 7891957),
                  Tuple.Create("Chicago", new DateTime(1940, 1, 1), 3396808,new DateTime(1950, 1, 1), 3620962),
                  Tuple.Create("Detroit", new DateTime(1940, 1, 1), 1623452,new DateTime(1950, 1, 1), 1849568) 
                };
            var top = String.Format("{0,-11}{1,8}{2,12}{3,8}{4,12}{5,14}",
                                          "City", "Year", "Population", "Year", "Population", "Change (%)");
            Console.WriteLine(top);
            Console.WriteLine();
            foreach (var city in cities)
            {
                var output = String.Format("{0,-11}{1,8:yyyy}{2,12:N0}{3,8:yyyy}{4,12:N0}{5,10:P}",
                                       city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
                                       (city.Item5 - city.Item3) / (double)city.Item3);
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    
    }
}
