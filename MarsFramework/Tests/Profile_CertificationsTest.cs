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
    public class Profile_CertificationsTest : Base
    {
        [Test(Description = "Check if user is able to add new Certificate with valid data--> ISTQB, ANZTB, 2021")]
        public void AddNewCertificateWithValidData()
        {            
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(2, "CertificateName");
                string certifiedFrom = ReadData(2, "CertifiedFrom");
                string yearCertified = ReadData(2, "YearCertified"); 
                string expectedAction = ReadData(2, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
            
        }
        
        [Test(Description = "Check if user is able to add duplicate Certificate--> ISTQB, ANZTB, 2021")]
        public void AddDuplicateCertificateName()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(2, "CertificateName");
                string certifiedFrom = ReadData(2, "CertifiedFrom");
                string yearCertified = ReadData(2, "YearCertified");
                string expectedAction = ReadData(2, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Certificate Name all in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddCertificateNameInSpecialCharacters()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(3, "CertificateName");
                string certifiedFrom = ReadData(3, "CertifiedFrom");
                string yearCertified = ReadData(3, "YearCertified");
                string expectedAction = ReadData(3, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Certificate with no provider")]
        public void AddCertificateWithOutProvider()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(4, "CertificateName");
                string certifiedFrom = ReadData(4, "CertifiedFrom");
                string yearCertified = ReadData(4, "YearCertified");
                string expectedAction = ReadData(4, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add empty Certificate Name")]
        public void AddCertificateNameEmpty()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(5, "CertificateName");
                string certifiedFrom = ReadData(5, "CertifiedFrom");
                string yearCertified = ReadData(5, "YearCertified");
                string expectedAction = ReadData(5, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Certificate with No Year Certified ")]
        public void AddCertificateNoYear()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(6, "CertificateName");
                string certifiedFrom = ReadData(6, "CertifiedFrom");
                string yearCertified = ReadData(6, "YearCertified");
                string expectedAction = ReadData(6, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Certificate All Required fields empty ")]
        public void AddCertificateAllFieldsEmpty()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(7, "CertificateName");
                string certifiedFrom = ReadData(7, "CertifiedFrom");
                string yearCertified = ReadData(7, "YearCertified");
                string expectedAction = ReadData(7, "AddCertificateAction");
                ProfilePageObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to update an existing Certificate with valid data--> Updated Certificate")]
        public void EditCertificateWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Certificate   
                ProfilePage ProfilePageObj = new ProfilePage();
                string certicateName = ReadData(9, "CertificateName");
                string certifiedFrom = ReadData(9, "CertifiedFrom");
                string yearCertified = ReadData(9, "YearCertified");
                string expectedAction = ReadData(9, "AddCertificateAction");
                ProfilePageObj.EditCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateEditCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to delete an existing Skill --> First Row in the list")]

        public void DeleteExistingCertificate()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                ProfilePageObj.DeleteCertificate();

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                if (message.Contains("has been deleted from your certification"))
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
