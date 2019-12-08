using OpenQA.Selenium;
using QAHWTaskPage.Utils;
using System;
using System.Threading;

namespace QAHWTaskPage.Pages
{
   public class Registration : BrowserFolder.Browser
    {
        public Registration() : base()
        {

        }

        public bool Registr()
        {
            Navigate("http://automationpractice.com/index.php");
            browser.FindElement(By.ClassName("login"), 5).Click();
            IWebElement emailEl =  browser.FindElement(By.Id("email_create"), 5);
            emailEl.SendKeys("test@bk.ru");
            browser.FindElement(By.Id("SubmitCreate")).Click();
            Thread.Sleep(2000);

            IWebElement firstName = browser.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("vlad");

            IWebElement secondName = browser.FindElement(By.Id("customer_lastname"));
            secondName.SendKeys("kobrya");

            IWebElement password = browser.FindElement(By.Id("passwd"));
            password.SendKeys("123456789");

            IWebElement firstNameAddr = browser.FindElement(By.Id("firstname"));
            firstNameAddr.SendKeys("vlad");

            IWebElement secondNameAddr = browser.FindElement(By.Id("lastname"));
            secondNameAddr.SendKeys("kobrya");

            IWebElement address = browser.FindElement(By.Id("address1"));
            address.SendKeys("street");

            IWebElement city = browser.FindElement(By.Id("city"));
            city.SendKeys("street");

            IWebElement state = browser.FindElement(By.Id("id_state"));
            state.Click();
            state.FindElements(By.TagName("option"))[new Random().Next(0, 50)].Click();


            IWebElement post = browser.FindElement(By.Id("postcode"));
            post.SendKeys("73000");

            IWebElement country = browser.FindElement(By.Id("id_country"));
            country.Click();
            country.FindElements(By.TagName("option"))[1].Click();

            IWebElement phone = browser.FindElement(By.Id("phone_mobile"));
            phone.SendKeys("+380666666666");

            IWebElement assign = browser.FindElement(By.Id("alias"));
            assign.SendKeys("my address");

            IWebElement submit = browser.FindElement(By.Id("submitAccount"));
            submit.Click();

            IWebElement account = browser.FindElement(By.ClassName("account"));
            string accountName = account.Text;

            if (accountName == "vlad kobrya")
                return true;
            else
                return false;
        }
        
    }
}
