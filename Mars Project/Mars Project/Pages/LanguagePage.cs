
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Project.Pages
{
    public class LanguagePage : CommonDriver
    {
        public static IWebElement languageButton => driver.FindElement(By.XPath("//a[@class='item active']"));
        public static IWebElement addNewButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='ui teal button '][normalize-space()='Add New']"));
        public static IWebElement addLanguageTextbox =>  driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public static IWebElement chooseLanguagelevelDropdown => driver.FindElement(By.XPath("//select[@name='level']"));
        public static IWebElement conversationalOption => driver.FindElement(By.XPath("//option[contains(text(),'Conversational')]"));
        public static IWebElement addButton =>  driver.FindElement(By.XPath("//input[@value='Add']"));

        public static IWebElement languageRecord => driver.FindElement(By.XPath("//td[normalize-space()='English']"));

        IWebElement languageLevel => driver.FindElement(By.XPath("//td[normalize-space()='Conversational']"));

        public static IWebElement languageRecordEditButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));

        IWebElement editLanguageTextbox => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        IWebElement editLanguageLevelDropdown => driver.FindElement(By.XPath("/select[@name='level']"));
        public static IWebElement fluentOption => driver.FindElement(By.XPath("//option[contains(text(),'Fluent')]"));
        IWebElement languageUpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));

        IWebElement updatedLanguageRecord => driver.FindElement(By.XPath("//td[normalize-space()='Telugu']"));
        IWebElement updatedLanguageLevel => driver.FindElement(By.XPath("//td[normalize-space()='Fluent']"));
        IWebElement languageRecordDeleteButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[2]/i[1]"));
        IWebElement deletedLanguageRecord => driver.FindElement(By.XPath("//th[normalize-space()='Language']"));
        IWebElement deletedLanguageLevel => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//th[contains(text(),'Level')]"));
        public void Add()
        {

            languageButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='ui teal button '][normalize-space()='Add New']", 3);

            addNewButton.Click();




            
            addLanguageTextbox.SendKeys("English");

            chooseLanguagelevelDropdown.Click();



            conversationalOption.Click();


            
            addButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//td[normalize-space()='English']", 2);

            //check if language record saved  in successfully
          
           


        }
        public string GetLanguageRecord(IWebDriver driver)
        {
            
            return languageRecord.Text;
        }

        public string GetLanguageLevel(IWebDriver driver)
        {
           
            return languageLevel.Text;
        }


        public void Edit(IWebDriver driver , string language, string languagelevel)
        {
            
            languageRecordEditButton.Click();

            
            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys(language);

          
            editLanguageLevelDropdown.Click();

           
            fluentOption.Click();

           
            languageUpdateButton.Click();


            WaitHelpers.WaitToBeClickable(driver, "XPath", "//td[normalize-space()='Telugu']", 2);

            
            

            
        }
        public string GetUpdatedLanguageRecord(IWebDriver driver)
        {
            return updatedLanguageRecord.Text;
        }
        public string GetUpdatedLanguageLevel(IWebDriver driver)
        {
          
            return updatedLanguageLevel.Text;

        }

        public void Delete(IWebDriver driver) 
        {
            //code for Delete Button
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//tbody/tr[1]/td[3]/span[2]/i[1]", 3);
           
            languageRecordDeleteButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//th[normalize-space()='Language']", 3);

            





        }
        public string GetdeletedLanguageRecord(IWebDriver driver)
        {

          
            return deletedLanguageRecord.Text;

        }
        public string GetdeletedLanguageLevel(IWebDriver driver)
        {
           
           
            return deletedLanguageLevel.Text;
        }
    }
}