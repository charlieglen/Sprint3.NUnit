﻿using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;

namespace MarsFramework.Tests
{
    public class Profile_LanguagesTest : Base
    {
        [Test(Description = "Check if user is able to add new language with valid data--> English")]
        public void AddNewLanguageWithValidData()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);           

            try
            {                
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = ReadData(2, "Language");
                string expectedLangLevel = ReadData(2, "LanguageLevel");
                string expectedAction = ReadData(2, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddLanguageResult(message, expectedLanguage, test);                
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        
        [Test(Description = "Check if user is able to add duplicate language--> English")]
        public void AddDuplicateLanguage()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

           try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = ReadData(2, "Language");
                string expectedLangLevel = ReadData(2, "LanguageLevel");
                string expectedAction = ReadData(2, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add language all in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddLanguageInSpecialCharacters()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = ReadData(3, "Language");
                string expectedLangLevel = ReadData(3, "LanguageLevel");
                string expectedAction = ReadData(3, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add language with no language level selected")]
        public void AddLanguageWithOutLevel()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = ReadData(4, "Language");
                string expectedLangLevel = ReadData(4, "LanguageLevel");
                string expectedAction = ReadData(4, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add empty text")]
        public void AddLanguageEmptyText()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = ReadData(6, "Language");
                string expectedLangLevel = ReadData(6, "LanguageLevel");
                string expectedAction = ReadData(6, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        
        [Test(Description = "Check if user is able to update an existing language with valid data--> Updated Language")]
        public void EditLanguageWithValidData()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = ReadData(10, "Language");
                string expectedLangLevel = ReadData(10, "LanguageLevel");
                string expectedAction = ReadData(10, "AddLanguageAction");
                ProfilePageObj.EditLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateEditLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
    
        [Test(Description = "Check if user is able to delete an existing language --> First Row in the list")]

        public void DeleteExistingLanguage()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                
                ProfilePageObj.DeleteLanguage();

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                if (message.Contains("has been deleted from your languages"))
                {
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Action successful");
                    test.Log(Status.Info, message);
                }
                else
                {
                    // Log status in Extentreports
                    test.Log(Status.Fail, "Action unsuccessful");
                    test.Log(Status.Info, message);
                }
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        
    }
}
