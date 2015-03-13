using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace CIPG_FrameWork
{
   
    public static class CIPG
    {
        public static void Login(string username, string password)
        {
            Browser.driver.FindElement(By.Id(LoginDetails_Parameters.Username_TextBox)).Clear();
            Browser.driver.FindElement(By.Id(LoginDetails_Parameters.Username_TextBox)).SendKeys(username);
            Browser.driver.FindElement(By.Id(LoginDetails_Parameters.Password_TextBox)).Clear();
            Browser.driver.FindElement(By.Id(LoginDetails_Parameters.Password_TextBox)).SendKeys(password);
            Browser.driver.FindElement(By.Id(LoginDetails_Parameters.LoginButton)).Click();                       
        }

        public static void Login_test()
        {
            Login(LoginDetails_Parameters.empty_username, LoginDetails_Parameters.empty_password);
            Login(LoginDetails_Parameters.wrong_username, LoginDetails_Parameters.password);
            Login(LoginDetails_Parameters.Special_Xters, LoginDetails_Parameters.wrong_password);
            Login(LoginDetails_Parameters.empty_username, LoginDetails_Parameters.Special_Xters);
            Login(LoginDetails_Parameters.Special_Xters, LoginDetails_Parameters.Special_Xters);
            Login(LoginDetails_Parameters.username, LoginDetails_Parameters.password);            
            IAlert alert = Browser.driver.SwitchTo().Alert();
            string str = alert.Text;
            Console.Write(str);
            alert.Accept();
        }

        
    }
}
