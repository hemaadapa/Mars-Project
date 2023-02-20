
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Project.Pages
{
    public class DescriptionPage : CommonDriver
    {

        public static IWebElement descriptionEditButton => driver.FindElement(By.XPath("//h3[@class='ui dividing header']//i[@class='outline write icon']"));
        public static IWebElement descriptionTextbox => driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
        public static IWebElement saveButton => driver.FindElement(By.XPath("//button[@type='button']"));
        public static IWebElement savedDescription => driver.FindElement(By.XPath("//div[@class='eight wide column']//div[@class='content']//div"));
       
        public void Add()
        {
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//h3[@class='ui dividing header']//i[@class='outline write icon']", 5);
            
            descriptionEditButton.Click();

           
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("I am a Self-driven, value-added person.");

            
            saveButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//div[@class='eight wide column']//div[@class='content']//div", 2);

          
        }
        public string GetSavedDescription(IWebDriver driver)
        {

            
            return savedDescription.Text;
        }


    }
}
