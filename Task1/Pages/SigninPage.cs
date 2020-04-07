using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace Task1
{
    class SigninPage
    {
   
        public void Signin(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/");

            //System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.XPath("//a[text()=\"Sign In\"]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys("mvpstudio.qa@gmail.com");
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("SydneyQa2018");
            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();  

        }

        
    }
}
