using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
    public class NewPage : BaseDriver
    {
        public static void Click()
        {
            NewPage NewPageObj = new NewPage(Browser.driver);
            NewPageObj.PerformTest();
        }

        public NewPage(IWebDriver driver) : base(driver){}
         
        public void PerformTest()
        {
            driver.FindElement(By.CssSelector("a > span")).Click();
        }

    }
}
