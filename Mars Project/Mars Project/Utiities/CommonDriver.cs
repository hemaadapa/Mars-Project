using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars_Project.Utiities
{
    public class CommonDriver
    {

        public static IWebDriver driver;

        [SetUp, OneTimeSetUp]
        public void SignInActions()
        {
            IWebDriver driver = new ChromeDriver();

            SigninPage signinPageObj = new SigninPage();
            signinPageObj.SigninSteps(driver);
            
            LanguagePage languagePageObj = new LanguagePage();

            SkillPage skillPageObj = new SkillPage();
        }
    }
}
