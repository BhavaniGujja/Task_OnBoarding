using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Task1.StepDefinations
{
    [Binding]
    public class HomepageWithLogin_TestcasesSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"User is in home page and want to login")]
        public void GivenUserIsInHomePageAndWantToLogin()
        {
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/");

            //System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.XPath("//a[text()=\"Sign In\"]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys("mvpstudio.qa@gmail.com");
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("SydneyQa2018");
            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();
        }
        
        [Given(@"User is in home page and  want to create account")]
        public void GivenUserIsInHomePageAndWantToCreateAccount()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user enter the valid credentials with user name and password")]
        public void WhenUserEnterTheValidCredentialsWithUserNameAndPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user enter the invalid credentials with user name and password")]
        public void WhenUserEnterTheInvalidCredentialsWithUserNameAndPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on joiin , user enter First name, Last name, email, password and confirm password")]
        public void WhenClickOnJoiinUserEnterFirstNameLastNameEmailPasswordAndConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will be successfully Logged into the website")]
        public void ThenUserWillBeSuccessfullyLoggedIntoTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will be unsuccessfully Logged into the website and appropriate error message will be displayed")]
        public void ThenUserWillBeUnsuccessfullyLoggedIntoTheWebsiteAndAppropriateErrorMessageWillBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user will be creating a account successfully\.")]
        public void ThenUserWillBeCreatingAAccountSuccessfully_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
