using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using QAHWTaskPage.Utils;
using System.Threading;

namespace QAHWTaskPage.Pages
{
    public class Authentication : BrowserFolder.Browser
    {
        public Authentication() : base()
        {

        }

        public bool Auth()
        {
            Navigate("http://automationpractice.com/index.php");
            browser.FindElement(By.ClassName("login"), 5).Click();
            Thread.Sleep(2000);
            IWebElement emailAddr = browser.FindElement(By.Name("email"), 10);
            emailAddr.SendKeys("test@bk.ru");

            IWebElement passw = browser.FindElement(By.Id("passwd"), 10);
            passw.SendKeys("123456789");

            browser.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(2000);

            IWebElement account = browser.FindElement(By.ClassName("account"));
            string accountName = account.Text;

            if (accountName == "vlad kobrya")
                return true;
            else
                return false;
        }
    }
}
