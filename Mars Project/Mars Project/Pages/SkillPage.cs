
using System.Xml.Linq;
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_Project.Pages
{
    public class SkillPage
    {
        public void Add(IWebDriver driver)
        {
            //code foe Skill Option
            IWebElement skillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillButton.Click();

            IWebElement skillAddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            skillAddNewButton.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/ div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkillTextbox.SendKeys("HTML");

            IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            chooseSkillLevelDropdown.Click();

            IWebElement intermediateOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            intermediateOption.Click();

            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillButton.Click();




            //check skill record saved successfully
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 3);

            




        }
        public string GetskillRecord( IWebDriver driver)
        {

            IWebElement skillRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return skillRecord.Text;
        }

        public string GetSkillLevel(IWebDriver driver)
        {
            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return skillLevel.Text;
        }

        public void Edit(IWebDriver driver, string skill, string skilllevel)
        {
            //Code for Edit Skill Record
            IWebElement editSkillRecordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editSkillRecordButton.Click();

            IWebElement editSkillLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            editSkillLanguageTextbox.Clear();
            editSkillLanguageTextbox.SendKeys("SQL");


            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            skillLevelDropdown.Click();

            IWebElement expertOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[4]"));
            expertOption.Click();

            IWebElement updateSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updateSkillButton.Click();




            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]", 3);

            

           

        }

        public string Getupdatedskilllanguage(IWebDriver driver)
        {

            IWebElement updatedSkillLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return updatedSkillLanguage.Text;

        }
        public string GetupdatedSkillLevelRecord(IWebDriver driver)
        {
            IWebElement updatedSkillLevelRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            return updatedSkillLevelRecord.Text;
        }



        public void Delete(IWebDriver driver)
        {

            // Code for Delete Skill Record
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 3);
            IWebElement skillRecordDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            skillRecordDeleteButton.Click();


            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]", 3);

            
            

          

        }
        public string GetdeletedSkillLanguage(IWebDriver driver)
        {
            IWebElement deletedSkillLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
            return deletedSkillLanguage.Text;

        }
        public string GetdeletedSkillLevel(IWebDriver driver)
        {
            IWebElement deletedSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[2]"));
            return deletedSkillLevel.Text;
        }
    }
}
