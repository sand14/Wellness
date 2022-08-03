using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoApa
{
    public class InfoApa
    {
        public int cantitateapa;
        public InfoApa()
        {
            

        }

        public void Run()
        {
            Console.WriteLine("How much water do you drink in a day:");
            var cantitateapanevalidata = Console.ReadLine();
            while (!ValidateInput(cantitateapanevalidata))
            {
                Console.WriteLine("Introduce-ti o valoare intre 0 si 5:");
                cantitateapanevalidata = Console.ReadLine();
            }
            if (cantitateapa <= 2)
            {
                Console.WriteLine("Bea apa");
            }
            else
            {
                Console.WriteLine("Esti sanatos");
            }
        }
        public bool ValidateInput(string consoleinput)
        {
            bool isInputValid = false ;
            isInputValid = int.TryParse(consoleinput, out cantitateapa);
            if(isInputValid)
            {
                isInputValid = cantitateapa >= 1 && cantitateapa <= 3;
            }
            return isInputValid;
        }
    }
}
