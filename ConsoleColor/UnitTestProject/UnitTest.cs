using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console = ConsoleColor.Console;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("YA", System.ConsoleColor.Red);
        }
    }
}
