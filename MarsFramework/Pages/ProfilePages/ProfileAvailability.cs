﻿using MarsFramework.Global;
using OpenQA.Selenium;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.GlobalDefinitions.Wait;
using OpenQA.Selenium.Support.UI;

namespace MarsFramework.Pages.ProfilePages
{
    public class ProfileAvailability : Base
    {
        public ProfileAvailability()
        {
            PopulateInCollection(ExcelPath, "Profile");
        }

        #region  Find Elements

        //Click on Edit Availability Time 
        IWebElement EditAvailabilityTime => driver.FindElement(By.XPath("(//I[@class='right floated outline small write icon'])[1]"));

        //Click on Availability Time option
        IWebElement AvailabilityTimeOpt => driver.FindElement(By.XPath("//SELECT[@class='ui right labeled dropdown']"));

        //Current Availability Time
        IWebElement CurrentAvailability => driver.FindElement(By.XPath("(//SPAN)[10]"));

        //Notification Message
        IWebElement NotificationMesssage => driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));

        #endregion

        private string notificationMessage = "";
        private string availability = "";

        public string GetNotificationMessage()
        {
            return notificationMessage;
        }

        public void SelectAvailability(string availability)
        {
            //Availability Time option
            wait(30);
            EditAvailabilityTime.Click();
            wait(30);
            SelectElement selectAvailability = new SelectElement(AvailabilityTimeOpt);
            selectAvailability.SelectByText(availability);
            wait(30);
            availability = CurrentAvailability.Text;
        }

        public string GetAvailabilityValue()
        {
            return availability;
        }
    }
}
