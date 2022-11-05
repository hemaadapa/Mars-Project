using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Project.Pages;
using Mars_Project.Utiities;
using NUnit.Framework;

namespace Mars_Project.Tests
{
    public class DescriptionTests : CommonDriver
    {
        [Test]
        public void AddDescriptionTest()
        {
            //Description Page Object initialiazation and Definition
            DescriptionPage descriptionPageobj = new DescriptionPage();

            //Add Record
            descriptionPageobj.Add(driver);

        }
    }
}
