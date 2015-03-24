using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using CIPG_FrameWork.Properties;

namespace CIPG_FrameWork
{
   public static class Reports
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.XPath(Settings.Default.Reports_Page)).Click();
        }

        public static void CheckLinks()
        {
            Browser.driver.FindElement(By.LinkText(Settings.Default.Bank_Report)).Click();
            Browser.driver.FindElement(By.LinkText(Settings.Default.Audit_Trail)).Click();
            Browser.driver.FindElement(By.LinkText(Settings.Default.Settlement_Report)).Click();
          //Browser.driver.FindElement(By.LinkText("Settlement Report 2")).Click();
            Browser.driver.FindElement(By.LinkText(Settings.Default.Product_Split_Report)).Click();
            Browser.driver.FindElement(By.LinkText(Settings.Default.Order_Settlement_Report)).Click();
        }

    }
}
