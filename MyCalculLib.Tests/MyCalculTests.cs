using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalculLib.Tests
{
    [TestClass]
    public class MyCalculTests
    {
        double[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] mas2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        [TestMethod]
        public void Sum()
        {
            for (int i = 0; i < 10; i++)
            {
                double x = mas2[i];
                double y = mas1[i];
                int expected = 11;

                MyCalcul c = new MyCalcul();
                double actual = c.Sum(x, y);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void Min()
        {
            int expected = 9;
            for (int i = 0; i < 10; i++)
            {
                double x = mas2[i];
                double y = mas1[i];


                MyCalcul c = new MyCalcul();
                double actual = c.Min(x, y);

                Assert.AreEqual(expected, actual);
                expected = expected - 2;
            }
        }

        [TestMethod]
        public void Umn()
        {
            int expected = 10;
            int j = 4;
            for (int i = 0; i < 10; i++)
            {
                double x = mas2[i];
                double y = mas1[i];

                MyCalcul c = new MyCalcul();
                double actual = c.Umn(x, y);

                Assert.AreEqual(expected, actual);
                expected = expected + 2 * j;
                j = j - 1;
            }
        }
        double[] mas3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        double[] mas4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        [TestMethod]
        public void Del()
        {
            for (int i = 0; i < 10; i++)
            {
                double x = mas3[i];
                double y = mas4[i];
                int expected = 1;

                MyCalcul c = new MyCalcul();
                double actual = c.Del(x, y);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
