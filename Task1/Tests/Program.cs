using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace Task1
{
    [TestFixture]
    class Program
    {
        //private object driver;
        static void Main(string[] args)
        {
         
           // System.Threading.Thread.Sleep(1000);
           // Program pro = new Program();
     
           // pro.SigninSuccess(driver);

            //pro.AddingLanguage(driver);

            //System.Threading.Thread.Sleep(1000);
            //pro.AddingEducation(driver);

            // System.Threading.Thread.Sleep(1000);
            // pro.AddingSkills(driver);


        }

        IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void SigninSuccess() //Method to call SiginPage class
        {
            SigninPage signin = new SigninPage(); //Object created for SigninPage class
            signin.Signin(driver); //By using object we are calling a method from SigninPage to signin a website
        }
       
        
       [Test]
        public void AddingLanguage() //Method to call Languages class
        {
            Languages lang = new Languages(); //Object created for Languages
            lang.addlanguage(driver);  //By using object we are calling a method to click on languages from languages class
            lang.addnewlanguage(driver); //By using object we are calling a method to update details of language from language class
        }
        
        [Test]
        public void AddingSkills() //Method to call Skills class
        {
            Skills skills = new Skills(); //Object created for Skills
            skills.addskill(driver);  //By using we are calling a method to click skills and add new skill from Skills class
            skills.addingskill(driver); //By using object we are calling a method to update details of skills from skills class 
        }
        [Test]
        public void AddingEducation() //Method to call Education class
        {
            Education edu = new Education(); //Object created for Education
            edu.Addeducation(driver); //By using we are calling a method to click education and add education qualification from Education class
            edu.AddEducationDetail(driver); //By using object we are calling a method to update details of education from Education class
        }

    }

    
}
