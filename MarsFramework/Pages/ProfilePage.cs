using MarsFramework.Global;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using AventStack.ExtentReports;

namespace MarsFramework.Pages
{
    public class ProfilePage : Base
    {
        public ProfilePage()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
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

        //Click on Edit Availability Time 
        IWebElement EditAvailabilityTime => driver.FindElement(By.XPath("(//I[@class='right floated outline small write icon'])[1]"));

        //Click on Availability Time option
        IWebElement AvailabilityTimeOpt => driver.FindElement(By.XPath("//SELECT[@class='ui right labeled dropdown']"));

        //Current Availability Time
        IWebElement CurrentAvailability => driver.FindElement(By.XPath("(//SPAN)[10]"));

        //Click on Edit Availability Hour 
        IWebElement EditAvailabilityHours => driver.FindElement(By.XPath("(//I[@class='right floated outline small write icon'])[2]"));

        //Click on Availability Hour dropdown
        IWebElement AvailabilityHoursOpt => driver.FindElement(By.XPath("//SELECT[@class='ui right labeled dropdown']"));

        //Current Availability Hours
        IWebElement CurrentHours => driver.FindElement(By.XPath("(//SPAN)[12]"));

        //Click on edit Earn Target
        IWebElement EditSalary => driver.FindElement(By.XPath("(//I[@class='right floated outline small write icon'])[3]"));

        //Click on salary option
        IWebElement SalaryOpt => driver.FindElement(By.XPath("//SELECT[@class='ui right labeled dropdown']"));

        //Current Earn Target Value
        IWebElement CurrentSalaryValue => driver.FindElement(By.XPath("(//SPAN)[14]"));

        //Click Edit Description
        IWebElement EditProfileDescription => driver.FindElement(By.XPath("(//I[@class='outline write icon'])[1]"));

        //Enter Description Textarea
        IWebElement DescriptionTextArea => driver.FindElement(By.XPath("//TEXTAREA[@name='value']"));

        //Click Save Description
        IWebElement SaveDescription => driver.FindElement(By.XPath("(//BUTTON[@class='ui teal button'][text()='Save'])[2]"));

        //Click on Languages Tab
        IWebElement LanguagesTab => driver.FindElement(By.XPath("//A[@class='item active'][text()='Languages']"));


        //Click on Add new button to add new Language
        IWebElement AddNewLanguageBtn => driver.FindElement(By.XPath("(//DIV[@class='ui teal button '][text()='Add New'])[1]"));

