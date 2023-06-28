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

namespace MarsFramework.Tests
{
    public class Profile_LanguagesTest : Base
    {
        [Test(Description = "Check if user is able to add new language with valid data--> English")]
        public void AddNewLanguageWithValidData()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
                string expectedLangLevel = GlobalDefinitions.ExcelLib.ReadData(2, "LanguageLevel");
                string expectedAction = GlobalDefinitions.ExcelLib.ReadData(2, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);


                // Assertion
                string message = ProfilePageObj.GetNotificationMessage();
                if (message == (expectedLanguage + " has been added to your languages"))
                {
                    Assert.That(message == (expectedLanguage + " has been added to your languages"), message);
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, " + expectedLanguage + " has been added to your languages");
                }
                else {
                    if (message == "This language is already exist in your language list.")
                        Assert.That(message == "This language is already exist in your language list.", message);
                    else if (message == "Duplicated data")
                        Assert.That(message == "Duplicated data", message);
                    else if (message == "This language is already added to your language list.")
                        Assert.That(message == "This language is already added to your language list.", message);
                    else if (message == "Please enter language and level")
                        Assert.That(message == "Please enter language and level", message);

                    // Log status in Extentreports
                    test.Log(Status.Pass, message);
                }

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

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
                string expectedLangLevel = GlobalDefinitions.ExcelLib.ReadData(2, "LanguageLevel");
                string expectedAction = GlobalDefinitions.ExcelLib.ReadData(2, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);


                // Assertion
                string message = ProfilePageObj.GetNotificationMessage();
                if (message == (expectedLanguage + " has been added to your languages"))
                {
                    Assert.That(message == (expectedLanguage + " has been added to your languages"), message);
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, " + expectedLanguage + " has been added to your languages");
                }
                else
                {
                    if (message == "This language is already exist in your language list.")
                        Assert.That(message == "This language is already exist in your language list.", message);
                    else if (message == "Duplicated data")
                        Assert.That(message == "Duplicated data", message);
                    else if (message == "This language is already added to your language list.")
                        Assert.That(message == "This language is already added to your language list.", message);
                    else if (message == "Please enter language and level")
                        Assert.That(message == "Please enter language and level", message);

                    // Log status in Extentreports
                    test.Log(Status.Pass, message);
                }

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

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(3, "Language");
                string expectedLangLevel = GlobalDefinitions.ExcelLib.ReadData(3, "LanguageLevel");
                string expectedAction = GlobalDefinitions.ExcelLib.ReadData(3, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);


                // Assertion
                string message = ProfilePageObj.GetNotificationMessage();
                if (message == (expectedLanguage + " has been added to your languages"))
                {
                    Assert.That(message == (expectedLanguage + " has been added to your languages"), message);
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, " + expectedLanguage + " has been added to your languages");
                }
                else
                {
                    if (message == "This language is already exist in your language list.")
                        Assert.That(message == "This language is already exist in your language list.", message);
                    else if (message == "Duplicated data")
                        Assert.That(message == "Duplicated data", message);
                    else if (message == "This language is already added to your language list.")
                        Assert.That(message == "This language is already added to your language list.", message);
                    else if (message == "Please enter language and level")
                        Assert.That(message == "Please enter language and level", message);

                    // Log status in Extentreports
                    test.Log(Status.Pass, message);
                }

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

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(4, "Language");
                string expectedLangLevel = GlobalDefinitions.ExcelLib.ReadData(4, "LanguageLevel");
                string expectedAction = GlobalDefinitions.ExcelLib.ReadData(4, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);


                // Assertion
                string message = ProfilePageObj.GetNotificationMessage();
                if (message == (expectedLanguage + " has been added to your languages"))
                {
                    Assert.That(message == (expectedLanguage + " has been added to your languages"), message);
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, " + expectedLanguage + " has been added to your languages");
                }
                else
                {
                    if (message == "This language is already exist in your language list.")
                        Assert.That(message == "This language is already exist in your language list.", message);
                    else if (message == "Duplicated data")
                        Assert.That(message == "Duplicated data", message);
                    else if (message == "This language is already added to your language list.")
                        Assert.That(message == "This language is already added to your language list.", message);
                    else if (message == "Please enter language and level")
                        Assert.That(message == "Please enter language and level", message);

                    // Log status in Extentreports
                    test.Log(Status.Pass, message);
                }

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

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(6, "Language");
                string expectedLangLevel = GlobalDefinitions.ExcelLib.ReadData(6, "LanguageLevel");
                string expectedAction = GlobalDefinitions.ExcelLib.ReadData(6, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);


                // Assertion
                string message = ProfilePageObj.GetNotificationMessage();
                if (message == (expectedLanguage + " has been added to your languages"))
                {
                    Assert.That(message == (expectedLanguage + " has been added to your languages"), message);
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, " + expectedLanguage + " has been added to your languages");
                }
                else
                {
                    if (message == "This language is already exist in your language list.")
                        Assert.That(message == "This language is already exist in your language list.", message);
                    else if (message == "Duplicated data")
                        Assert.That(message == "Duplicated data", message);
                    else if (message == "This language is already added to your language list.")
                        Assert.That(message == "This language is already added to your language list.", message);
                    else if (message == "Please enter language and level")
                        Assert.That(message == "Please enter language and level", message);

                    // Log status in Extentreports
                    test.Log(Status.Pass, message);
                }

            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add language with more than 500 characters")]
        public void AddLanguageWithSixHundredCharacters()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Add new Language   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedLanguage = GlobalDefinitions.ExcelLib.ReadData(7, "Language");
                string expectedLangLevel = GlobalDefinitions.ExcelLib.ReadData(7, "LanguageLevel");
                string expectedAction = GlobalDefinitions.ExcelLib.ReadData(7, "AddLanguageAction");
                ProfilePageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);


                // Assertion
                string message = ProfilePageObj.GetNotificationMessage();
                if (message == (expectedLanguage + " has been added to your languages"))
                {
                    Assert.That(message == (expectedLanguage + " has been added to your languages"), message);
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, " + expectedLanguage + " has been added to your languages");
                }
                else
                {
                    if (message == "This language is already exist in your language list.")
                        Assert.That(message == "This language is already exist in your language list.", message);
                    else if (message == "Duplicated data")
                        Assert.That(message == "Duplicated data", message);
                    else if (message == "This language is already added to your language list.")
                        Assert.That(message == "This language is already added to your language list.", message);
                    else if (message == "Please enter language and level")
                        Assert.That(message == "Please enter language and level", message);

                    // Log status in Extentreports
                    test.Log(Status.Pass, message);
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