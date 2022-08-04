using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.DataTypes;

namespace TestProject1
{
    internal class Datatest
    {
        public class Tests
        {
            [Test]
            public void FirstTest()
            {
                // Arrange
                var reverseLetters = new ReverseLetters();

                // Act
                reverseLetters.EnterLetters('b', 'a', 't');
                // Assert
                Assert.That(reverseLetters.Result, Is.EqualTo("t a b"));
            }
            [Test]
            public void SecondTest()
            {
                var string1 = new string("12345");
                int nr = stringLenght.CalculateLenght(string1);
                Assert.That(nr, Is.EqualTo(5));
            }
            public void ThirdTest()
            {
                var string1 = "Kronsoft, Iqest";
                var index = string1.IndexOf(" I");
                string rezultat = string1.Substring(index+1);
                Assert.That(rezultat, Is.EqualTo("Iquest"));
            }
            [Test]
            public void ForthTest()
            {
                // Arrange
                var date = new DateTime(2022,08,03);

                // Act
                Console.WriteLine(date.ToString("d", new CultureInfo("ja-JP")));
                
                // Assert
            }

        }
    }
}
