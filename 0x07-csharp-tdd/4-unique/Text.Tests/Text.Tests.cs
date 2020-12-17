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
        public void Test_repeating()
        {
            int res = Text.Str.UniqueChar("ssssssssssss");
            Assert.AreEqual(res, -1);
        }
        [Test]
        public void Test_empty()
        {
            int res = Text.Str.UniqueChar("");
            Assert.AreEqual(res, -1);
        }
        [Test]
        public void Test_null()
        {
            int res = Text.Str.UniqueChar(null);
            Assert.AreEqual(res, -1);
        }
        [Test]
        public void Test_3()
        {
            int res = Text.Str.UniqueChar("sssjssssssss");
            Assert.AreEqual(res, 3);
        }
        [Test]
        public void Test_name()
        {
            int res = Text.Str.UniqueChar("stevens");
            Assert.AreEqual(res, 1);
        }
        [Test]
        public void Test_multiple_unique()
        {
            int res = Text.Str.UniqueChar("abcdefg");
            Assert.AreEqual(res, 0);
        }
        [Test]
        public void Test_last()
        {
            int res = Text.Str.UniqueChar("ssssssssssssi");
            Assert.AreEqual(res, 12);
        }
    }
}