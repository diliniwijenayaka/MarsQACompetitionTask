using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using System;
using System.Linq;
using System.Text;


namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 

        //Find the SignIn Link
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        private IWebElement SignIntab { get; set; }

        // Find the Email Field
        [FindsBy(How = How.Name, Using = " / html / body / div[2] / div / div / div[1] / div / div[1] / input")]
        private IWebElement Email { get; set; }

        //Find the Password Field
        [FindsBy(How = How.Name, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        private IWebElement LoginButton { get; set; }

        #endregion
            

        internal void LoginSteps()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            //Click on SignIn link
            SignIntab.Click();
            Thread.Sleep(500);

            //Enter data into username text field
            Email.Click();
            Email.Clear();
            Email.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Enter data into password field
            Password.Click();
            Password.Clear();
            Password.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            LoginButton.Click();
            Thread.Sleep(500);

            //Verify the Profile page is loaded successfully
            string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/a")).Text;

            if (text == "MarsLogo")

            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successfull");
            }

            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Uncessfull");
        }
    }
}