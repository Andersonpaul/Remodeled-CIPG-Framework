﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using CIPG_FrameWork.Properties;

namespace CIPG_FrameWork
{
  public static class ApprovalPage
    {
        public static void Click()
        {
            Browser.driver.FindElement(By.XPath(Settings.Default.Approval_Page)).Click();
        }
    }
}
