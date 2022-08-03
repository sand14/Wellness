using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataTypes
{
    public class ReverseLetters
    {
        public string Result { get; set; }
        public void EnterLetters(char a,char b,char c)
        {

            Result = c.ToString() + " " + b +" " + a;
        }
    }
}
