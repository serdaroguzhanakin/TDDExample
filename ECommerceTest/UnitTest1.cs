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
        public void LoginTest()
        {
            string userName = "";
            string passWord = "";

            bool result = Authentication.Login(userName, passWord);

            Assert.That(result, Is.True);

            
        }
    }
}