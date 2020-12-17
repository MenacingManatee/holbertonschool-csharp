using NUnit.Framework;

namespace Text.Tests
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
            Assert.IsTrue(Text.Str.IsPalindrome("level"));
        }
        [Test]
        public void Test_caps()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("Racecar"));
        }
        [Test]
        public void Test_punc()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
        [Test]
        public void Test_fail()
        {
            Assert.IsFalse(Text.Str.IsPalindrome("Race"));
        }
        [Test]
        public void Test_empty()
        {
            Assert.IsTrue(Text.Str.IsPalindrome(""));
        }
    }
}