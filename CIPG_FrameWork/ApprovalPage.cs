using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
  public static class ApprovalPage
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.XPath("//div[@id='waxnav']/ul/li[3]/div/a/span")).Click();
        }
    }
}
