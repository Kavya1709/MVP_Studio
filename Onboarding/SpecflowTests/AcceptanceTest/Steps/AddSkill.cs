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
    public class SpecFlowFeature2Steps
    {
        [Given(@"I clicked on Skills tab under profile page")]
        public void GivenIClickedOnSkillsTabUnderProfilePages()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkills()
        {
            //click on Add new button
            Driver.driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Add skill
            Driver.driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Yoga");

            //Click on Choose skill level
            Driver.driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose skill level
            Driver.driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

        [Then(@"that skill should be displayed on my listing")]
        public void ThenThatSkillShouldBeDisplayedOnMyListing()
        {
            try
            {
                //Start the reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1500);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Yoga";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).Text;
                if (ActualValue == ExpectedValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");

                }
                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
