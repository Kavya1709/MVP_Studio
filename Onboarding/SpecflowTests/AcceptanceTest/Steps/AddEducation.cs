using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

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
            Thread.Sleep(1500);

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
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

        }

        
        [Then(@"those details should be displayed on the list")]
        public void ThenThoseDetailsShouldBeDisplayedOnTheList()
        {
            
        }
    }
}
