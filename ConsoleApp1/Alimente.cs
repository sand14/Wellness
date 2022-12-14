using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Alimente
{
    public class Alimente
    {

        public string Nume { get; set; }
        public string Descriere { get; set; }
        public DateTime DataExpirare { get; set; }
        public decimal Pret { get; set; }

        public Alimente(string nume, string descriere, DateTime dataDeExpirare, decimal pret)
        {
            this.Nume = nume;
            this.Descriere = descriere;
            this.DataExpirare = dataDeExpirare;
            this.Pret = pret;

            AplicaReducereInainteDeExpirare();
        }
        public void AplicaReducereInainteDeExpirare()
        {
            Console.WriteLine((DataExpirare.Date - DateTime.Now).TotalDays);
            if ((DataExpirare.Date - DateTime.Now).TotalDays <= 1)
            {
                Pret = Pret / 2;
            }
        }
    }
}
