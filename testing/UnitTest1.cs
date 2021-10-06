using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using PizzaStoreOnline;
using PizzaStoreOnline.Controllers;

namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index() { 

            HomeController controller = new HomeController();


            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
