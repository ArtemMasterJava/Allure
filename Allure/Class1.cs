using System;
using NUnit.Framework;

namespace Allure
{
    [TestFixture]

    class TestClass
    {
        [Test(Description = "XXX")]

        public void TestSample()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}