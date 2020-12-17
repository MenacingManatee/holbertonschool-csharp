using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sorted()
        {
            var l = new List<int>()
            {1, 2, 3, 4, 5, 6, 7, 8};
            int mx = MyMath.Operations.Max(l);
            Assert.AreEqual(mx, 8);
        }
        [Test]
        public void Test_sorted_rev()
        {
            var l = new List<int>()
            {9, 8, 7, 6, 5, 4, 3, 2, 1};
            int mx = MyMath.Operations.Max(l);
            Assert.AreEqual(mx, 9);
        }
        [Test]
        public void Test_unsorted()
        {
            var l = new List<int>()
            {1, 4, 3, 7, 5, 6, 2};
            int mx = MyMath.Operations.Max(l);
            Assert.AreEqual(mx, 7);
        }
        [Test]
        public void Test_double_digits()
        {
            var l = new List<int>()
            {1, 12, 32, 24, 51, 56, 57, 18};
            int mx = MyMath.Operations.Max(l);
            Assert.AreEqual(mx, 57);
        }
        [Test]
        public void Test_neg()
        {
            var l = new List<int>()
            {-11, -22, -13, -66, -5, -93};
            int mx = MyMath.Operations.Max(l);
            Assert.AreEqual(mx, -5);
        }
        [Test]
        public void Test_empty()
        {
            var l = new List<int>()
            {};
            int mx = MyMath.Operations.Max(l);
            Assert.AreEqual(mx, 0);
        }
    }
}