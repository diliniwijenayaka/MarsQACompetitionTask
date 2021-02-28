using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace MarsFramework.Pages
{
    class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input")]
        private IWebElement Tags { get; set; }

        //Select the Hourly Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyServiceType { get; set; }

        //Select On-Off Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneOffServiceType { get; set; }

        //Select On-Site Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement OnSiteLocationType { get; set; }

        //Select Online Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement OnlineLocationType { get; set; }

        //Find Availability Form
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div")]
        private IWebElement AvailabilityForm { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Select Available Start Date 
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")]
        private IWebElement AvailableStartDate { get; set; }

        // Select Available End Date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")]
        private IWebElement AvailableEndDate { get; set; }

        //Select Sunday checkbox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")]
        private IWebElement SundayCheckbox { get; set; }

        //Select Start Time
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        // Select End Time

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Slelect the Skill Exchange Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchangeType { get; set; }

        //Select the Credit Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement CreditsType { get; set; }

        //Enter Skill Exchange Tag
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchangeTag { get; set; }

        //Enter Credit Amount
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        private IWebElement CreditAmount { get; set; }

        //Select Active Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveButton { get; set; }

        //Select Hidden Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenButton { get; set; }

        //Select Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")]
        private IWebElement SaveButton { get; set; }

        //Select Cancel Button
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[2]")]
        private IWebElement CancelButton { get; set; }


        internal void EnterShareSkill()
        {
            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "ShareSkill");
            int excelRowToRead = 2;

            //Click on Title text box
            ShareSkillButton.Click();
            Thread.Sleep(1500);
            Title.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Title"));

            //Click on Description
            Description.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Description"));

            //Select A Category
            CategoryDropDown.Click();
            String categoryValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Category");
            IList<IWebElement> CategoriesDropDownList = CategoryDropDown.FindElements(By.XPath("//option"));
            int DpListCount = CategoriesDropDownList.Count;
            for (int i = 0; i < DpListCount; i++)
            {
                if (CategoriesDropDownList[i].Text == categoryValue)
                {
                    CategoriesDropDownList[i].Click();
                }
            }


            //Select Sub Category
            Thread.Sleep(1000);
            IWebElement SubCategorySelection = Global.GlobalDefinitions.driver.FindElement(By.Name("subcategoryId"));
            SubCategorySelection.Click();
            String SubCategoryValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "SubCategory");
            IList<IWebElement> SubCategoriesDropDownList = SubCategorySelection.FindElements(By.XPath("//option"));
            int SbDpListCount = SubCategoriesDropDownList.Count;
            for (int i = 0; i < SbDpListCount; i++)
            {
                if (SubCategoriesDropDownList[i].Text == SubCategoryValue)
                {
                    SubCategoriesDropDownList[i].Click();
                }
            }

            //Add Tags
            Tags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Tag"));
            Tags.SendKeys(Keys.Enter);

            //Select Service type
            String ServiceType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "ServiceType");
            if (ServiceType.Equals("Hourly basis service"))
            {
                HourlyServiceType.Click();
            }
            else if (ServiceType.Equals("One-off service"))
            {
                OneOffServiceType.Click();

            }

            //Select Location type
            String LocationType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "LocationType");
            if (ServiceType.Equals("On-site"))
            {
                OnSiteLocationType.Click();
            }
            else if (ServiceType.Equals("Online"))
            {
                OnlineLocationType.Click();

            }


            //Select Available Start date
            IWebElement AvailableStartDateInput = AvailabilityForm.FindElement(By.Name("startDate"));
            //AvailableStartDateInput.Clear();
            AvailableStartDateInput.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableStartDate"));

            //Select Available End date
            IWebElement AvailableEndDateInput = AvailabilityForm.FindElement(By.Name("endDate"));
            AvailableEndDateInput.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableEndDate"));

            String[] WeekDays = new String[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //clear Selected Checkboxes
            IList<IWebElement> AvailableCheckboxes = AvailabilityForm.FindElements(By.Name("Available"));
            String AvailableDaysValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableDays");
            IList<String> AvailableDays = AvailableDaysValue.Split(',');
            for (int i = 0; i < WeekDays.Count(); i++)
            {
                if (AvailableDays.Contains(WeekDays[i]))
                {
                    AvailableCheckboxes[i].Click();
                }
            }

            //Set Start times
            IList<IWebElement> AvailableStartTimeInputs = AvailabilityForm.FindElements(By.Name("StartTime"));
            String AvailableStartTimesValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableStartTimes");
            IList<String> AvailableStartTimes = AvailableStartTimesValue.Split(',');
            for (int i = 0; i < AvailableStartTimes.Count(); i++)
            {
                IList<String> startTimeInfo = AvailableStartTimes[i].Split(':');
                String startTimeDay = startTimeInfo[0];
                String startTimeValue = startTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, startTimeDay);
                AvailableStartTimeInputs[indexOfDay].SendKeys(startTimeValue);

            }

            //Set End times
            IList<IWebElement> AvailableEndTimeInputs = AvailabilityForm.FindElements(By.Name("EndTime"));
            String AvailableEndTimesValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableEndTimes");
            IList<String> AvailableEndTimes = AvailableEndTimesValue.Split(',');
            for (int i = 0; i < AvailableEndTimes.Count(); i++)
            {
                IList<String> endTimeInfo = AvailableEndTimes[i].Split(':');
                String endTimeDay = endTimeInfo[0];
                String endTimeValue = endTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, endTimeDay);
                AvailableEndTimeInputs[indexOfDay].SendKeys(endTimeValue);

            }

            //Select Skill Exchange Type
            String SkillTradeType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "SkillTradeType");
            if (SkillTradeType.Equals("Skill-exchange"))
            {
                SkillExchangeType.Click();
            }
            else if (SkillTradeType.Equals("Credit"))
            {
                CreditsType.Click();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "CreditsAmount"));

            }

            //Add Skill Exchange Tag
            SkillExchangeTag.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "SkillExchangeTab"));
            SkillExchangeTag.SendKeys(Keys.Enter);

            //Select Active Status Button
            String ActiveType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "ActiveType");
            if (SkillTradeType.Equals("Active"))
            {
                ActiveButton.Click();
            }
            else if (SkillTradeType.Equals("Hidden"))
            {
                HiddenButton.Click();
            }

            //Click on Save Button
            SaveButton.Click();
            Thread.Sleep(3000);

            //Verify
            IWebElement listingTable = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table"));
            IList<IWebElement> tableRows = listingTable.FindElements(By.TagName("tr"));

            Boolean isListingAdded = false;
            for (int i = 0; i <= tableRows.Count; i++)
            {
                IWebElement row = tableRows[i];
                if (row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Title")) && row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Description")))
                {
                    isListingAdded = true;
                    break;

                }
            }
            if (isListingAdded == true)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Share Skill test Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Share Skill test Failed");
            }


        }

        internal void EditShareSkill()
        {
            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "ShareSkill");
            int excelRowToRead = 3;
            Title.Clear();
            Title.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Title"));

            //Click on Description
            Description.Clear();
            Description.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Description"));

            //Select A Category
            CategoryDropDown.Click();
            String categoryValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Category");
            IList<IWebElement> CategoriesDropDownList = CategoryDropDown.FindElements(By.XPath("//option"));
            int DpListCount = CategoriesDropDownList.Count;
            for (int i = 0; i < DpListCount; i++)
            {
                if (CategoriesDropDownList[i].Text == categoryValue)
                {
                    CategoriesDropDownList[i].Click();
                }
            }

            //Select Sub Category
            Thread.Sleep(1000);
            IWebElement SubCategorySelection = Global.GlobalDefinitions.driver.FindElement(By.Name("subcategoryId"));
            SubCategorySelection.Click();
            String SubCategoryValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "SubCategory");
            IList<IWebElement> SubCategoriesDropDownList = SubCategorySelection.FindElements(By.XPath("//option"));
            int SbDpListCount = SubCategoriesDropDownList.Count;
            for (int i = 0; i < SbDpListCount; i++)
            {
                if (SubCategoriesDropDownList[i].Text == SubCategoryValue)
                {
                    SubCategoriesDropDownList[i].Click();
                }
            }

            //Clear and Add Tags
            IWebElement tagsInputBox = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div"));
            IList<IWebElement> RemoveButtons = tagsInputBox.FindElements(By.ClassName("ReactTags__remove"));
            foreach (IWebElement element in RemoveButtons)
            {
                element.Click();
            }
            Tags.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Tag"));
            Tags.SendKeys(Keys.Enter);

            //Select Service Type
            String ServiceType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Service Type");
            if (ServiceType.Equals("Hourly basis Service"))
            {
                HourlyServiceType.Click();
            }

            else if (ServiceType.Equals("One-off Service"))
            {
                OneOffServiceType.Click();
            }

            //Select Location Type
            String LocatioType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Location Type");
            if (LocatioType.Equals("On-site"))
            {
                OnSiteLocationType.Click();
            }

            else if (OnSiteLocationType.Equals("Online"))
            {
                OnlineLocationType.Click();
            }

            //Select Available Start Date
            IWebElement AvailableStartDateInput = AvailabilityForm.FindElement(By.Name("startDate"));
            AvailableStartDateInput.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableStartDate"));

            //Select Available End Date
            IWebElement AvailableEndDateInput = AvailabilityForm.FindElement(By.Name("endDate"));
            AvailableEndDateInput.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableEndDate"));

            String[] WeekDays = new String[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //Cleared Selected Checkboxes
            IList<IWebElement> AvailableCheckBoxes = AvailabilityForm.FindElements(By.Name("Available"));
            foreach (IWebElement element in AvailableCheckBoxes)
            {
                if (element.Selected)
                {
                    element.Click();
                }
            }

            //Select Check boxes based on data
            String AvailableDaysValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableDays");
            IList<String> AvailableDays = AvailableDaysValue.Split(',');
            for (int i = 0; i < WeekDays.Count(); i++)
            {
                if (AvailableDays.Contains(WeekDays[i]))
                {
                    AvailableCheckBoxes[i].Click();
                }
            }

            //Set Start times
            IList<IWebElement> AvailableStartTimeInputs = AvailabilityForm.FindElements(By.Name("StartTime"));
            String AvailableStartTimesValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableStartTimes");
            IList<String> AvailableStartTimes = AvailableStartTimesValue.Split(',');
            for (int i = 0; i < AvailableStartTimes.Count(); i++)
            {
                IList<String> startTimeInfo = AvailableStartTimes[i].Split(':');
                String startTimeDay = startTimeInfo[0];
                String startTimeValue = startTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, startTimeDay);
                AvailableStartTimeInputs[indexOfDay].SendKeys(startTimeValue);

            }

            //Set End times
            IList<IWebElement> AvailableEndTimeInputs = AvailabilityForm.FindElements(By.Name("EndTime"));
            String AvailableEndTimesValue = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "AvailableEndTimes");
            IList<String> AvailableEndTimes = AvailableEndTimesValue.Split(',');
            for (int i = 0; i < AvailableEndTimes.Count(); i++)
            {
                IList<String> endTimeInfo = AvailableEndTimes[i].Split(':');
                String endTimeDay = endTimeInfo[0];
                String endTimeValue = endTimeInfo[1];
                int indexOfDay = Array.IndexOf(WeekDays, endTimeDay);
                AvailableEndTimeInputs[indexOfDay].SendKeys(endTimeValue);
            }

            //Select Skill Exchange Type
            String SkillTradeType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "SkillTradeType");
            if (SkillTradeType.Equals("Skill-exchange"))
            {
                SkillExchangeType.Click();

                //Clear and Add Tags
                IWebElement SkillTagsInputBox = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div"));
                IList<IWebElement> CrossButtons = SkillTagsInputBox.FindElements(By.ClassName("ReactTags__remove"));
                foreach (IWebElement element in CrossButtons)
                {
                    element.Click();
                }
                SkillExchangeTag.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "SkillExchangeTab"));
                SkillExchangeTag.SendKeys(Keys.Enter);

            }

            else if (SkillTradeType.Equals("Credit"))
            {
                CreditsType.Click();
                CreditAmount.Clear();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "CreditsAmount"));

            }

            //Select Active Status Button
            String ActiveType = Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "ActiveType");
            if (SkillTradeType.Equals("Active"))
            {
                ActiveButton.Click();
            }
            else if (SkillTradeType.Equals("Hidden"))
            {
                HiddenButton.Click();
            }

            //Click on Save Button
            SaveButton.Click();
            Thread.Sleep(3000);

            //Verify
            IWebElement listingTable = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table"));
            IList<IWebElement> tableRows = listingTable.FindElements(By.TagName("tr"));

            Boolean isListingEdited = false;
            for (int i = 0; i <= tableRows.Count; i++)
            {
                IWebElement row = tableRows[i];
                if (row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Title")) && row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Description")))
                {
                    isListingEdited = true;
                    break;

                }
            }
            if (isListingEdited == true)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edit Skill test Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Edit Skill test Failed");
            }
        }

    }
}
