using NUnit.Framework;
using System;
using System.IO;

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
        public void Test_sm_1()
        {
            int[,] _sm_matrix = new int[,]
            {
                {0, 2, 4},
                {6, 8, 10}
            };
            int[,] res = MyMath.Matrix.Divide(_sm_matrix, 1);
            Assert.AreEqual(res, _sm_matrix);
            Assert.AreNotSame(res, _sm_matrix);
        }
        [Test]
        public void Test_sm_2()
        {
            int[,] _sm_matrix = new int[,]
            {
                {0, 2, 4},
                {6, 8, 10}
            };
            int[,] res = MyMath.Matrix.Divide(_sm_matrix, 2);
            int[,] expected = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5}
            };
            Assert.AreEqual(res, expected);
            Assert.AreNotSame(res, _sm_matrix);
        }
        [Test]
        public void Test_sm_0()
        {
            int[,] _sm_matrix = new int[,]
            {
                {0, 2, 4},
                {6, 8, 10}
            };
            try
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    string outp = string.Format("Num cannot be 0{0}", Environment.NewLine);
                    int[,] res = MyMath.Matrix.Divide(_sm_matrix, 0);
                    Assert.AreEqual(outp, sw.ToString());
                    Assert.AreEqual(res, null);
                }
            }
            catch (System.DivideByZeroException)
            {
                Assert.Fail();
                return;
            }
        }
        [Test]
        public void Test_null()
        {
            try
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    string outp = "";
                    int[,] res = MyMath.Matrix.Divide(null, 1);
                    Assert.AreEqual(outp, sw.ToString());
                    Assert.AreEqual(res, null);
                }
            }
            catch (System.Exception)
            {
                Assert.Fail();
                return;
            }
        }
    }
}