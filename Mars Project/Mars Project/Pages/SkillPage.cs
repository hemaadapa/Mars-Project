
using System.Xml.Linq;
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_Project.Pages
{
    public class SkillPage: CommonDriver
    {

        IWebElement skillButton => driver.FindElement(By.XPath("//a[@class='item active']"));
        IWebElement skillAddNewButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        IWebElement addSkillTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        IWebElement chooseSkillLevelDropdown => driver.FindElement(By.XPath("//select[@name='level']"));
        IWebElement intermediateOption => driver.FindElement(By.XPath("//option[contains(text(),'Intermediate')]"));
        IWebElement addSkillButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        IWebElement skillRecord => driver.FindElement(By.XPath("//td[normalize-space()='Html']"));

        IWebElement skillLevel => driver.FindElement(By.XPath("//td[normalize-space()='Intermediate']"));
        IWebElement editSkillRecordButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
        IWebElement editSkillLanguageTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        IWebElement skillLevelDropdown => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
        IWebElement expertOption => driver.FindElement(By.XPath("//option[contains(text(),'Expert')]"));
        IWebElement updateSkillButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        IWebElement updatedSkillLanguage => driver.FindElement(By.XPath("//td[normalize-space()='sql']"));
        IWebElement updatedSkillLevelRecord => driver.FindElement(By.XPath("//td[normalize-space()='Expert']"));
        IWebElement skillRecordDeleteButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[2]/i[1]"));
        IWebElement deletedSkillLanguage => driver.FindElement(By.XPath("//th[normalize-space()='Skill']"));
        IWebElement deletedSkillLevel => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//th[contains(text(),'Level')]"));
        public void Add()
        {
            //code foe Skill Option
            
            skillButton.Click();

            
            skillAddNewButton.Click();

            addSkillTextbox.SendKeys("HTML");

           
            chooseSkillLevelDropdown.Click();

            intermediateOption.Click();

           
            addSkillButton.Click();




            //check skill record saved successfully
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//td[normalize-space()='Html']", 3);

            




        }
        public string GetskillRecord( IWebDriver driver)
        {

            return skillRecord.Text;
        }

        public string GetSkillLevel(IWebDriver driver)
        {
           
            return skillLevel.Text;
        }

        public void Edit(IWebDriver driver, string skill, string skilllevel)
        {
            //Code for Edit Skill Record
           
            editSkillRecordButton.Click();

          
            editSkillLanguageTextbox.Clear();
            editSkillLanguageTextbox.SendKeys("SQL");


           
            skillLevelDropdown.Click();

           
            expertOption.Click();

           
            updateSkillButton.Click();




            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]", 3);

            

           

        }

        public string Getupdatedskilllanguage(IWebDriver driver)
        {

           
            return updatedSkillLanguage.Text;

        }
        public string GetupdatedSkillLevelRecord(IWebDriver driver)
        {
           
            return updatedSkillLevelRecord.Text;
        }



        public void Delete(IWebDriver driver)
        {

            // Code for Delete Skill Record
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//tbody/tr[1]/td[3]/span[2]/i[1]", 3);
           
            skillRecordDeleteButton.Click();


            WaitHelpers.WaitToBeClickable(driver, "XPath", "//th[normalize-space()='Skill']", 3);

            
            

          

        }
        public string GetdeletedSkillLanguage(IWebDriver driver)
        {
          
            return deletedSkillLanguage.Text;

        }
        public string GetdeletedSkillLevel(IWebDriver driver)
        {
           
            return deletedSkillLevel.Text;
        }
    }
}
