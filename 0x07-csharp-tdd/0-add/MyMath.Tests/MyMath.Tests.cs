using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Zero()
        {
            int res = MyMath.Operations.Add(0, 0);
            Assert.AreEqual(res, 0);
        }
        [Test]
        public void Test_Pos()
        {
            int res = MyMath.Operations.Add(7, 2);
            Assert.AreEqual(res, 9);
        }
        [Test]
        public void Test_Neg()
        {
            int res = MyMath.Operations.Add(-1, -3);
            Assert.AreEqual(res, -4);
        }
        [Test]
        public void Test_Pos_And_Neg()
        {
            int res = MyMath.Operations.Add(-1, 2);
            Assert.AreEqual(res, 1);
        }
        [Test]
        public void Test_Double_Digits()
        {
            int res = MyMath.Operations.Add(21, 33);
            Assert.AreEqual(res, 54);
        }
        [Test]
        public void Test_Large_Pos()
        {
            int res = MyMath.Operations.Add(1011111111, 1111111111);
            Assert.AreEqual(res, 2122222222);
        }
    }
}