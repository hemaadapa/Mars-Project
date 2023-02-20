using System;
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class DescriptionFeatureStepDefinitions :CommonDriver
    {

        SigninPage signinPageobj;
        DescriptionPage descriptionPageobj;


        
        public DescriptionFeatureStepDefinitions()
        {
            
            this.signinPageobj = new SigninPage();
            this.descriptionPageobj = new DescriptionPage();
        }


        [Given(@"I logged into the Mars Portal")]
        public void GivenILoggedIntoTheMarsPortal()
        {

        }
        //{

        //    driver = new ChromeDriver();
        //    SigninPage signinPageobj = new SigninPage();
        //    signinPageobj.SigninSteps(driver);
        
        //}

        [When(@"I Add Description to the Profile page")]
        public void WhenIAddDescriptionToTheProfilePage()
        {
            DescriptionPage descriptionPageobj = new DescriptionPage();
            descriptionPageobj.Add();

        }

        [Then(@"Description should be added successfully\.")]
        public void ThenDescriptionShouldBeAddedSuccessfully_()
        {
            DescriptionPage descriptionPageobj = new DescriptionPage();

            string savedDescription = descriptionPageobj.GetSavedDescription(driver);


            Assert.That(savedDescription == "I am a Self-driven, value-added person.", "Expected code and result code are not same.");


        }
    }
}
