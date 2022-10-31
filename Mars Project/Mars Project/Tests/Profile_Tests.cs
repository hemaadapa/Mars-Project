
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars_Project.Tests
{
    [TestFixture]
    public class Profile_Tests : CommonDriver
    {
        [SetUp]
        public void SigninActions()
        {

            //open the browser
             driver = new ChromeDriver();

            //Signin Page Object Initialization and Definition
              SigninPage signinPageobj = new SigninPage();
              signinPageobj.SigninSteps(driver);
        }
        [Test]
        public void AddDescriptionTest()
        {
            //Description Page Object initialiazation and Definition
            DescriptionPage descriptionPageobj = new DescriptionPage();

            //Add Record
            descriptionPageobj.Add(driver);

        }
        [Test]
        public void AddLanguageTest()
        {

            //Language page Object Initialization Nad Definition
            LanguagePage languagePageobj = new LanguagePage();
            languagePageobj.Add(driver);

        }
        [Test]
        public void EditLanguageTest()
        {
            //Edit Record
            LanguagePage languagePageobj = new LanguagePage();
            languagePageobj.Edit(driver);
        }
        [Test]
        public void DeleteLanguageTest()
        {

            //Delete Record
            LanguagePage languagePageobj = new LanguagePage();
            languagePageobj.Delete(driver);
        }
        [Test]
        public void AddSkillTest()
        {
            //Skill Page object Initialization and definition
            SkillPage skillPageObj = new SkillPage();
            skillPageObj.Add(driver);
        }
        [Test]
        public void EditSkillTest()
        {
            SkillPage skillPageObj = new SkillPage();
            skillPageObj.Edit(driver);

        }
        [Test]
        public void DeleteSkillTest()
        {
            SkillPage skillPageObj = new SkillPage();
            skillPageObj.Delete(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }



      

      
      
 
       

       
        

    }
}
