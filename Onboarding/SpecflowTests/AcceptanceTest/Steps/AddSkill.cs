
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests
{
    [Binding]
    public class SpecFlowSkillsSteps
    {

        [Given(@"I have logged in and clicked on Skills tab under Profile tab")]
        public void GivenIHaveLoggedInAndClickedOnSkillsTabUnderProfileTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab             
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]")).Click();

            //Click on Skills tab
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }

        [When(@"I add (.*) as (.*) as my skill")]
        public void WhenIAddAsBeginnerAsMySkill(string Skill, string Skill_level)
        {
            //click on Add new button
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Add skill
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(Skill);

            //Click on Choose skill level
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose skill level
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).SendKeys(Skill_level);

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

        [Then(@"the newly added skill (.*) should be displayed on my skills tab")]
        public void ThenTheNewlyAddedSkillYogaShouldBeDisplayedOnMySkillsTab(string skill)
        {

            CommonMethods.ExtentReports();
            Thread.Sleep(1500);
            CommonMethods.test = CommonMethods.extent.StartTest("Add " + skill);

            Thread.Sleep(1000);
            string expected_skill = skill;
            string actual_skill = null;

            int i = 1;
            while (true)
            {
                actual_skill = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                if (expected_skill == actual_skill)
                {
                    CommonMethods.test.Log(LogStatus.Pass, actual_skill, "Test Passed, Skill added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                    break;
                }
                i = i + 1;
            }
        }
    }
}



//        [Then(@"that skill should be displayed on my listing")]
//        public void ThenThatSkillShouldBeDisplayedOnMyListing()
//        {
//            try
//            {
//                //Start the reports
//                CommonMethods.ExtentReports();
//                Thread.Sleep(1500);
//                CommonMethods.test = CommonMethods.extent.StartTest("Add Skill");

//                Thread.Sleep(1000);
//                string ExpectedValue = "Yoga";
//                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).Text;
//                if (ActualValue == ExpectedValue)
//                {
//                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill added successfully");
//                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");

//                }
//                else
//                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed in else");
//            }
//            catch (Exception e)
//            {
//                CommonMethods.test.Log(LogStatus.Fail, "Test Failed in catch", e.Message);
//            }
//        }
//    }
//}
