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
using static MarsFramework.Global.GlobalDefinitions.Wait;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;
using Microsoft.Office.Interop.Excel;
//


namespace MarsFramework.Pages
{
    public class ProfilePage : Base
    {
        public ProfilePage()
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
        //IWebElement CurrentSalaryValue => driver.FindElement(By.XPath("(//SPAN)[14]"));

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
        IWebElement SkillsTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

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

        IWebElement SkillToUpdate => driver.FindElement(By.XPath("(//I[@class='outline write icon'])[4]"));
        IWebElement SkillToDelete => driver.FindElement(By.XPath("(//I[@class='remove icon'])[3]"));

        //Click on Education Tab
        IWebElement EducationTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));

        //Click on Add new to Education
        IWebElement AddNewEducationBtn => driver.FindElement(By.XPath("(//DIV[@class='ui teal button '])[2]"));

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

        IWebElement EducationToUpdate => driver.FindElement(By.XPath("(//I[@class='outline write icon'])[5]"));
        IWebElement EducationToDelete => driver.FindElement(By.XPath("(//I[@class='remove icon'])[4]"));

        //Click on Education Tab
        IWebElement CertificationsTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));

        //Click Add new Certification button
        IWebElement AddNewCertificationBtn => driver.FindElement(By.XPath("(//DIV[@class='ui teal button '][text()='Add New'])[3]"));

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

        IWebElement CertificateToUpdate => driver.FindElement(By.XPath("(//I[@class='outline write icon'])[8]"));
        IWebElement CertificateToDelete => driver.FindElement(By.XPath("(//I[@class='remove icon'])[7]"));

        //Current Profile Description
        IWebElement CurrentDescription => driver.FindElement(By.XPath("(//SPAN)[16]"));

        //DIV[@class='ns-box-inner'][text()='First character can only be digit or letters']
        IWebElement NotificationMesssage => driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));

        private string notificationMessage="";
        private string hoursValue="";
        private string availability = "";
        private string salaryValue = "";

        #endregion

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

        public void SelectHours(string hours)
        {
            //Availability Time option
            wait(30);
            EditAvailabilityHours.Click();
            wait(30);
            SelectElement selectHours = new SelectElement(AvailabilityHoursOpt);
            selectHours.SelectByText(hours);
            wait(30);
            hoursValue = CurrentHours.Text;
        }

        public string GetHoursValue()
        {            
            return hoursValue;
        }

        public void EarnTarget(string salary)
        {
            //Availability Time option
            wait(30);
            EditSalary.Click();
            wait(30);
            SelectElement earnTargetValue = new SelectElement(SalaryOpt);
            earnTargetValue.SelectByText(salary);
            wait(50);
            
            //salaryValue = driver.FindElement(By.XPath("(//SPAN)[14]")).Text;
            //salaryValue = CurrentSalaryValue.Text;
        }

        public string GetEarnTargetValue()
        {            
            return driver.FindElement(By.XPath("(//SPAN)[14]")).Text; 
        }

        public void AddDescription(string description)
        {
            wait(30);
            EditProfileDescription.Click();
            wait(30);
            DescriptionTextArea.Click();            
            DescriptionTextArea.Clear();
            wait(30);
            DescriptionTextArea.SendKeys(description);
            wait(30);
            SaveDescription.Click();

            wait(30);

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
            wait(30);
            LanguagesTab.Click();

            if (AddNewLanguageBtn.Displayed) { 
                //Click on Add New Language button
                wait(30);
                AddNewLanguageBtn.Click();

                wait(30);
                //Enter the Language
                AddLanguageName.SendKeys(lang);

                //Set Language Level
                wait(30);
                LanguageLevelBtn.Click();
                wait(30);
                SelectElement selectedLevel = new SelectElement(LanguageLevelBtn);
                selectedLevel.SelectByValue(level);
                wait(30);

                //Click action
                if (action == "Save")
                    SaveLanguageBtn.Click();
                else
                    CancelLanguageBtn.Click();
            }
            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

        public void EditLanguage(string lang, string level, string action)
        {
            //Click Language Tab
            wait(30);
            LanguagesTab.Click();
                
            //Click Edit Language button (first row)
            wait(30);
            LanguageToUpdate.Click();

            wait(30);
            //Clear the Language Textbox
            AddLanguageName.Clear();

            wait(30);
            //Enter the Language
            AddLanguageName.SendKeys(lang);

            //Set Language Level
            wait(30);
            LanguageLevelBtn.Click();
            wait(30);
            SelectElement selectedLevel = new SelectElement(LanguageLevelBtn);
            selectedLevel.SelectByValue(level);
            wait(30);

            //Click action
            if (action == "Save")
                SaveLanguageBtn.Click();
            else
                CancelLanguageBtn.Click();

            wait(30);

            notificationMessage = NotificationMesssage.Text;            
        }

        public void DeleteLanguage()
        {
            //Click Language Tab
            wait(30);
            LanguagesTab.Click();

            //Click Delete Language button (first row)
            wait(30);
            LanguageToDelete.Click();

            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }



        public void AddNewSkill(string skill, string level, string action)
        {
            //Click Skills Tab
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 50);
            SkillsTab.Click();          

            if (AddNewSkillBtn.Displayed)
            {
                //Click on Add New Skill Button
                wait(30);
                AddNewSkillBtn.Click();
                //Enter the skill 
                AddSkillName.SendKeys(skill);

                //Click the skill level dropdown
                wait(30);
                SkillLevelBtn.Click();
                wait(30);
                SelectElement selectedLevel = new SelectElement(SkillLevelBtn);
                selectedLevel.SelectByValue(level);
                wait(30);

                //Click action
                if (action == "Save")
                    SaveSkillBtn.Click();
                else
                    CancelSkillBtn.Click();              
            }

            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

        public void EditSkill(string lang, string level, string action)
        {
            //Click Skills Tab
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 50);
            SkillsTab.Click();

            //Click Edit Skill button (first row)
            wait(30);
            SkillToUpdate.Click();

            wait(30);
            //Clear the Skill Name
            AddSkillName.Clear();

            wait(30);
            //Enter the Skill
            AddSkillName.SendKeys(lang);

            //Set Skill Level
            wait(30);
            SkillLevelBtn.Click();
            wait(30);
            SelectElement selectedLevel = new SelectElement(SkillLevelBtn);
            selectedLevel.SelectByValue(level);
            wait(30);

            //Click action
            if (action == "Save")
                SaveSkillBtn.Click();
            else
                CancelSkillBtn.Click();

            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

        public void DeleteSkill()
        {
            //Click Skills Tab
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 50);
            SkillsTab.Click();

            //Click Delete Skill button (first row)
            wait(30);
            SkillToDelete.Click();

            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }


        public void AddNewEducation(string university, string country, string title, string degree, string degreeYear, string action)
        {
            //Click Education Tab
            wait(30);
            EducationTab.Click();

            if (AddNewEducationBtn.Displayed)
            {
                wait(30);
                //Click Add Education button
                AddNewEducationBtn.Click();

                wait(30);
                //Enter the University
                EnterUniversityName.SendKeys(university);

                //Choose Country
                wait(30);
                ChooseCountryBtn.Click();
                wait(500);
                SelectElement selectedCountry = new SelectElement(ChooseCountryBtn);
                selectedCountry.SelectByValue(country);

                //Choose Title
                wait(30);
                ChooseTitleBtn.Click();
                wait(50);
                SelectElement selectedTitle = new SelectElement(ChooseTitleBtn);
                selectedTitle.SelectByValue(title);

                //Enter Degree
                wait(30);
                Degree.SendKeys(degree);

                //Year of Graduation
                wait(30);
                DegreeYear.Click();
                wait(30);
                SelectElement selectedYear = new SelectElement(DegreeYear);
                selectedYear.SelectByValue(degreeYear);

                //Click action
                wait(30);
                if (action == "Save")
                    SaveEducationBtn.Click();
                else
                    CancelEducationBtn.Click();
            }
            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

             
        public void EditEducation(string university, string country, string title, string degree, string degreeYear, string action)
        {
            //Click Education Tab
            wait(30);
            EducationTab.Click();

            wait(30);
            //Click Edit Education button (first row)
            EducationToUpdate.Click();

            wait(30);
            //Clear the University Name
            EnterUniversityName.Clear();

            wait(30);
            //Enter the University
            EnterUniversityName.SendKeys(university);

            //Choose Country
            Wait.WaitToBeClickable("XPath", "(//SELECT[@class='ui fluid dropdown'])[1]", 100);
            ChooseCountryBtn.Click();
            wait(500);
            SelectElement selectedCountry = new SelectElement(ChooseCountryBtn);
            selectedCountry.SelectByValue(country);

            //Choose Title
            wait(30);
            ChooseTitleBtn.Click();
            wait(50);
            SelectElement selectedTitle = new SelectElement(ChooseTitleBtn);
            selectedTitle.SelectByValue(title);

            //Clear the Degree Value
            wait(30);
            Degree.Clear();

            //Enter Degree
            wait(30);
            Degree.SendKeys(degree);

            //Year of Graduation
            wait(30);
            DegreeYear.Click();
            wait(30);
            SelectElement selectedYear = new SelectElement(DegreeYear);
            selectedYear.SelectByValue(degreeYear);

            //Click action
            wait(30);
            if (action == "Save")
                SaveEducationBtn.Click();
            else
                CancelEducationBtn.Click();
            
            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

        public void DeleteEducation()
        {
            //Click Education Tab
            wait(30);
            EducationTab.Click();

            //Click Delete Skill button (first row)
            wait(30);
            EducationToDelete.Click();

            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }




        public void AddNewCertificate(string certName, string certFrom, string yearCert, string action)
        {
            //Click Certificate Tab
            wait(30);
            CertificationsTab.Click();

            if (AddNewCertificationBtn.Displayed)
            {
                //Add new Certificate button
                wait(30);
                AddNewCertificationBtn.Click();

                //Enter Certificate Name
                wait(30);
                EnterCerticateName.SendKeys(certName);

                //Enter Certified from
                wait(30);
                CertifiedFrom.SendKeys(certFrom);

                //Enter the Year Certified
                wait(30);
                YearCertified.Click();
                wait(30);
                SelectElement selectedYear = new SelectElement(YearCertified);
                selectedYear.SelectByValue(yearCert);

                //Click action
                wait(30);
                if (action == "Save")
                    SaveCertificateBtn.Click();
                else
                    CancelCertificateBtn.Click();
            }
                wait(30);
                notificationMessage = NotificationMesssage.Text;
        }
        
        public void EditCertificate(string certName, string certFrom, string yearCert, string action)
        {
            //Click Certificate Tab
            wait(30);
            CertificationsTab.Click();
                        
            //Click Edit Certificate button (first row)
            wait(30);
            CertificateToUpdate.Click();

            wait(30);
            //Clear the Certificate Name Textbox
            EnterCerticateName.Clear();

            //Enter Certificate Name
            wait(30);
            EnterCerticateName.SendKeys(certName);

            wait(30);
            //Clear the Certificate From Textbox
            CertifiedFrom.Clear();

            //Enter Certified from
            wait(30);
            CertifiedFrom.SendKeys(certFrom);

            //Enter the Year Certified
            wait(30);
            YearCertified.Click();
            wait(30);
            SelectElement selectedYear = new SelectElement(YearCertified);
            selectedYear.SelectByValue(yearCert);

            //Click action
            wait(30);
            if (action == "Save")
                SaveCertificateBtn.Click();
            else
                CancelCertificateBtn.Click();
            
            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

        public void DeleteCertificate()
        {
            //Click Certificate Tab
            wait(30);
            CertificationsTab.Click();

            //Click Delete Certificate button (first row)
            wait(30);
            CertificateToDelete.Click();

            wait(30);
            notificationMessage = NotificationMesssage.Text;
        }

    }
}
