using AventStack.ExtentReports;
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
    public class Profile_EducationTest : Base        
    {
        [Test(Description = "Check if user is able to add new Education with valid data--> all required fields")]
        public void AddNewEducationWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(2, "University");
                string country = ReadData(2, "CountryOfUniversity");
                string educationTitle = ReadData(2, "Title");
                string educationDegree = ReadData(2, "Degree");
                string yearGraduated = ReadData(2, "YearGraduated");
                string expectedAction = ReadData(2, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }

        }

        [Test(Description = "Check if user is able to add duplicate Education --> all required fields")]
        public void AddDuplicateEducation()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(2, "University");
                string country = ReadData(2, "CountryOfUniversity");
                string educationTitle = ReadData(2, "Title");
                string educationDegree = ReadData(2, "Degree");
                string yearGraduated = ReadData(2, "YearGraduated");
                string expectedAction = ReadData(2, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education all input boxes in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddEducationInSpecialCharacters()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(3, "University");
                string country = ReadData(3, "CountryOfUniversity");
                string educationTitle = ReadData(3, "Title");
                string educationDegree = ReadData(3, "Degree");
                string yearGraduated = ReadData(3, "YearGraduated");
                string expectedAction = ReadData(3, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education with No University")]
        public void AddEducationWithMissingUniversity()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(4, "University");
                string country = ReadData(4, "CountryOfUniversity");
                string educationTitle = ReadData(4, "Title");
                string educationDegree = ReadData(4, "Degree");
                string yearGraduated = ReadData(4, "YearGraduated");
                string expectedAction = ReadData(4, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education with No Country")]
        public void AddEducationWithMissingCountryOfUniversity()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(5, "University");
                string country = ReadData(5, "CountryOfUniversity");
                string educationTitle = ReadData(5, "Title");
                string educationDegree = ReadData(5, "Degree");
                string yearGraduated = ReadData(5, "YearGraduated");
                string expectedAction = ReadData(5, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education with No Title")]
        public void AddEducationWithMissingTitle()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(6, "University");
                string country = ReadData(6, "CountryOfUniversity");
                string educationTitle = ReadData(6, "Title");
                string educationDegree = ReadData(6, "Degree");
                string yearGraduated = ReadData(6, "YearGraduated");
                string expectedAction = ReadData(6, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education with No Degree")]
        public void AddEducationWithMissingDegree()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(7, "University");
                string country = ReadData(7, "CountryOfUniversity");
                string educationTitle = ReadData(7, "Title");
                string educationDegree = ReadData(7, "Degree");
                string yearGraduated = ReadData(7, "YearGraduated");
                string expectedAction = ReadData(7, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education with No Year of Graduation")]
        public void AddEducationWithNoYearGraduated()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(8, "University");
                string country = ReadData(8, "CountryOfUniversity");
                string educationTitle = ReadData(8, "Title");
                string educationDegree = ReadData(8, "Degree");
                string yearGraduated = ReadData(8, "YearGraduated");
                string expectedAction = ReadData(8, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Education with No Inputs")]
        public void AddEducationWithNoInputs()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(9, "University");
                string country = ReadData(9, "CountryOfUniversity");
                string educationTitle = ReadData(9, "Title");
                string educationDegree = ReadData(9, "Degree");
                string yearGraduated = ReadData(9, "YearGraduated");
                string expectedAction = ReadData(9, "AddEducationAction");
                ProfilePageObj.AddNewEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to update an existing Education with valid input data--> Updated Skill")]
        public void EditEducationlWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Education   
                ProfilePage ProfilePageObj = new ProfilePage();
                string universityName = ReadData(10, "University");
                string country = ReadData(10, "CountryOfUniversity");
                string educationTitle = ReadData(10, "Title");
                string educationDegree = ReadData(10, "Degree");
                string yearGraduated = ReadData(10, "YearGraduated");
                string expectedAction = ReadData(10, "AddEducationAction");
                ProfilePageObj.EditEducation(universityName, country, educationTitle, educationDegree, yearGraduated, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateEditEducationResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
        
        
        [Test(Description = "Check if user is able to delete an existing Education --> First Row in the list")]

        public void DeleteExistingEducation()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                ProfilePageObj.DeleteEducation();

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                if (message.Contains("Education entry successfully removed"))
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

