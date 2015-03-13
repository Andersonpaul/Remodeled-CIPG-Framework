using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
  public static class SystemConfig
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.XPath("//div[@id='waxnav']/ul/li[4]/div/a/span")).Click();
        }

        public static void CheckLinks()
        {
            Browser.driver.FindElement(By.LinkText("Blacklist Component")).Click();
            Browser.driver.FindElement(By.LinkText("Payment Gateways")).Click();
            Browser.driver.FindElement(By.LinkText("Approval Configuration")).Click();
            Browser.driver.FindElement(By.LinkText("Application Configuration")).Click();
        }
    }
}
