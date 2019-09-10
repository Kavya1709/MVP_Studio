using AutoIt;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Find ShareSkill
        [FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button']")]
        private IWebElement Share_skill { set; get; }

        //Find Title
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { set; get; }

        //Find Description 
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { set; get; }

        //Select Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category { set; get; }

        //Select Sub Category               
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategory { set; get; }

        //Find tag
        [FindsBy(How = How.XPath, Using = "//div[@class='tooltip-target ui grid']/div[@class='twelve wide column']/div/div/div/div/input[@class='ReactTags__tagInputField']")]
        private IWebElement Tags { set; get; }

        //Find Service Type
        [FindsBy(How = How.XPath, Using = "//input[@name='serviceType'][@value='1']")]
        private IWebElement ServiceType { set; get; }

        //Find Location Type
        [FindsBy(How = How.XPath, Using = "//input[@name='locationType'][@value='1']")]
        private IWebElement locationType { set; get; }

        //Find Available days
        [FindsBy(How = How.XPath, Using = "//input[@name ='startDate']")]
        private IWebElement StartDate { set; get; }
        
        //Find Sunday Ckeckbox
        [FindsBy(How = How.XPath, Using = "//input[@index='0'][@type ='checkbox']")]
        private IWebElement Checkbox { set; get; }
   
        //Find Start Time under Availability
        [FindsBy(How = How.XPath, Using = "//input[@name ='StartTime']")]
        private IWebElement StartTime { set; get; }


        //IWebElement txtBxDatePicker = driver.FindElement(By.Id("TextBoxOfDatePicker"));


        //Find Skill Trade
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades'][@value='true']")]
        private IWebElement skillTrades { set; get; }

        //Find Skill-Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchange { set; get; }

        //Find Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement Work_Samples { set; get; }

        //Find Active
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive'][@value='true']")]
        private IWebElement Active { set; get; }

        //Find Save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { set; get; }


        internal void Share_Skill()
        {
            Console.WriteLine("Start of shareSkill Method");

            //extent Reports
            // Base.test = Base.extent.StartTest("Login Test");

            //Click on ShareSkill
            Share_skill.Click();
            Thread.Sleep(2000);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);

            //Enter Title
            Title.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Thread.Sleep(1000);

            //Enter Description 
            Description.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            Thread.Sleep(1000);

            //Click on Category
            Category.Click();

            //Enter Category            
            var selectElement = new SelectElement(Category);
            selectElement.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            Thread.Sleep(2000);

            //Click on Sub Category
            SubCategory.Click();
            Thread.Sleep(3000);

            //Enter Sub Category
            var selectElementSub = new SelectElement(SubCategory);
            selectElementSub.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Sub Category"));
            Thread.Sleep(1000);

            //Click on tags
            Tags.Click();

            //Enter a tag
            Tags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));

            //Select a Service Type
            ServiceType.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Service Type"));

            //Select Location Type
            locationType.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Location Type"));

            //Click on Avaliable days
            StartDate.Click();

            Thread.Sleep(1000);

            //Select Available days
            StartDate.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Start Date"));

            //Click on Sunday Checkbox
            Checkbox.Click();

            Thread.Sleep(1000);

            //Select Start Time
            StartTime.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Start Time"));

            //Select Skill Trade
            skillTrades.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Skill Trade"));

            //Select Skill-Exchange
            SkillExchange.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Skill Exchange"));

            Thread.Sleep(2000);

            //Click on plus icon of Work Samples
            Work_Samples.Click();

            Thread.Sleep(3000);

            //Call AutoIt to choose a file
            AutoItX.ControlFocus("Open", "", "Edit1");
            AutoItX.ControlSetText("Open", "", "Edit1", @"D:\kavya\AutoIt");
            AutoItX.ControlClick("Open", "", "Button1");

            //Select Active
            Active.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Active"));

            //Click on Save
            Save.Click();

        }

    }
}
