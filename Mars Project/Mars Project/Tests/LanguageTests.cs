using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars_Project.Tests
{
    public class LanguageTests : CommonDriver
    {
        IWebDriver driver = new ChromeDriver();


        [Test, Order(1)]
        public void AddLanguageTest()
        {

            //Language page Object Initialization Nad Definition
            LanguagePage languagePageobj = new LanguagePage();
            languagePageobj.Add();

        }
        [Test, Order(2)]
        public void EditLanguageTest()
        {
            //Edit Record
            LanguagePage languagePageobj = new LanguagePage();
            //languagePageobj.Edit();
            languagePageobj.Edit(driver,"language","languagelevel");
        }
        [Test, Order(3)]
        public void DeleteLanguageTest()
        {

            //Delete Record
            LanguagePage languagePageobj = new LanguagePage();
            //languagePageobj.Delete();
            languagePageobj.Delete(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }
    }
}
