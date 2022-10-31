
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Project.Pages
{
    public class LanguagePage
    {

        public void Add(IWebDriver driver)
        {

            IWebElement languageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 3);

            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            

            //IWebElement languageCancelButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            //languageCancelButton.Click();

            IWebElement addLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageTextbox.SendKeys("English");

            IWebElement chooseLanguagelevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguagelevelDropdown.Click();

            //IWebElement basicOption = driver.FindElement(By.XPath("//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            //basicOption.Click();

            IWebElement conversationalOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            conversationalOption.Click();

            //IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            //fluentOption.Click();

            //IWebElement nativeOption = driver.FindElement(By.XPath("//*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            //nativeOption.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 2);

            //check if language record saved  in successfully
            IWebElement languageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(languageRecord.Text == "English", "Actual code and Expected code do not match.");
            //if (languageRecord.Text == "English")
            //{
            //    Console.WriteLine("lnguage record saved in Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("language Record Hasnt saved ");
            //}

        }

        public void Edit(IWebDriver driver)
        {
            IWebElement languageRecordEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            languageRecordEditButton.Click();

            IWebElement editaLanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            editaLanguageTextbox.Clear();
            editaLanguageTextbox.SendKeys("Maths");

            IWebElement editLanguageLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            editLanguageLevelDropdown.Click();

            IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            fluentOption.Click();

            IWebElement languageUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            languageUpdateButton.Click();


            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 2);

            IWebElement updatedLanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(updatedLanguageRecord.Text == "Maths", "Actualcode and Expected code donot match.");
            //if (updatedLanguageRecord.Text == "Maths")
            //{
            //    Console.WriteLine("LanguageRecord Has been updated successfully.");

            //}
            //else
            //{
            //    Console.WriteLine("Record Hasn't been updated.");
            //}

            //IWebElement cancelUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
            //cancelUpdate.Click();
        }
        public void Delete(IWebDriver driver)
        {
            //code for Delete Button
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 3);
            IWebElement languageRecordDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            languageRecordDeleteButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "Xpath" ,"//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]",3);
            
            IWebElement deletedLanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));
            Assert.That(deletedLanguageRecord.Text != "Maths", "Actual code and expected code do not match.");
            //if (deletedLanguageRecord.Text != "Maths")
            //{
            //    Console.WriteLine("LanguageRecord Has been deleted successfully.");

            //}
            //else
            //{
            //    Console.WriteLine("Language Record Hasn't been deleted.");
            //}



        }
    }
}
