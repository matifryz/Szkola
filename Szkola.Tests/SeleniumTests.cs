using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Szkola.Tests
{
    [TestFixture]
    public class SeleniumTests
    {
        
            IWebDriver driver;
            [SetUp]
            public void Initializer()
            {
                driver = new FirefoxDriver();
            }
            [Test]
            public void LoginTest()
            {
                driver.Url = "http://localhost:50867/Login.aspx";
                driver.FindElement(By.Id("UserName")).SendKeys("user123");
                driver.FindElement(By.Id("Password")).SendKeys("user123");
            driver.FindElement(By.Name("ctl04")).SendKeys(Keys.Enter);
            }
        [Test]
        public void AddNewKurs()
        {
            driver.Url = "http://localhost:50867/Kurs/Create";
            
            driver.FindElement(By.Id("IdKurs")).SendKeys("4");
            driver.FindElement(By.Id("Nazwa")).SendKeys("Polski");
            driver.FindElement(By.Id("LStudent_w")).SendKeys("22");
            driver.FindElement(By.Id("LStudent_w")).SendKeys(Keys.Enter);
        }
            [TearDown]
            public void Endtest()
            {
                //driver.Close();
            }

       
    }
    
}
