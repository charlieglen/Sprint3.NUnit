using MarsFramework.Global;
using OpenQA.Selenium;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.GlobalDefinitions.Wait;
using AventStack.ExtentReports;

namespace MarsFramework.Pages.ProfilePages
{
    public class ProfileFullName : Base
    {
        public ProfileFullName()
        {
            PopulateInCollection(ExcelPath, "Profile");
        }

        #region  Find Elements
        //Click on Full Name dropdown
        IWebElement FullNameDropdownBtn => driver.FindElement(By.XPath("(//I[@class='dropdown icon'])[2]"));

        //Click on First Name
        IWebElement FirstName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));

        //Click on Last Name
        IWebElement LastName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[3]"));

        //Click on Save Full Name button
        IWebElement SaveFullName => driver.FindElement(By.XPath("//BUTTON[@class='ui teal button'][text()='Save']"));

        //Full Name Label
        IWebElement FullName => driver.FindElement(By.XPath("//DIV[@class='title']"));

        //Notification Message
        IWebElement NotificationMesssage => driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));        

        #endregion

        private string notificationMessage = "";

        public string GetNotificationMessage()
        {
            return notificationMessage;
        }

        public void EditFullName()
        {
            //Click on Edit button
            WaitToBeClickable("XPath", "(//I[@class='dropdown icon'])[2]", 30);
            FullNameDropdownBtn.Click();

            //wait(30);
            FirstName.Clear();
            FirstName.SendKeys(ReadData(2, "FirstName"));

            //wait(30);
            LastName.Clear();
            LastName.SendKeys(ReadData(2, "LastName"));

            SaveFullName.Click();
            wait(30);
            if (FullName.Text == ReadData(2, "FullName"))
            {
                test.Log(Status.Pass, "Full Name updated Successfully");
            }
            else
            {
                test.Log(Status.Fail, "Full Name Not Updated");
            }
        }
    }
}
