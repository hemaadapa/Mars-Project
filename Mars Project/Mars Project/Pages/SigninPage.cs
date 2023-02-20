
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mars_Project.Pages
{
    public class SigninPage : CommonDriver
    {

        IWebElement signinButton => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement emailaddressTextbox => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement passwordTextbox => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement loginButton => driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));
        IWebElement hiHema => driver.FindElement(By.XPath("//span[@class='item ui dropdown link active visible']"));

        public void SigninSteps(IWebDriver driver)

        {
            driver.Manage().Window.Maximize();

            //enter Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            WaitHelpers.WaitToBeClickable(driver, "XPath", "//a[@class='item']", 3);


            try
            {
                //click on signin button
                
                signinButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Mars project didn't launch", ex.Message);
            }
            
            

            //sign in identify email address Textbox and enter valid username
           
            emailaddressTextbox.SendKeys("hema.eglah@gmail.com");

            //identify passord textbox and enter password
           
            passwordTextbox.SendKeys("Mars@1986");

            //identify sign in button and click on it
           
            loginButton.Click();

            //check if user has logged in successfully
           
            Assert.That(hiHema.Text == "Hi Hema", "login not Successful.");
           

        }
    }
}
