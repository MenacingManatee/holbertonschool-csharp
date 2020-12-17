using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_empty()
        {
            int res = Text.Str.CamelCase("");
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Test_null()
        {
            int res = Text.Str.CamelCase(null);
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Test_one()
        {
            int res = Text.Str.CamelCase("test");
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Test_many()
        {
            int res = Text.Str.CamelCase("theQuickBrownFox");
            Assert.AreEqual(4, res);
        }
    }
}