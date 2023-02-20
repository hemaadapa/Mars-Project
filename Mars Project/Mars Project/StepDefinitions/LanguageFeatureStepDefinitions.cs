using System;
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {



        SigninPage signinPageobj;
        LanguagePage languagePageobj;



        public LanguageFeatureStepDefinitions()
        {

            this.signinPageobj = new SigninPage();
            this.languagePageobj = new LanguagePage();
        }
        //LanguagePage languagePageobj = new LanguagePage();

        [When(@"I add Language to the profile page")]
        public void WhenIAddLanguageToTheProfilePage()
        {
            
            languagePageobj.Add();

        }

        [Then(@"The Language Record should be added successfully")]
        public void ThenTheLanguageRecordShouldBeAddedSuccessfully()
        {
          
            string languageRecord = languagePageobj.GetLanguageRecord(driver);
            string languageLevel = languagePageobj.GetLanguageLevel(driver);


            Assert.That(languageRecord  == "English", "Actual Record and Expected Record do not match.");
            Assert.That(languageLevel  == "Conversational", "Actual level and expected level do not match.");

        }

        [When(@"I edit '([^']*)' and '([^']*)' on an existing language record\.")]
        public void WhenIEditAndOnAnExistingLanguageRecord_(string language, string languagelevel)
        {
            languagePageobj.Edit(driver, language, languagelevel);
            //languagePageObj.EditLanguage();
            //languagePageObj.EditLangaugeLevel();

        }

        [Then(@"The record should have the edited '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheEditedAnd(string language, string languagelevel)
        {
            string updatedLanguageRecord = languagePageobj.GetUpdatedLanguageRecord(driver);
            string updatedLanguageLevel = languagePageobj.GetUpdatedLanguageLevel(driver);

            Assert.That(updatedLanguageRecord == language, "Record hasn't been updated.");
            Assert.That(updatedLanguageLevel == languagelevel, "Record hasn't been updated.");
        }


        





        [When(@"I delete a language record on my profile")]
        public void WhenIDeleteALanguageRecordOnMyProfile()
        {
            languagePageobj.Delete(driver);
        }



        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {

            string deletedLanguageRecord = languagePageobj.GetdeletedLanguageRecord(driver);
            string deletedLanguageLevel = languagePageobj.GetdeletedLanguageLevel(driver);  



            Assert.That(deletedLanguageRecord  != "null", "Language Record Hasn't been deleted.");
            Assert.That(deletedLanguageLevel   != "null", "Language Record Hasn't been deleted.");


        }
    }
}
