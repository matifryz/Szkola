using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Szkola.Tests
{
    [TestFixture]
    public class UnitTest3
    {
        IWebDriver driver;
        [SetUp]
        public void Start()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void TestLogin()
        {

            driver.Url = "http://localhost:50867/Login.aspx";
            driver.FindElement(By.Id("UserName")).SendKeys("user123");
            driver.FindElement(By.Id("Password")).SendKeys("user123");
            driver.FindElement(By.Id("UserName")).SendKeys(Keys.Enter);
           
        }
        [Test]
        public void TestKurs()
        {
            driver.Url = "http://localhost:50867/Kurs";
            driver.FindElement(By.LinkText("Create New")).Click();
            driver.FindElement(By.Id("IdKurs")).SendKeys("111");
            driver.FindElement(By.Id("Nazwa")).SendKeys("Polski");
            driver.FindElement(By.Id("LStudent_w")).SendKeys("123");
            driver.FindElement(By.Id("Nazwa")).SendKeys(Keys.Enter);
        }
        [TearDown]
        public void Koniec()
        {
            //driver.Close();
        }

    }
}