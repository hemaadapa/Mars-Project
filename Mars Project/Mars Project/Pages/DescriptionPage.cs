
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Project.Pages
{
    public class DescriptionPage : CommonDriver
    {
        public void Add()
        {
            WaitHelpers.WaitToBeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 5);
            IWebElement descriptionEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionEditButton.Click();

            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Iam a Self-driven,value-added person.");

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span", 2);

          
        }
        public string GetSavedDescription(IWebDriver driver)
        {

            IWebElement savedDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return savedDescription.Text;
        }


    }
}
