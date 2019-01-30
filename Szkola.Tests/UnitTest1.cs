using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using static System.Data.DataSet;
using System.Web.Mvc;
using Moq;
using NUnit.Framework; 
using Szkola.Controllers;
using Szkola.Models;
//using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Aplikacja1.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
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
        public void IndexKursController_Index_Equal()
        {
            //Arrange
            KursController controller = new KursController();
            //Act
            ViewResult result = controller.Index() as ViewResult;


            Assert.AreEqual("Index", result.View);

        }
        [Test]
        public void DetaleKusu() 
        {
            HomeController kursController = new HomeController();
            var wynik = kursController.User as ViewResult;
            Assert.AreEqual("Details", wynik.ViewName);
        }
        


    }

}