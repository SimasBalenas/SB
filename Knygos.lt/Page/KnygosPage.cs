using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Knygos.lt.Page
{
    class KnygosPage : BasePage
    {
        private const string PageAddress = "https://www.knygos.lt/";
       // private static IWebElement _popup => Driver.FindElement(By.CssSelector("#consent > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-custom.cc-bottom > div.cc-compliance.cc-highlight > a.cc-btn.cc-allow"));

       private IWebElement submitButton => Driver.FindElement(By.ClassName("cc-btn cc-allow"));
        public KnygosPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        //public void ClosePopUp()
        //{
        //    GetWait(10).Until(d => _popup.Displayed);
        //    _popup.Click();
        //}
       

        public void AcceptCookies()
        {
            Cookie myCookie = new Cookie("PHPSESSID",
                "p4p9bnigjqqglc8p7s5kveb6c5",
                "www.knygos.lt",
                "/",
                DateTime.Now.AddDays(5));

            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
        }
    }
}

