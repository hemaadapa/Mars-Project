
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Project.Pages
{
    public class SigninPage
    {
        public void SigninSteps(IWebDriver driver)

        {
            driver.Manage().Window.Maximize();

            //enter Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 3);
            
            try
            {
                //click on signin button
                IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signinButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Mars project didn't launch", ex.Message);
            }
            
            

            //sign in identify email address Textbox and enter valid username
            IWebElement emailaddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailaddressTextbox.SendKeys("hema.eglah@gmail.com");

            //identify passord textbox and enter password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Mars@1986");

            //identify sign in button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

            //check if user has logged in successfully
            IWebElement hiHema = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            Assert.That(hiHema.Text == "Hi Hema", "login not Successful.");
           

        }
    }
}
