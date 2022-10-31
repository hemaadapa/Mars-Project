
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

            //IWebElement skillCancelbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
            //skillCancelbutton.Click();


            //check skill record saved successfully
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 3);
            IWebElement skillRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(skillRecord.Text == "HTML", "Skill Record Hasn't Saved.");
            //if (skillRecord.Text == "HTML")
            //{
            //    Console.WriteLine("skill record saved in Successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("skill Record Hasn't saved.");
            //}

        }

        public void Edit(IWebDriver driver)
        {
            //Code for Edit Skill Record
            IWebElement editSkillRecordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editSkillRecordButton.Click();

            IWebElement skillLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            skillLevelDropdown.Click();

            IWebElement expertOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[4]"));
            expertOption.Click();

            IWebElement updateSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updateSkillButton.Click();

            //IWebElement cancelSkillEditBUtton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
            //cancelSkillEditBUtton.Click();

            //IWebElement skillRecordDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            //skillRecordDeleteButton.Click();    


            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]", 3);
            IWebElement updatedSkillRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(updatedSkillRecord.Text == "Expert", "Skill Record hasn't been updated.");
            //if (updatedSkillRecord.Text == "Expert")
            //{
            //    Console.WriteLine("Record Has been Updated successfully.");

            //}

            //else
            //{
            //    Console.WriteLine("Record hasn't been updated.");
            //}

        }
        public void Delete(IWebDriver driver)
        {

            // Code for Delete Skill Record
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 3);
            IWebElement skillRecordDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            skillRecordDeleteButton.Click();


            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]", 3);
            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
            Assert.That(deletedRecord.Text != "null", "Skill REcord HAsnt been deleted.");
            //if (deletedRecord.Text != "null")
            //{
            //    Console.WriteLine("Skill Record has been Deleted successfully.");

            //}
            //else
            //{
            //    Console.WriteLine("Skill Record hasn't  been deleted.");

            //}
        }
    }
}
