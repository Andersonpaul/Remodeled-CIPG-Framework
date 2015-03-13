using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
   public class ListPage : BaseDriver 
    {
       public static ListPage ListPageObj;
       public ListPage(IWebDriver driver) : base(driver) { }
       public static void Click()
        {
           ListPageObj = new ListPage(Browser.driver);
           ListPageObj.PerformTest();           
           
        }

       private void PerformTest()
       {
           driver.FindElement(By.XPath("//div[@id='waxnav']/ul/li[2]/div/a/span")).Click();
       }
      
        public static void CheckLinks()
        {
            ListPageObj.PerformTest2();            
        }

        private void PerformTest2()
        {
            driver.FindElement(By.LinkText("View Branches")).Click();
            driver.FindElement(By.LinkText("View Fees")).Click();
            driver.FindElement(By.LinkText("View Merchants")).Click();
            driver.FindElement(By.LinkText("View Regions")).Click();
            driver.FindElement(By.LinkText("View User Roles")).Click();
            driver.FindElement(By.LinkText("View Users")).Click();
        }
        

   
    }
}
