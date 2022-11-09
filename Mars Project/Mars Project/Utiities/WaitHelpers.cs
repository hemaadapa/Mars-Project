using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Mars_Project.Utiities
{
    public class WaitHelpers
    {
        //Reusable function for wait
        public static void WaitToBeClickable(IWebDriver driver, string locator,string locatorValue,int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                if (locator == "XPath")
                {
                  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                }
                if (locator == "Id")
                {
                  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                } 
                if(locator == "cssSelector")
                {
                  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                }
        }


        //public static void WaitToBeExists(IWebDriver driver, string locator, string locatorValue, int seconds)
        //{
        //    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
        //        if (locator == "XPath")
        //        {
        //          wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
        //        }
        //        if (locator == "Id")
        //        {
        //          wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
        //        }
        //        if (locator == "cssSelector")
        //        {
        //          wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
        //        }
        //}
    }
}
