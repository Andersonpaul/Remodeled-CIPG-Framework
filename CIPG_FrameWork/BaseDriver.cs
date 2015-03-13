using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CIPG_FrameWork
{
   public class BaseDriver
    {
       public IWebDriver driver;

        public BaseDriver(IWebDriver driver)
        {
            this.driver = driver;
        }
        
    }
}
