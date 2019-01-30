using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Szkola.Tests
{
    [TestFixture]
    public class UnitTest3
    {
        [Test]
        public void TestApp()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:50867/Login.aspx";
            //driver.Close();
        }
    }
}
