using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace LearningSelenium
{
    [TestClass]
    public class FirstTestClass
    {
        [TestMethod]
        public void WikiSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.wikipedia.com");
            driver.Manage().Window.Maximize();
            List<String> textofanchors = new List<string>();
            ReadOnlyCollection<IWebElement> anchorLists = driver.FindElements(By.TagName("a"));
            foreach(IWebElement anchor in anchorLists)
            {
                textofanchors.Add(anchor.Text);
            }
            //driver.FindElement(By.Id("searchInput")).SendKeys("Selenium");
            //driver.FindElement(By.ClassName("pure-button")).Click();
            driver.Quit();
        }
        [TestMethod]
        public void ChromeTestMethod()
        {
            string ActualResult;
            string ExpectedResult = "Google";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            ActualResult = driver.Title;
            if (ActualResult.Contains(ExpectedResult))
            {
                Console.WriteLine("Passed");
                Assert.IsTrue(true, "Passed");
            }
            else
            {
                Console.Write("Failed");
            }
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void FireFoxTestMethod()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        public void IETestMethod()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }
    }
}
