using System;
using CIPG_FrameWork;
using NUnit.Framework;

namespace TestCases
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Can_GoTo_01_URL()
        {
            Browser.setup("http://62.173.32.45/CIPGHarmonized/Login.aspx");
            CIPG.Login_test();
        }
       
       [Test]
       public void Can_GoTo_02_NewPage()
       {
           NewPage.Click();
       }
        
       [Test]
       public void Can_GoTo_2_ListPage()
       {
           ListPage.Click();
           ListPage.CheckLinks();
       }
       
      [Test]
       public void Can_GoTo_3_ApprovalsPage()
       {
           ApprovalPage.Click();
       }
      [Test]
       public void Can_GoTo_4_SystemConfigPage()
       {
           SystemConfig.Click();
           SystemConfig.CheckLinks();
       }
       [Test]
       public void Can_GoTo_5_ReportsPage()
       {
           Reports.Click();
           Reports.CheckLinks();
       }
       [Test]
       public void Can_GoTo_6_HelpPage()
       {
           Help.Click();
       }
       [Test]
       public void Can_LogOut()
       {
           Browser.LogOut();
       }
     
    }
    
}
