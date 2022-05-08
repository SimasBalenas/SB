using Knygos.lt.Drivers;
using Knygos.lt.Page;
using Knygos.lt.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knygos.lt.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static KnygosPage _knygosPage;
        public static KnygosTest _knygosTest;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _knygosPage = new KnygosPage(Driver);
         //   _knygosTest = new KnygosTest(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            //     Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }
    }
}