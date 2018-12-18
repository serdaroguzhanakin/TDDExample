using MainProject;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EnBuyukBulucuTest()
        {
            int[] sayilar = new int[3];
            sayilar[0] = 4;
            sayilar[1] = 5;
            sayilar[2] = 6;


            Assert.That(EnBuyukBulucu.EnBuyukBul(sayilar), Is.EqualTo(6));
        }

        [Test]
        public void Test2()
        {
            int[] sayilar = new int[3];
            sayilar[0] = 7;
            sayilar[1] = 5;
            sayilar[2] = 2;

            Assert.That(EnBuyukBulucu.EnBuyukBul(sayilar), Is.EqualTo(7));
        }

        [Test]
        public void Test3()
        {

            int[] sayilar = new int[3];
            sayilar[0] = -7;
            sayilar[1] = -5;
            sayilar[2] = -2;


            int result = EnBuyukBulucu.EnBuyukBul(sayilar);


            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void TestNull()
        {
            int[] sayilar = null;
            int result = EnBuyukBulucu.EnBuyukBul(sayilar);

            Assert.That(result, Is.EqualTo(int.MinValue));
        }
                
        [TestCase(6, 6, 3, 2, 5)]
        [TestCase(int.MinValue)]
        [TestCase(-7, -8,-12,-7,-85)]
        public void Test5(int expected, params int[] sayilar)
        {
            int result = EnBuyukBulucu.EnBuyukBul(sayilar);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}