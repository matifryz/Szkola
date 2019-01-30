using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

 
using Szkola.Controllers;
using Szkola.Models;

namespace Aplikacja1.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void TestHomeController_IsNotNull ()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestHomeController_Equal()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [Test]
        public void TestKursController_IsNotNull()
        {
            //Arrange
            KursController controller = new KursController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(string.Empty, result.Model);
            

        }
        
        
    }
}
