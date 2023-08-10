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
using System.Reflection.Emit;

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
        
        //First row in Language to Update
        IWebElement LanguageToUpdate => driver.FindElement(By.XPath("(//I[@class='outline write icon'])[2]"));

        //First row in Language to Delete
        IWebElement LanguageToDelete => driver.FindElement(By.XPath("(//I[@class='remove icon'])[1]"));
                
        //Click on Skills Tab
        IWebElement SkillsTab => driver.FindElement(By.XPath("//A[@class='item active'][text()='Skills']"));


        //Click on Add new to add new skill
        IWebElement AddNewSkillBtn => driver.FindElement(By.XPath("//DIV[@class='ui teal button'][text()='Add New']"));

        //Enter the Skill on text box
        IWebElement AddSkillName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));

        //Click on skill level dropdown
        IWebElement SkillLevelBtn => driver.FindElement(By.XPath("//SELECT[@class='ui fluid dropdown']"));
                
        //Add Skill
        IWebElement SaveSkillBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]"));

        //Click Cancel button to cancel new skill entry
        IWebElement CancelSkillBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[2]"));

        //Click on Education Tab
        IWebElement EducationTab => driver.FindElement(By.XPath("//A[@class='item active'][text()='Education']"));

        //Click on Add new to Education
        IWebElement AddNewEducationBtn => driver.FindElement(By.XPath("(//DIV[@class='ui teal button '])[1]"));

        //Enter university in the text box
        IWebElement EnterUniversityName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));

        //Choose the Country dropdown
        IWebElement ChooseCountryBtn => driver.FindElement(By.XPath("(//SELECT[@class='ui dropdown'])[1]"));
               
        //Click on Title dropdown
        IWebElement ChooseTitleBtn => driver.FindElement(By.XPath("(//SELECT[@class='ui dropdown'])[2]"));
               
        //Degree
        IWebElement Degree => driver.FindElement(By.XPath("(//INPUT[@type='text'])[5]"));

        //Year of graduation
        IWebElement DegreeYear => driver.FindElement(By.XPath("(//SELECT[@class='ui dropdown'])[3]"));
               
        //Click on Add Education details button
        IWebElement SaveEducationBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]"));

        //Click Cancel button to cancel new education entry
        IWebElement CancelEducationBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[2]"));

        //Click on Education Tab
        IWebElement CertificationsTab => driver.FindElement(By.XPath("//A[@class='item'][text()='Certifications']"));

        //Click Add new Certification button
        IWebElement AddNewCertificationBtn => driver.FindElement(By.XPath("(//DIV[@class='ui teal button '][text()='Add New'])[2]"));

        //Enter Certificate Name
        IWebElement EnterCerticateName => driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));

        //enter Certified from
        IWebElement CertifiedFrom => driver.FindElement(By.XPath("(//INPUT[@type='text'])[5]"));

        //Enter Year Certified
        IWebElement YearCertified => driver.FindElement(By.XPath("//SELECT[@class='ui fluid dropdown']"));
                
        //Click Add Ceritification details
        IWebElement SaveCertificateBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]"));

        //Click Cancel button to cancel new certification entry
        IWebElement CancelCertificateBtn => driver.FindElement(By.XPath("(//INPUT[@type='button'])[2]"));

        //Current Profile Description
        IWebElement CurrentDescription => driver.FindElement(By.XPath("(//SPAN)[16]"));

        //DIV[@class='ns-box-inner'][text()='First character can only be digit or letters']
        IWebElement NotificationMesssage => driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));

        private string notificationMessage="";

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
            DescriptionTextArea.Click();            
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

        public void AddNewLanguage(string lang, string level, string action)
        {
            //Click Language Tab
            Thread.Sleep(500);
            LanguagesTab.Click();

            if (AddNewLanguageBtn.Displayed) { 
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

                //Click action
                if (action == "Save")
                    SaveLanguageBtn.Click();
                else
                    CancelLanguageBtn.Click();

                Thread.Sleep(1000);

                notificationMessage = NotificationMesssage.Text;
            }
            else {
                notificationMessage = "List is full. Only 4 languages are required.";
            }
        }

        public void EditLanguage(string lang, string level, string action)
        {
            //Click Language Tab
            Thread.Sleep(500);
            LanguagesTab.Click();
                
                //Click Edit Language button (first row)
                Thread.Sleep(500);
                LanguageToUpdate.Click();

                Thread.Sleep(1000);
                //Clear the Language Textbox
                AddLanguageName.Clear();

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

                //Click action
                if (action == "Save")
                    SaveLanguageBtn.Click();
                else
                    CancelLanguageBtn.Click();

                Thread.Sleep(1000);

                notificationMessage = NotificationMesssage.Text;            
        }

        public void DeleteLanguage()
        {
            //Click Language Tab
            Thread.Sleep(500);
            LanguagesTab.Click();

            //Click Delete Language button (first row)
            Thread.Sleep(500);
            LanguageToDelete.Click();

            Thread.Sleep(500);
            notificationMessage = NotificationMesssage.Text;
        }

        public void AddNewSkill(string skill, string level, string action)
        {
            //Click Skills Tab
            Thread.Sleep(500);
            SkillsTab.Click();

            if (AddNewSkillBtn.Displayed)
            {
                //Click on Add New Skill Button
                AddNewSkillBtn.Click();
                //Enter the skill 
                AddSkillName.SendKeys(skill);

                //Click the skill level dropdown
                Thread.Sleep(500);
                SkillLevelBtn.Click();
                Thread.Sleep(1000);
                SelectElement selectedLevel = new SelectElement(SkillLevelBtn);
                selectedLevel.SelectByValue(level);
                Thread.Sleep(500);

                //Click action
                if (action == "Save")
                    SaveSkillBtn.Click();
                else
                    CancelSkillBtn.Click();

                Thread.Sleep(500);
                notificationMessage = NotificationMesssage.Text;
            }
            else
            {
                notificationMessage = "List is full.";
            }
        }

        public void AddNewEducation(string university, string country, string title, string degree, string degreeYear, string action)
        {
            //Click Skills Tab
            Thread.Sleep(500);
            EducationTab.Click();

            //Click Add Education button
            AddNewEducationBtn.Click();
            //Enter the University
            EnterUniversityName.SendKeys(university);

            //Choose Country
            Thread.Sleep(500);
            ChooseCountryBtn.Click();
            Thread.Sleep(1000);
            SelectElement selectedCountry = new SelectElement(ChooseCountryBtn);
            selectedCountry.SelectByValue(country);

            //Choose Title
            Thread.Sleep(500);
            ChooseTitleBtn.Click();
            Thread.Sleep(1000);
            SelectElement selectedTitle= new SelectElement(ChooseTitleBtn);
            selectedTitle.SelectByValue(title);

            //Enter Degree
            Thread.Sleep(500);
            Degree.SendKeys(degree);

            //Year of Graduation
            Thread.Sleep(500);
            DegreeYear.Click();
            Thread.Sleep(1000);
            SelectElement selectedYear = new SelectElement(DegreeYear);
            selectedYear.SelectByValue(degreeYear);

            //Click action
            Thread.Sleep(500);
            if (action == "Save")
                SaveEducationBtn.Click();
            else
                CancelEducationBtn.Click();

            Thread.Sleep(500);
            notificationMessage = NotificationMesssage.Text;
        }

        public void AddNewCertificate(string certName, string certFrom, string yearCert, string action)
        {
            //Click Skills Tab
            Thread.Sleep(500);
            CertificationsTab.Click();

            //Add new Certificate button
            Thread.Sleep(500);
            AddNewCertificationBtn.Click();

            //Enter Certificate Name
            Thread.Sleep(500);
            EnterCerticateName.SendKeys(certName);

            //Enter Certified from
            Thread.Sleep(500);
            CertifiedFrom.SendKeys(certFrom);

            //Enter the Year Certified
            Thread.Sleep(500);
            YearCertified.Click();
            Thread.Sleep(1000);
            SelectElement selectedYear = new SelectElement(YearCertified);
            selectedYear.SelectByValue(yearCert);

            //Click action
            Thread.Sleep(500);
            if (action == "Save")
                SaveEducationBtn.Click();
            else
                CancelEducationBtn.Click();

            Thread.Sleep(500);
            notificationMessage = NotificationMesssage.Text;

        }
       
    }
}
