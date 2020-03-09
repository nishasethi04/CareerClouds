using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCDemo.Controllers;
using MVCDemo.Controllers;
using MVCUIGameClubUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCDemo.Controllers.Tests
{
    [TestClass()]
    public class MembersControllerTests
    {
        [TestMethod()]
        public void IndexAction_Returns_IndexView()
        {
            //Arrange

            MembersController mc = new MembersController();
            string expectedviewname = "Index";

            //Act
            ViewResult actualresult=mc.Index() as ViewResult;
            string actualviewname = actualresult.ViewName;


            //Assert

            Assert.AreEqual(expectedviewname, actualviewname);



        }
    }
}