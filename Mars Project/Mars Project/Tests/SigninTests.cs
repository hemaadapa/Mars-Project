using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Mars_Project.Tests
{
    [TestFixture]
    public class SigninTests : CommonDriver
    {

        [SetUp]
        public void SigninActions()
        {

            //open the browser
            driver = new ChromeDriver();

            //Signin Page Object Initialization and Definition
            SigninPage signinPageobj = new SigninPage();
            signinPageobj.SigninSteps(driver);
        }
    }
}
