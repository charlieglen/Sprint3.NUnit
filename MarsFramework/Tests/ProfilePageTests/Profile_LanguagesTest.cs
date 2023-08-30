using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_LanguagesTest : Base
    {
        [Test(Description = "Check if user is able to add new language with valid data--> English")]
        public void AddNewLanguageWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpandValidateAddLanguageInput(2);
        }

        [Test(Description = "Check if user is able to add duplicate language--> English")]
        public void AddDuplicateLanguage()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpandValidateAddLanguageInput(2);
        }

        [Test(Description = "Check if user is able to add language all in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddLanguageInSpecialCharacters()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpandValidateAddLanguageInput(3);
        }

        [Test(Description = "Check if user is able to add language with no language level selected")]
        public void AddLanguageWithOutLevel()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpandValidateAddLanguageInput(4);
        }

        [Test(Description = "Check if user is able to add empty language name")]
        public void AddLanguageEmptyLanguageName()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpandValidateAddLanguageInput(6);
        }

        [Test(Description = "Check if user is able to update an existing language with valid data--> Updated Language")]
        public void EditLanguageWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Edit Existing Language
            SetUpandValidateEditLanguage(10);
        }

        [Test(Description = "Check if user is able to delete an existing language --> First Row in the list")]

        public void DeleteExistingLanguage()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Delete Existing Language
            SetUpAndDeleteExistingLanguage();
        }



        private static void SetUpandValidateAddLanguageInput(int rowNumber)
        {
            try
            {
                //Add new language
                ProfileLanguages languageObj = new ProfileLanguages();
                string expectedLanguage = ReadData(rowNumber, "Language");
                string expectedLangLevel = ReadData(rowNumber, "LanguageLevel");
                string expectedAction = ReadData(rowNumber, "AddLanguageAction");
                languageObj.AddNewLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = languageObj.GetNotificationMessage();
                languageObj.ValidateAddLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpandValidateEditLanguage(int rowNumber)
        {
            try
            {
                // Edit existing Language   
                ProfileLanguages languageObj = new ProfileLanguages();
                string expectedLanguage = ReadData(rowNumber, "Language");
                string expectedLangLevel = ReadData(rowNumber, "LanguageLevel");
                string expectedAction = ReadData(rowNumber, "AddLanguageAction");
                languageObj.EditLanguage(expectedLanguage, expectedLangLevel, expectedAction);

                // Validation
                string message = languageObj.GetNotificationMessage();
                languageObj.ValidateEditLanguageResult(message, expectedLanguage, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndDeleteExistingLanguage()
        {
            try
            {
                // Delete existing Language   
                ProfileLanguages languageObj = new ProfileLanguages();
                languageObj.DeleteLanguage();

                // Validation
                string message = languageObj.GetNotificationMessage();
                languageObj.ValidateDeleteLanguageResult(message, test);
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
