using NUnit.Framework;

namespace BowlingGameKata
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
            var test = new Foo();
            Assert.AreEqual(test, "blablabla");
        }
    }
}