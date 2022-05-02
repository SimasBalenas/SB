using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSPavasaris._2022_04_30
{
    class demoqaCheckBoxTest
    {
        private static IWebDriver driver;
        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/checkbox";
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
        [Test]
        public static void TestInputTest()
        {
         
            //isskleidzia langus
            IWebElement submitButton = driver.FindElement(By.CssSelector("button.rct-option:nth-child(1)"));
            submitButton.Click();

            // paspaudzia command
            IWebElement submitButton1 = driver.FindElement(By.CssSelector("li.rct-node-leaf:nth-child(2) > span:nth-child(1) > label:nth-child(2)"));
            submitButton1.Click();
        }

        [Test]
        public static void TestInputTest2()
        {

            //isskleidzia langus
            IWebElement submitButton = driver.FindElement(By.CssSelector("button.rct-option:nth-child(1)"));
            submitButton.Click();

            //paspaudzia desktop
            IWebElement submitButton1 = driver.FindElement(By.CssSelector("div.react-checkbox-tree:nth-child(1) > ol:nth-child(2) > li:nth-child(1) > ol:nth-child(2) > li:nth-child(1) > span:nth-child(1) > label:nth-child(2)"));
            submitButton1.Click();
            //einanat per selektorius kai #tree node reikia ikelti div.react-checkbox-tree:nth-child(1) o toliau lieka tas pats

            IWebElement submitButton2 = driver.FindElement(By.CssSelector("li.rct-node-parent:nth-child(3) > span:nth-child(1) > label:nth-child(2)"));
            submitButton2.Click();

        }
        [Test]
        public static void TestInputTest3()
        {

            //isskleidzia langus
            IWebElement submitButton = driver.FindElement(By.CssSelector("button.rct-option:nth-child(1)"));
            submitButton.Click();

            IWebElement submitButton1 = driver.FindElement(By.CssSelector("div.react-checkbox-tree:nth-child(1) > ol:nth-child(2) > li:nth-child(1) > ol:nth-child(2) > li:nth-child(1) > ol:nth-child(2) > li:nth-child(1) > span:nth-child(1) > label:nth-child(2)"));
            submitButton1.Click();

            IWebElement submitButton2 = driver.FindElement(By.CssSelector("li.rct-node:nth-child(4) > span:nth-child(1) > label:nth-child(2)"));
            submitButton2.Click();
         
        }
    }
}