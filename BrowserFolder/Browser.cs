using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QAHWTaskPage.Pages;
using System;

namespace QAHWTaskPage.BrowserFolder
{
    public class Browser
    {
        protected IWebDriver browser;

        public Browser()
        {
            CreateBrowser();
        }

        protected void CreateBrowser()
        {
            browser = new ChromeDriver();
        }

        protected void Navigate(string url)
        {
            browser.Navigate().GoToUrl(url);
        }

        public void CloseDriver()
        {
            browser.Close();
        }
    }
}
