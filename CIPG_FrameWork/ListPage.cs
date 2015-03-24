using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using CIPG_FrameWork.Properties;

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
           driver.FindElement(By.XPath(Settings.Default.List_Page)).Click();
       }
      
        public static void CheckLinks()
        {
            ListPageObj.PerformTest2();            
        }

        private void PerformTest2()
        {
            driver.FindElement(By.LinkText(Settings.Default.View_Branches)).Click();
            driver.FindElement(By.LinkText(Settings.Default.View_Fees)).Click();
            driver.FindElement(By.LinkText(Settings.Default.View_Merchants)).Click();
            driver.FindElement(By.LinkText(Settings.Default.View_Regions)).Click();
            driver.FindElement(By.LinkText(Settings.Default.View_User_Roles)).Click();
            driver.FindElement(By.LinkText(Settings.Default.View_Users)).Click();
        }
        

   
    }
}
