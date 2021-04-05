using NUnit.Framework;
using System;

namespace OsNet
{
    [TestFixture]
    public class UnitTest1
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Simple .Net test");
        }
        [Test]
        public void AddTest()
        {

            int val1 = 0;
            int val2 = 1;
            int sum = val1 + val2;
            NUnit.Framework.Assert.AreEqual(sum, Add(val1, val2));
        }


        public int Add(int val1,int val2)
        {
            return val1 + val2;
        }
    }
}
