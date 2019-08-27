using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    [TestFixture]
    //[Category("Sprint 1")]

    class Program : Global.Base
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("in main start");
            Program p1 = new Program();
            p1.UserAccount();
        }


        [Test]
        public void UserAccount()
        {

            // Create an class and object to call the method
            SignIn sign_In = new SignIn();
            sign_In.LoginSteps();
        }

            //Create an class and object to call the method
            // Profile obj = new Profile();
            // obj.EditProfile();
        [Test]
        public void ShareSkill()
        { 
            //Create an Object to call the method
            ShareSkill obj1 = new ShareSkill();
            obj1.Share_Skill();
        }
    }
}
