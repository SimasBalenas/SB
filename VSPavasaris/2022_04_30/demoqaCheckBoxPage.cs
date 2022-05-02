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
    class demoqaCheckBoxPage
    {
        private static IWebDriver driver;

        public demoqaCheckBoxPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        [Test]
        public void NavigateToDefaultPage()
        {
         driver.Url = "https://demoqa.com/checkbox";
        }
        public void ClosePopUp()
        {
            IWebElement poppup = driver.FindElement(By.Id("close-fixedban"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => poppup.Displayed);
            poppup.Click();
        }
    }
}
