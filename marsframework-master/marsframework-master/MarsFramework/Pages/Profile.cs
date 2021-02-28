using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System.Collections.Generic;
using System.Threading;
using System; 

namespace MarsFramework
{
    internal class Profile
    {

         public     Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/span/a/div/i")]
        private IWebElement ProfileEdit { get; set; }

        //Click on Availability icon
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[2]/div")]
        private IWebElement Availability { get; set; }

        //Click on Availability dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[2]/div/div[2]")]
        private IWebElement AvailabilityDropdown { get; set; }

        //Click on Availability Hour icon
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[2]/div")]
        private IWebElement AvailabileHours { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        private IWebElement AvailableHoursDropdown { get; set; }

        //Click on salary
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        //private IWebElement LocationOpt { get; set; }

        //Click on City
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        //private IWebElement City { get; set; }

        //Choose City
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        //private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Click on the Language Level
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Click on the Language Level Dropdown 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Click on Add BUtton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion

        internal void EditProfile()
        {
            //Populate the Excel Sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            //Click on Edit Button
            ProfileEdit.Click();

            //Select Availability
            Thread.Sleep(2000);
            Actions actions = new Actions(GlobalDefinitions.driver);
            actions.MoveToElement(Availability).Build().Perform();
            Thread.Sleep(1500);
            IList<IWebElement> AvailableTime = AvailabilityDropdown.FindElements(By.TagName("div"));
            int count = AvailableTime.Count;
            for (int i = 0; i < count; i++)
            {
                if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, AvailableTime))
                {
                    AvailableTime[i].Click();
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Slsect the available time");
                }
            }

            //Select Available Hours dropdown
            AvailabileHours.Click();

            //Select Available Hours
            AvailableHoursDropdown.SendKeys(Keys.ArrowDown);
            AvailableHoursDropdown.SendKeys(Keys.Enter);

            //Select Salary
            Salary.Click();

            //Select an option from Salary dropdown
            Salary.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            Salary.SendKeys(Keys.Enter);

            //Click on Add New Language button
            AddNewLangBtn.Click();
            Thread.Sleep(1000);
            //Enter the Language
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Choose Language
            ChooseLang.Click();
            Thread.Sleep(1000);
            ChooseLangOpt.Click();
            Thread.Sleep(500);
            AddLang.Click();
            Base.test.Log(LogStatus.Info, "Added Language successfully");

            //Click on Add New Skill Button
            AddNewSkillBtn.Click();
            //Enter the skill 
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //Click the skill dropdown
            ChooseSkill.Click();
            Thread.Sleep(500);
            ChooseSkilllevel.Click();
            AddSkill.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Skills successfully");

            //Add Education
            AddNewEducation.Click();
            //Enter the University
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Choose Country
            ChooseCountry.Click();
            Thread.Sleep(500);
            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();
            Thread.Sleep(500);
            ChooseTitleOpt.Click();

            //Enter Degree
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Year of Graduation
            DegreeYear.Click();
            Thread.Sleep(500);
            DegreeYearOpt.Click();
            AddEdu.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Education successfully");

            //Add new Certificate
            AddNewCerti.Click();

            //Enter Certificate Name
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter Certified from
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Enter the Year
            CertiYear.Click();
            Thread.Sleep(500);
            CertiYearOpt.Click();
            AddCerti.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Certificate successfully");

            //Add Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            Thread.Sleep(500);
            Save.Click();
            Base.test.Log(LogStatus.Info, "Added Description successfully");


        }
    }
}