﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSPavasaris.page;

namespace VSPavasaris.Test
{
    class DemoqaTextBoxTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
           _driver.Quit();
        }

        [Test]
        public static void TestFullNameInputField()
        {
            string fullName = "Simas";

            DemoqaTextBoxPage demoqaTextBoxPage = new DemoqaTextBoxPage(_driver);

            demoqaTextBoxPage.NavigateToDefaultPage();
            demoqaTextBoxPage.InsertTextToFullNameField(fullName);
            demoqaTextBoxPage.ClickSubmitButton();

            demoqaTextBoxPage.VerifyFullNameResult(fullName);
        }
    }
}
