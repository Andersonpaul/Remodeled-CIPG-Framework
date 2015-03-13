using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
   public static class Reports
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.XPath("//div[@id='waxnav']/ul/li[5]/div/a/span")).Click();
        }

        public static void CheckLinks()
        {
            Browser.driver.FindElement(By.LinkText("Bank Transaction Report")).Click();
            Browser.driver.FindElement(By.LinkText("Audit Trail")).Click();
            Browser.driver.FindElement(By.LinkText("Settlement Report")).Click();
          //Browser.driver.FindElement(By.LinkText("Settlement Report 2")).Click();
            Browser.driver.FindElement(By.LinkText("Product Split Report")).Click();
            Browser.driver.FindElement(By.LinkText("Order Settlement Report")).Click();
        }

    }
}
