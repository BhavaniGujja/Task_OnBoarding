using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
namespace Task1
{
    class Skills
    {
        public void addskill(IWebDriver driver) //To click on skills icon and add new 
        {
            driver.FindElement(By.XPath("//a[contains(@data-tab,'second')]")).Click(); // To click on skills icon
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]")).Click(); // To click on add new icon to update details of skills

        }

        public void addingskill(IWebDriver driver) // To update details of skills
        {
            driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).SendKeys("Higher Typing"); //To click on name of the skills box and enter the skill name

            SelectElement expert = new SelectElement(driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]"))); //To select the level of the skill
            expert.SelectByText("Expert");

            driver.FindElement(By.XPath("(//input[contains(@class,'ui teal button ')])[1]")).Click(); //To save the skills details to add
            driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]")).Click(); //To click on add new

            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).Clear(); //To clear the text in skills name box

            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).SendKeys("Writing Blogs"); //To click on name of the skills box and enter the other skill name
            SelectElement Beginner = new SelectElement(driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]"))); //To select the level of the skill
            Beginner.SelectByText("Beginner");

            driver.FindElement(By.XPath("(//input[contains(@class,'ui teal button ')])[1]")).Click(); //To save the skills details to add
        }

      
    }
}

