using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_EducationTest : Base
    {
        [Test, Order(1)]
        public void AddNewEducationWithValidData()
        {
            //Description = "Check if user is able to add new Education with valid data--> all required fields"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(2);
        }

        [Test, Order(2)]
        public void AddDuplicateEducation()
        {
            //Description = "Check if user is able to add duplicate Education --> all required fields"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(2);
        }

        [Test, Order(3)]
        public void AddEducationInSpecialCharacters()
        {
            //Description = "Check if user is able to add Education all input boxes in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ "

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(3);
        }

        [Test, Order(4)]
        public void AddEducationWithMissingUniversity()
        {
            //Description = "Check if user is able to add Education with No University"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(4);
        }

        [Test, Order(5)]
        public void AddEducationWithMissingCountryOfUniversity()
        {
            //Description = "Check if user is able to add Education with No Country"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(5);
        }

        [Test, Order(6)]
        public void AddEducationWithMissingTitle()
        {
            //Description = "Check if user is able to add Education with No Title"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(6);
        }

        [Test, Order(7)]
        public void AddEducationWithMissingDegree()
        {
            //Description = "Check if user is able to add Education with No Degree"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(7);
        }

        [Test, Order(8)]
        public void AddEducationWithNoYearGraduated()
        {
            //Description = "Check if user is able to add Education with No Year of Graduation"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(8);
        }

        [Test, Order(9)]
        public void AddEducationWithNoInputs()
        {
            //Description = "Check if user is able to add Education with No Inputs"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            //Set up and validate add new Education Input
            SetUpAndValidateAddEducationInput(9);
        }

        [Test, Order(10)]
        public void EditEducationlWithValidData()
        {
            //Description = "Check if user is able to update an existing Education with valid input data--> Updated Skill"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            //Set up and validate add new Education Input
            SetUpAndValidateEditEducation(10);
        }


        [Test, Order(11)]

        public void DeleteExistingEducation()
        {
            //Description = "Check if user is able to delete an existing Education --> First Row in the list"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            SetUpAndValidateDeleteExistingEducation();
        }

        private static void SetUpAndValidateDeleteExistingEducation()
        {
            try
            {
                // Delete an existing Education
                ProfileEducation educationObj = new ProfileEducation();
                educationObj.DeleteEducation();
                // Validation
                string message = educationObj.GetNotificationMessage();
                educationObj.ValidateDeleteEducation(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndValidateAddEducationInput(int rowNumber)
        {
            try
            {
                // Add new Education   
                ProfileEducation educationObj = new ProfileEducation();
                string universityName = ReadData(rowNumber, "University");
                string country = ReadData(rowNumber, "CountryOfUniversity");
                string educationTitle = ReadData(rowNumber, "Title");
                string educationDegree = ReadData(rowNumber, "Degree");
                string yearGraduated = ReadData(rowNumber, "YearGraduated");
                string expectedAction = ReadData(rowNumber, "AddEducationAction");
                educationObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = educationObj.GetNotificationMessage();
                educationObj.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndValidateEditEducation(int rowNumber)
        {
            try
            {
                // Update an existing Education   
                ProfileEducation educationObj = new ProfileEducation();
                string universityName = ReadData(rowNumber, "University");
                string country = ReadData(rowNumber, "CountryOfUniversity");
                string educationTitle = ReadData(rowNumber, "Title");
                string educationDegree = ReadData(rowNumber, "Degree");
                string yearGraduated = ReadData(rowNumber, "YearGraduated");
                string expectedAction = ReadData(rowNumber, "AddEducationAction");
                educationObj.EditEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = educationObj.GetNotificationMessage();
                educationObj.ValidateEditEducationResult(message, test);
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

