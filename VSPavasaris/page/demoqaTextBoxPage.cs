﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSPavasaris.page
{
    class DemoqaTextBoxPage
    {
        private static IWebDriver _driver;

        private static IWebElement _fullNameInput => _driver.FindElement(By.Id("username"));
        private static IWebElement _submitButton => _driver.FindElement(By.Id("submit"));
        private static IWebElement _nameResult => _driver.FindElement(By.Id("name"));
        private static IWebElement _popup => _driver.FindElement(By.Id("close-fixedban"));
        public DemoqaTextBoxPage (IWebDriver webDriver)
        {
            _driver = new ChromeDriver();
        }
        public void NavigateToDefaultPage()
        {
            _driver.Url = "www.demoqa.com/text-box";
        }
        public void ClosePopUp()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => _popup.Displayed);
            _popup.Click();
        }
        public void InsertTextToFullNameField(string fullName)
        {
            _fullNameInput.Clear();
            _fullNameInput.SendKeys(fullName);
        }
        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }

        public void VerifyFullNameResult(string expectedResult)
        {
            Assert.AreEqual($"Name:{expectedResult}", _nameResult.Text, "Name is wrong!");
        }
    }
}
