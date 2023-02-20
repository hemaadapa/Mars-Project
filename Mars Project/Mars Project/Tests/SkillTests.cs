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
    public class SkillTests : CommonDriver
    {
        SkillPage skillPageObj = new SkillPage();
        [Test, Order(1)]
        public void AddSkillTest()
        {
            //Skill Page object Initialization and definition
           // SkillPage skillPageObj = new SkillPage();
            skillPageObj.Add();
            //skillPageObj.Add(driver);
        }
        [Test, Order(2)]
        public void EditSkillTest()
        {
            //SkillPage skillPageObj = new SkillPage();
            //skillPageObj.Edit();
            skillPageObj.Edit(driver, "skill", "skilllevel");

        }

        //[Test, Order(3)]
        //public void EditSkillLevelTest()
        //{
        //    SkillPage skillPageObj = new SkillPage();
        //    skillPageObj.EditSkillLevel();

        //}
        [Test, Order(4)]
        public void DeleteSkillTest()
        {
            //SkillPage skillPageObj = new SkillPage();
            skillPageObj.Delete(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }
    }
}
