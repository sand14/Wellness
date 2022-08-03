using ConsoleApp1.Alimente;
using ConsoleApp1.InfoApa;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arange - pregatesti datele
            var alimente = new Alimente("Paine", "moara", DateTime.ParseExact("01.08.2022", "dd.MM.yyyy", null), 10);
            // Act - rulezi actiunea

            // Assert = verifici
            Assert.That(alimente.Pret, Is.EqualTo(5));
            Assert.That(alimente.DataExpirare, Is.LessThan(DateTime.Now));

        }

        [Test]
        public void Test2()
        {
            var infoApa = new InfoApa();
            var result1 = infoApa.ValidateInput("0");
            Assert.IsFalse(result1);

        }
    }
}

      