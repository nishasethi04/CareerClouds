using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;

namespace UnitTestProject2
{
    [TestClass]
    public class CheckSum
    {
        [TestMethod]
        public void Testaequalsb()
        {
            var s = new sum();
            if(s.x>s.y)
            {
                Console.WriteLine("Division is ", s.x / s.y); 
            }
            else if(s.x<s.y)
            {
                Console.WriteLine("Cannot perform division");

            }
            else if(s.x==s.y)
            {
                Console.WriteLine("Answer is ",1);
            }
            Assert.
        }

    }
}
