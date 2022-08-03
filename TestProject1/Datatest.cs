using System;
using System.Collections.Generic;
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
        }
    }
}
