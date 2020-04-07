using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
namespace Task1
{
    class Languages
    {
        public void addlanguage(IWebDriver driver) 
        {
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[contains(.,'Languages')]")).Click(); //To click on Languages icon
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button ')])[1]")).Click(); //To click on add new in Languages
            
        }
        public void addnewlanguage(IWebDriver driver) //Update details of Languages which we want to add
        {
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("English"); //To enter language name
            SelectElement english = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']"))); //To select the level of language
            english.SelectByText("Fluent");
            driver.FindElement(By.XPath("//input[@value='Add']")).Click(); //To save the details entered about language of English


            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button ')])[1]")).Click(); //To click on languages icon
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[contains(@name,'name')]")).Clear();// To clear the text in language name box



            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[contains(@name,'name')]")).SendKeys("Telugu"); //To enter other language name
            SelectElement telugu = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']"))); //To select the level of language
            telugu.SelectByText("Fluent");
            driver.FindElement(By.XPath("//input[@value='Add']")).Click(); //To save the details entered about language of Telugu

        }

        internal void addlanguage(object driver)
        {
            throw new NotImplementedException();

        }
        internal void addnewlanguage(object driver)
        {
            throw new NotImplementedException();

        }


    }
}
