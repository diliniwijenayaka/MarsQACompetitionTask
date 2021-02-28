using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework.Pages
{
    class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
        private IWebElement ManageListingsTab { get; set; }

        //Click on the view icon 
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[contains(@class, 'eye icon')]")]
        private IWebElement DetailViewIcon;

        //Find the Service Listings table
        [FindsBy(How = How.XPath, Using = "//*[@id='listing - management - section']/div[2]/div[1]/div[1]/(@class='ui striped table')")]
        private IWebElement ListingTable { get; set; }

        //Find Service Detail Page
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']")]
        private IWebElement ServiceDetailPage { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[contains(@class, 'remove icon')]")]
        private IWebElement DeleteButton { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/i[contains(@class, 'outline write icon')]")]
        private IWebElement EditButton { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement ConfirmDelete { get; set; }

        internal void Listings()
        {
            //Click on Manage Listings button
            ManageListingsTab.Click();
            Thread.Sleep(1500);
            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "ShareSkill");
            int excelRowToRead = 2;
            IWebElement listingTable = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table"));
            IList<IWebElement> tableRows = listingTable.FindElements(By.TagName("tr"));
        }

        internal void ManageListingsViewDetails()
        {
            //Click on the Manage Listings Tab
            ManageListingsTab.Click();
            Thread.Sleep(2000);

            //Click on the view icon on the Manage Lisitings View
            DetailViewIcon.Click();
            Thread.Sleep(2000);

            //Verify the user is able to view the selected service
            if (ServiceDetailPage != null)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "View Details Successfully");
            }

            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "View Details Unsuccessfull");

        }

        internal void EditManageListings()
        {
            //Click on the Manage Listings Tab
            ManageListingsTab.Click();
            Thread.Sleep(2000);

            // Click on the Edit Icon
            EditButton.Click();
            Thread.Sleep(2000);
            ShareSkill ShareSkillPage = new ShareSkill();
            ShareSkillPage.EditShareSkill();

        }

        internal void DeleteManageListings()
        {
            //Click on the Manage Listings Tab
            ManageListingsTab.Click();
            Thread.Sleep(2000);


            //Populate the excel Sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "ShareSkill");
            int excelRowToRead = 2;
            IWebElement ListingTable = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table"));
            IList<IWebElement> tableRows = ListingTable.FindElements(By.TagName("tr"));
            IWebElement rowToDelete = DeleteButton;

            for (int i = 0; i < tableRows.Count; i++)
            {
                IWebElement row = tableRows[i];
                if (row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Title")) && row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Description")))
                {
                    rowToDelete = row;
                    break;

                }
            }

            //Verify
            IList<IWebElement> tableRowsAfterDelete = ListingTable.FindElements(By.TagName("tr"));
            Boolean isListingPresent = false;
            for (int i = 0; i < tableRowsAfterDelete.Count; i++)
            {
                IWebElement row = tableRowsAfterDelete[i];
                if (row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Title")) && row.Text.Contains(Global.GlobalDefinitions.ExcelLib.ReadData(excelRowToRead, "Description")))
                {
                    isListingPresent = true;
                    break;

                }
            }
            if (isListingPresent == false)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete Skill test Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Delete Skill test Failed");
            }



        }


    }
}
