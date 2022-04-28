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
    class NamuDarbai
    {
        [Test]
        public static void NamuDarbai1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement leftInput = driver.FindElement(By.Id("number1"));
            //string left = "number1";
            leftInput.SendKeys("2");
            IWebElement rightInput1 = driver.FindElement(By.Id("number2"));
            //string right = "number2";
            rightInput1.SendKeys("2");
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement answerResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual($"answer: 4", answerResult.Text, "answer: 4");
            //  string atsakymas = "left" + "right";
            //  Assert.AreEqual($"answer: {"atsakymas"}", answerResult.Text, "answer: 4");
            //  Assert.AreEqual($"answer: {"left"+"right"}", answerResult.Text, "answer: 4");
            //  Assert.AreEqual($"answer: {atsakymas}", answerResult.Text, "answer: 4");
            driver.Quit();
        }

        [Test]
        public static void NamuDarbai2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement leftInput = driver.FindElement(By.Id("number1"));
            //string left = "number1";
            leftInput.SendKeys("-5");
            IWebElement rightInput1 = driver.FindElement(By.Id("number2"));
            //string right = "number2";
            rightInput1.SendKeys("3");
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement answerResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual($"answer: -2", answerResult.Text, "answer: -2");
            driver.Quit();
        }
        [Test]
        public static void NamuDarbai3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement leftInput = driver.FindElement(By.Id("number1"));
            //string left = "number1";
            leftInput.SendKeys("a");
            IWebElement rightInput1 = driver.FindElement(By.Id("number2"));
            //string right = "number2";
            rightInput1.SendKeys("b");
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            //string suma =  left + right;
            IWebElement answerResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual($"answer: err", answerResult.Text, "answer: err");
            driver.Quit();
        }
        [Test]
        public static void ND()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.sanebox.com/login";

            IWebElement saneboxInput = driver.FindElement(By.Id("email"));
            saneboxInput.SendKeys("labas312@gmx.com");
            IWebElement submitInput = driver.FindElement(By.Id("remember_me"));
            submitInput.Click();

            IWebElement submitInput1 = driver.FindElement(By.ClassName("button signup__button"));
            submitInput1.Click();
        }
        [Test]
        public static void ND1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.one.lt/";

            IWebElement oneInput = driver.FindElement(By.Name("username_email"));
            oneInput.SendKeys("labas312@gmx.com");
            
            IWebElement oneInput1 = driver.FindElement(By.Name("password"));
            oneInput1.SendKeys("sveiki312544");
            
            IWebElement submitInput = driver.FindElement(By.ClassName("btn btn-block btn-primary bg-gradient-blue border-0 rounded-pill"));
            submitInput.Click();

            IWebElement submitInput1 = driver.FindElement(By.Id("remember"));
            submitInput1.Click();

            IWebElement submitInput2 = driver.FindElement(By.ClassName("button signup__button"));
            submitInput2.Click();

           
        }
    }
}
