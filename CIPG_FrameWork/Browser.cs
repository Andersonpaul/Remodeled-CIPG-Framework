using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
    public static class Browser
    {
        public static IWebDriver driver;
        public static void setup(string URL)
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMinutes(5));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromMinutes(5));
            driver.Url = URL;
        }

        public static void LogOut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
