using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

       
        public void TestReservation()
        {
            //Arrange
            var Res = new Reservation();

            //
            //Act

           var res= Res.CanBeCancelledBy(new User { IsAdmin = true });
            var per = new User();
            //var resl = Res.CanBeCancelledBy(per);
            Assert.IsTrue(res);

            //Assert
            Assert.IsTrue(res);
        }




        public void CanBEcancelledBySameuserreturnstrue()
        {

            var Res = new Reservation();
            var user = new User();
            Res.MadeBy = user;
             var res=Res.CanBeCancelledBy(user);

            Assert.IsTrue(res);





        }


    }
}
