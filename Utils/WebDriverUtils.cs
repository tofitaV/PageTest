using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAHWTaskPage.Utils
{
    static class WebDriverUtils
    {
        public static IWebElement FindElement(this IWebDriver DriverObj, By by, int TimeOut = 5)
        {
            try
            {
                WebDriverWait Wait1 = new WebDriverWait(DriverObj, TimeSpan.FromSeconds(TimeOut));
                var WaitS = Wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
                return WaitS[0];
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}
