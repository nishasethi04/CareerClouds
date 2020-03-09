using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockingPractice;

namespace UnitTestBLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            AddBusinessLogic a = new AddBusinessLogic();

            //Act
            int result=a.Add();

            //Assume

            Assert.AreEqual(1, result);



            
        }
    }
}
