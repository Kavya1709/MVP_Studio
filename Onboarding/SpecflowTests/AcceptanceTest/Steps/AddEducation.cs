using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest.Steps
{
    [Binding]
    public class SpecFlowEducationSteps
    {
        [Given(@"I have logged in and clicked on Education tab under Profile tab")]
        public void GivenIHaveLoggedInAndClickedOnEducationTabUnderProfileTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab             
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]")).Click();

            //Click on Education tab
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }

        [When(@"I Add my education details (.*),(.*),(.*),(.*),(.*)")]
        public void WhenIAddMyEducationDetails(string Country, string University, string Title, string Degree, string Graduation_Year)

        {

            //Wait
            Thread.Sleep(1000);

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

            //Enter University Name
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys(University);

            //Click on Country of College
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).Click();

            //Choose Country name
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")).SendKeys(Country);

            //Click on Title
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).Click();

            //Choose Title
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")).SendKeys(Title);


            //Enter Degree
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys(Degree);

            //Click on Graduation Year
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).Click();

            //Choose Graduation Year
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")).SendKeys(Graduation_Year);

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//div[@class='fields']/child::div[@class='sixteen wide field']/input[@value='Add']")).Click();

        }




        [Then(@"those details should be displayed on the list")]
        public void ThenThoseDetailsShouldBeDisplayedOnTheList()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Education");

                Thread.Sleep(1000);
                string ExpectedValue = "2016";
                //  int rows = driver.FindElements(By.XPath("//table[@id='account-profile-section']/tbody/tr")).Count;
                string ActualValue = Driver.driver.FindElement(By.XPath("//tr/child::td[text()='India']/following-sibling::td[text()='VTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {

                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");


            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }


        [When(@"I edit education details and click in update button")]
        public void WhenIEditEducationDetailsAndClickInUpdateButton()
        {
            //click on edit button
            Driver.driver.FindElement(By.XPath("//td[text()='India']/following-sibling::td[text()='VTU']/following-sibling::td[text()='B.Tech']/following-sibling::td[text()='IT']/following-sibling::td[text()='2016']/following-sibling::td/child::span/child::i[@class='outline write icon']")).Click();

            //update degree 
            Driver.driver.FindElement(By.XPath("//input[@value='IT']")).Clear();

            //update degree to EIE
            Driver.driver.FindElement(By.XPath("//input[@value='IT']")).SendKeys("EIE");

            //click on update button
            Driver.driver.FindElement(By.XPath("//input[@value='Update']")).Click();

            Thread.Sleep(1500);

        }

        [Then(@"the updated detail should be replaced in the list")]
        public void ThenTheUpdatedDetailShouldBeReplacedInTheList()
        {

            try
            {
                //Start the reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1500);
                CommonMethods.test = CommonMethods.extent.StartTest("Update Education");

                Thread.Sleep(1000);
                string ExpectedValue = "EIE";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='India']/following-sibling::td[text()='VTU']/following-sibling::td[text()='B.Tech']/following-sibling::td")).Text;
                if (ActualValue == ExpectedValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Updated");

                }
                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed ");
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed ", e.Message);
            }

        }

        [When(@"I click on delete button of the selected education detail")]
        public void WhenIClickOnDeleteButtonOfTheSelectedEducationDetail()
        {
            //click on remove icon
            Driver.driver.FindElement(By.XPath("//td[text()='Australia']/following-sibling::td[text()='Monash']/following-sibling::td[text()='M.B.A']/following-sibling::td[text()='CS']/following-sibling::td[text()='2018']/following-sibling::td/child::span/child::i[@class='remove icon']")).Click();

        }


        [Then(@"I that eduaction detail should not appear on the list")]
        public void ThenIThatEduactionDetailShouldNotAppearOnTheList()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete Education");

                Thread.Sleep(1000);
                Boolean DeleteEdu = Driver.driver.FindElements(By.XPath("//tr/child::td[text()='Australia']/following-sibling::td[text()='Monash']/following-sibling::td[text()='M.B.A']/following-sibling::td[text()='CS']/following-sibling::td[text()='2018']")).Count() > 0;


                Thread.Sleep(500);
                if (DeleteEdu == false)
                {

                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationDeleted");
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