        //Enter the Language on text box
        IWebElement AddLanguageName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));

        //Click language level dropdown button
        IWebElement LanguageLevelBtn => driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));

        //Click Add button to save new language
        IWebElement SaveLanguageBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]"));

        //Click Cancel button to cancel new language entry
        IWebElement CancelLanguageBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[2]"));

        //Add Language
        IWebElement LasAddLangtName => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]"));

        //Click on Add new to add new skill
        IWebElement AddNewSkillBtn => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div"));

        //Enter the Skill on text box
        IWebElement AddSkillText => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input"));

        //Click on skill level dropdown
        IWebElement ChooseSkill => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select"));

        //Choose the skill level option
        IWebElement ChooseSkilllevel => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]"));

        //Add Skill
        IWebElement AddSkill => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]"));

        //Click on Add new to Educaiton
        IWebElement AddNewEducation => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div"));

        //Enter university in the text box
        IWebElement EnterUniversity => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input"));

        //Choose the country
        IWebElement ChooseCountry => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select"));

        //Choose the skill level option
        IWebElement ChooseCountryOpt => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]"));

        //Click on Title dropdown
        IWebElement ChooseTitle => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select"));

        //Choose title
        IWebElement ChooseTitleOpt => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]"));

        //Degree
        IWebElement Degree => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input"));

        //Year of graduation
        IWebElement DegreeYear => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select"));

        //Choose Year
        IWebElement DegreeYearOpt => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]"));

        //Click on Add
        IWebElement AddEdu => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]"));

        //Add new Certificate
        IWebElement AddNewCerti => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div"));

        //Enter Certification Name
        IWebElement EnterCerti => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input"));

        //Certified from
        IWebElement CertiFrom => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input"));

        //Year
        IWebElement CertiYear => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select"));

        //Choose Opt from Year
        IWebElement CertiYearOpt => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]"));

        //Add Ceritification
        IWebElement AddCerti => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]"));

        //Add Desctiption
        IWebElement Description => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea"));

        //Click on Save Button
        IWebElement Save => driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]"));

        //Current Profile Description
        IWebElement CurrentDescription => driver.FindElement(By.XPath("(//SPAN)[16]"));

        //DIV[@class='ns-box-inner'][text()='First character can only be digit or letters']
        IWebElement NotificationMesssage => driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));

        private string notificationMessage;

        #endregion

        public void EditFullName()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            //Click on Edit button
            FullNameDropdownBtn.Click();

            FirstName.Clear();
            Thread.Sleep(500);
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            LastName.Clear();
            Thread.Sleep(500);
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            SaveFullName.Click();

            Thread.Sleep(1000);

            if (FullName.Text == GlobalDefinitions.ExcelLib.ReadData(2, "FullName"))
            {
               
                test.Log(Status.Pass, "Full Name updated Successfully");
            }
            else
            {
                test.Log(Status.Fail, "Full Name Not Updated");
            }
        }

        public void SelectAvailability(string availability)
        {
            //Availability Time option
            Thread.Sleep(1500);

            EditAvailabilityTime.Click();
            Thread.Sleep(500);
            SelectElement selectAvailability = new SelectElement(AvailabilityTimeOpt);
            selectAvailability.SelectByText(availability);
        }

        public string GetAvailabilityValue()
        {
            string availability = CurrentAvailability.Text;
            return availability;
        }

        public void SelectHours(string hours)
        {
            //Availability Time option
            Thread.Sleep(1500);

            EditAvailabilityHours.Click();
            Thread.Sleep(500);
            SelectElement selectHours = new SelectElement(AvailabilityHoursOpt);
            selectHours.SelectByText(hours);
        }

        public string GetHoursValue()
        {
            string hoursValue = CurrentHours.Text;
            return hoursValue;
        }

        public void EarnTarget(string salary)
        {
            //Availability Time option
            Thread.Sleep(1500);

            EditSalary.Click();
            Thread.Sleep(500);
            SelectElement salaryValue = new SelectElement(SalaryOpt);
            salaryValue.SelectByText(salary);
        }

        public string GetEarnTargetValue()
        {
            string salaryValue = CurrentSalaryValue.Text;
            return salaryValue;
        }

        public void AddDescription(string description)
        {
            Thread.Sleep(500);
            EditProfileDescription.Click();
            Thread.Sleep(1000);

            DescriptionTextArea.Clear();
            Thread.Sleep(1000);
            DescriptionTextArea.SendKeys("Empty this");
            Thread.Sleep(1000);
            DescriptionTextArea.Clear();
            Thread.Sleep(1000);
            DescriptionTextArea.SendKeys(description);
            Thread.Sleep(1000);
            SaveDescription.Click();

            Thread.Sleep(1000);

            notificationMessage = NotificationMesssage.Text;

        }

        public string GetDescriptionValue()
        {
            return CurrentDescription.Text;
        }

        public string GetNotificationMessage()
        {
            return notificationMessage;
        }

        public void ClickLanguageTab()
        {
            Thread.Sleep(500);
            LanguagesTab.Click();
        }

        public void AddNewLanguage(string lang, string level, string action)
        {
            //Click Langauge Tab
            ClickLanguageTab();

            //Click on Add New Language button
            Thread.Sleep(500);
            AddNewLanguageBtn.Click();
            Thread.Sleep(1000);
            //Enter the Language
            AddLanguageName.SendKeys(lang);

            //Set Language Level
            Thread.Sleep(500);
            LanguageLevelBtn.Click();
            Thread.Sleep(1000);
            SelectElement selectedLevel = new SelectElement(LanguageLevelBtn);
            selectedLevel.SelectByValue(level);
            Thread.Sleep(500);
            if (action == "Save")
                SaveLanguageBtn.Click();
            else
                CancelLanguageBtn.Click();
            
            Thread.Sleep(500);

            notificationMessage = NotificationMesssage.Text;            

        }

        /*
                    

                    //-----------------------------------------------------------
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

                    //---------------------------------------------------------
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

                    //-------------------------------------------------
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

                    //-----------------------------------------------------
                    //Add Description
                    Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
                    Thread.Sleep(500);
                    Save.Click();
                    Base.test.Log(LogStatus.Info, "Added Description successfully");
        */

    }
}
