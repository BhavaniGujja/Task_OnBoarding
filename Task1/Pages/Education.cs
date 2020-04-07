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
    class Education
    {
        public void Addeducation(IWebDriver driver) // To Click on Education and add new
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@data-tab='third']")).Click(); // To click on education icon
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@data-tab='third']//div[@class=\'ui teal button ']")).Click(); //To click on add new to update education qualification

        }

        public void AddEducationDetail(IWebDriver driver) //To update details of education qualification
        {
            driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("La Trobe University"); //To enter university Name

            SelectElement selectElement = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']"))); //To select the name of the country
            SelectElement  countryname = selectElement;
            countryname.SelectByText("Australia");

            SelectElement selectElement1 = new SelectElement(driver.FindElement(By.XPath("//select[@name='title']"))); //To select the qualification title
            SelectElement Title = selectElement1;
            Title.SelectByText("M.Tech");

            driver.FindElement(By.XPath("//input[contains(@name,'degree')]")).SendKeys("Masters of Information and Communication Technology"); //To enter name of the degree

            SelectElement selectElement2 = new SelectElement(driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"))); //To select the year of passing
            SelectElement year = selectElement2;
            year.SelectByText("2019");

            driver.FindElement(By.XPath("//input[contains(@class,'ui teal button ')]")).Click(); //To save the details and click on add 

            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@data-tab='third']//div[@class=\'ui teal button ']")).Click(); //To click on add new
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[contains(@name,'instituteName')]")).Clear(); //To clear the text box of university name
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("JNTU University"); //To enter university Name

            SelectElement selectElement3 = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']"))); //To select the name of the country
            SelectElement countryname1 = selectElement3;
            countryname1.SelectByText("India");

            SelectElement selectElement4 = new SelectElement(driver.FindElement(By.XPath("//select[@name='title']"))); //To select the qualification title
            SelectElement Title1 = selectElement4;
            Title1.SelectByText("B.Tech");

            driver.FindElement(By.XPath("//input[contains(@name,'degree')]")).Clear(); //To clear the text box of the name of the degree
            driver.FindElement(By.XPath("//input[contains(@name,'degree')]")).SendKeys("Bachelors in Electronics and Communication Engg"); //To enter the name of the degree

            SelectElement selectElement5 = new SelectElement(driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"))); //To select the year of passing
            SelectElement year1 = selectElement5;
            year1.SelectByText("2015");

            driver.FindElement(By.XPath("//input[contains(@class,'ui teal button ')]")).Click(); // To click add button




        }
    }
}
