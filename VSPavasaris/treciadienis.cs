using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSPavasaris
{
    class treciadienis
    {
      /*  private static IWebDriver driver;
        [OneTimeSetUp]
        
        public static void OneTimeSetup()
        { 
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Url = "https://testpages.herokuapp.com/styled/calculator";
        }

        [TestCase("2", "2", "4", TestName = " 2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = " -5 + 3 = -2")]
        [TestCase("a", "b", "err", TestName = " a + b = err")]
        public static void treciadienis0(string firstValue, string secondValue, string expectedResult)
        {
            
         
            IWebElement leftInput = driver.FindElement(By.Id("number1"));
            leftInput.Clear();
            leftInput.SendKeys(firstValue);
           
            IWebElement rightInput1 = driver.FindElement(By.Id("number2"));
            rightInput1.Clear();
            rightInput1.SendKeys(secondValue);
            
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            
            IWebElement actualResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, actualResult.Text, "answer: 4");
           
          
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
        */
        private static IWebDriver driver;
        [OneTimeSetUp]

        public static void OneTimeSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
        }

        [TestCase("25", "25.5", "50.5", false, TestName ="25 + 25,5 Integers only disable = 50,5")] // disable
        [TestCase("5", "25.5", "30", true, TestName = "5 + 25,5 Integers only enable = 30")] //enable
        [TestCase("1.99", "0.959", "2.949",false, TestName = "1,99 + 0,959 Integers only disable = 2,949 ")] // disable
        [TestCase("-1", "-9.99", "-10", true, TestName = "-1 + 9,99 Integers only enable = -10 ")] // enable
        public static void treciadienis10(string firstValue, string secondValue, string expectedResult, bool IsIntegersEnabled)
        {


            IWebElement firstInput = driver.FindElement(By.Id("number1Field"));
            firstInput.Clear();
            firstInput.SendKeys(firstValue);

            IWebElement secondInput = driver.FindElement(By.Id("number2Field"));
            secondInput.Clear();
            secondInput.SendKeys(secondValue);

            IWebElement integersOnlyCheckBox = driver.FindElement(By.Id("integersSelect"));
            if (IsIntegersEnabled != integersOnlyCheckBox.Selected)
            {
                integersOnlyCheckBox.Click();
            }

            IWebElement submitButton = driver.FindElement(By.Id("calculateButton"));
            submitButton.Click();

            IWebElement actualResult = driver.FindElement(By.Id("numberAnswerField"));
            Assert.AreEqual(expectedResult, actualResult.GetAttribute("value").ToString(), "Sum is wrong!");


        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}
