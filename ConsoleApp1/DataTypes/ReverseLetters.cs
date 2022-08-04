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
            StringBuilder sb = new StringBuilder(3);
            sb.Append(c + " " + b + " " + a);
            Result = sb.ToString();

            char[] d = new char[5];
            d[0] = c;
            d[1] = ' ';
            d[2] = b;
            d[3] = ' ';
            d[4] = a;
            Result = String.Format("{0,} {1} {2}",  c,b,a);
        }
    }
}
