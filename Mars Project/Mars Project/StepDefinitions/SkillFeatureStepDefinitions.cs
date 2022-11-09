using System;
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class SkillFeatureStepDefinitions : CommonDriver
    {
        SkillPage skillPageObj = new SkillPage();

        [When(@"I add Skill on my profile page")]
        public void WhenIAddSkillOnMyProfilePage()
        {
            skillPageObj.Add();
        }



        [Then(@"The skill record should be added successfully")]
        public void ThenTheSkillRecordShouldBeAddedSuccessfully()
        {
            string skillRecord = skillPageObj.GetskillRecord(driver);
            string skillLevel = skillPageObj.GetSkillLevel(driver);


            Assert.That(skillRecord == "HTML", "Skill Record Hasn't Saved.");
            Assert.That(skillLevel == "Intermediate", "Skill Record Hasn't saved.");

        }

        [When(@"I edit '([^']*)' and '([^']*)' on an existing skill record")]
        public void WhenIEditAndOnAnExistingSkillRecord(string skill, string skilllevel)
        {
            skillPageObj.Edit(driver, skill, skilllevel);
        }



        [Then(@"The record should have the updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string skill, string skilllevel)
        {
            string updatedSkillLanguage = skillPageObj.GetskillRecord(driver);
            string updatedSkilllLevelRecord = skillPageObj.GetupdatedSkillLevelRecord(driver);

            Assert.That(updatedSkillLanguage  == "SQL", "Skill Record hasn't been updated.");
            Assert.That(updatedSkilllLevelRecord == "Expert", "Skill Record hasn't been updated.");

        }





        [When(@"I delete a skill from an existing skill record")]
        public void WhenIDeleteASkillFromAnExistingSkillRecord()
        {
            skillPageObj.Delete(driver);
        }



        [Then(@"The Skill Record should be deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {

            string deletedSkillLanguage = skillPageObj.GetskillRecord(driver);
            string deletedSkillLevel = skillPageObj.GetdeletedSkillLevel(driver);


            Assert.That(deletedSkillLanguage != "null", "Skill Record Hasn't been deleted.");
            Assert.That(deletedSkillLevel  != "null", "Skill Record hasn't been deleted.");


        }
    }
}
