using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Task1.StepDefinations
{
    [Binding]
    public class UnknownSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"User is in profile page and want to add description")]
        public void GivenUserIsInProfilePageAndWantToAddDescription()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is in profile page and want to click on Languages")]
        public void GivenUserIsInProfilePageAndWantToClickOnLanguages()
        {
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[contains(.,'Languages')]")).Click(); //To click on Languages icon
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button ')])[1]")).Click(); //To click on add new in Languages
        }
        
        [Given(@"User is in profile page and want to add languages and details")]
        public void GivenUserIsInProfilePageAndWantToAddLanguagesAndDetails()
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
        
        [Given(@"User is in profile page and want delete the languages saved")]
        public void GivenUserIsInProfilePageAndWantDeleteTheLanguagesSaved()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is in profile page and want to click on skills")]
        public void GivenUserIsInProfilePageAndWantToClickOnSkills()
        {
            driver.FindElement(By.XPath("//a[contains(@data-tab,'second')]")).Click(); // To click on skills icon
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]")).Click(); // To click on add new icon to update details of skills

        }

        [Given(@"User is in profile page and want to add new number of skills")]
        public void GivenUserIsInProfilePageAndWantToAddNewNumberOfSkills()
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
        
        [Given(@"User is in profile page and want to delete saved skills")]
        public void GivenUserIsInProfilePageAndWantToDeleteSavedSkills()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is in profile page and want to click on Education icon")]
        public void GivenUserIsInProfilePageAndWantToClickOnEducationIcon()
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@data-tab='third']")).Click(); // To click on education icon
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@data-tab='third']//div[@class=\'ui teal button ']")).Click(); //To click on add new to update education qualification

        }

        [Given(@"User is in profile page and want click to add number of Education qualifications")]
        public void GivenUserIsInProfilePageAndWantClickToAddNumberOfEducationQualifications()
        {
            driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("La Trobe University"); //To enter university Name

            SelectElement selectElement = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']"))); //To select the name of the country
            SelectElement countryname = selectElement;
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

        [Given(@"User is in profile page and want to delete education details")]
        public void GivenUserIsInProfilePageAndWantToDeleteEducationDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is in profile page and  want to click on Certification icon")]
        public void GivenUserIsInProfilePageAndWantToClickOnCertificationIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is in profile page and want to click to add number of certifications")]
        public void GivenUserIsInProfilePageAndWantToClickToAddNumberOfCertifications()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is in profile page and want to delete saved certification details")]
        public void GivenUserIsInProfilePageAndWantToDeleteSavedCertificationDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on edit to describe in words allowed to write (.*) characters word limit")]
        public void WhenUserClickOnEditToDescribeInWordsAllowedToWriteCharactersWordLimit(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on language icon")]
        public void WhenUserClickOnLanguageIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on add new, enter the name and level of language")]
        public void WhenUserClickOnAddNewEnterTheNameAndLevelOfLanguage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user select the which language should be deleted, click on close button to delete")]
        public void WhenUserSelectTheWhichLanguageShouldBeDeletedClickOnCloseButtonToDelete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on Skills icon")]
        public void WhenUserClickOnSkillsIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on Add new, enter the name and level of skill")]
        public void WhenUserClickOnAddNewEnterTheNameAndLevelOfSkill()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user select the which skill should deleted, click on close button to delete in skills")]
        public void WhenUserSelectTheWhichSkillShouldDeletedClickOnCloseButtonToDeleteInSkills()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on Education icon")]
        public void WhenUserClickOnEducationIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on Add new, enter the all the details mentioned")]
        public void WhenUserClickOnAddNewEnterTheAllTheDetailsMentioned()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user select the which education should deleted, click on close button to delete in education")]
        public void WhenUserSelectTheWhichEducationShouldDeletedClickOnCloseButtonToDeleteInEducation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on certification icon")]
        public void WhenUserClickOnCertificationIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user select the which certification should deleted, click on close button to delete in certification")]
        public void WhenUserSelectTheWhichCertificationShouldDeletedClickOnCloseButtonToDeleteInCertification()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the text will be saved in the description about the user")]
        public void ThenTheTextWillBeSavedInTheDescriptionAboutTheUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"navigated to click on Add new to add Languages upto four\.")]
        public void ThenNavigatedToClickOnAddNewToAddLanguagesUptoFour_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on add button for successful saving of language details\.")]
        public void ThenClickOnAddButtonForSuccessfulSavingOfLanguageDetails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user selected language is successfully deleted\.")]
        public void ThenUserSelectedLanguageIsSuccessfullyDeleted_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"navigated to click on Add new to add skills with deatails\.")]
        public void ThenNavigatedToClickOnAddNewToAddSkillsWithDeatails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on Add button for successful saving of skill details\.")]
        public void ThenClickOnAddButtonForSuccessfulSavingOfSkillDetails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user selected skill is successfully deleted\.")]
        public void ThenUserSelectedSkillIsSuccessfullyDeleted_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"navigated to click on Add new to add Education with details\.")]
        public void ThenNavigatedToClickOnAddNewToAddEducationWithDetails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on Add button for successful saving of Education details\.")]
        public void ThenClickOnAddButtonForSuccessfulSavingOfEducationDetails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user selected education details are successfully deleted\.")]
        public void ThenUserSelectedEducationDetailsAreSuccessfullyDeleted_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"navigated to click on Add new to add certification with details\.")]
        public void ThenNavigatedToClickOnAddNewToAddCertificationWithDetails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on Add button for successful saving of Certification details\.")]
        public void ThenClickOnAddButtonForSuccessfulSavingOfCertificationDetails_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user selected certification details are successfully deleted\.")]
        public void ThenUserSelectedCertificationDetailsAreSuccessfullyDeleted_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
