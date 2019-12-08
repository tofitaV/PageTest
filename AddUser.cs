using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace QAHWTaskPage.Pages
{
    class AddUser
    {
        private IWebDriver driver;

        private IWebElement SignIn { get; set; }
        private IWebElement EmailField { get; set; }
        private IWebElement EnterButton { get; set; }

        public void AddUsers()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Url = "http://automationpractice.com/index.php";
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement webElement = wait.Until((d) => { return d.FindElement(By.ClassName("login")); });
                var SignIn = driver.FindElement(By.XPath("//*[@class='login']"));
                SignIn.Click();
            }
        }

    }
}
