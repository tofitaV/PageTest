using QAHWTaskPage.BrowserFolder;
using QAHWTaskPage.Pages;
using System;

namespace QAHWTaskPage
{
    class Program : IDisposable
    {
        static Registration registration;
        static Authentication authentication;
        static void Main(string[] args)
        {
            authentication = new Authentication();
            //registration = new Registration();
            authentication.Auth();
            //registration.Registr();
            
        }

        public void Dispose()
        {
            //registration.CloseDriver();
            authentication.CloseDriver();
        }
    }
}
