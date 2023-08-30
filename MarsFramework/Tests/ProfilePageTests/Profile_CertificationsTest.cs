using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;


namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_CertificationsTest : Base
    {
        [Test(Description = "Check if user is able to add new Certificate with valid data--> ISTQB, ANZTB, 2021")]
        public void AddNewCertificateWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(2);
        }

        [Test(Description = "Check if user is able to add duplicate Certificate--> ISTQB, ANZTB, 2021")]
        public void AddDuplicateCertificateName()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(2);
        }

        [Test(Description = "Check if user is able to add Certificate Name all in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddCertificateNameInSpecialCharacters()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(3);
        }

        [Test(Description = "Check if user is able to add Certificate with no provider")]
        public void AddCertificateWithOutProvider()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(4);
        }

        [Test(Description = "Check if user is able to add empty Certificate Name")]
        public void AddCertificateNameEmpty()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(5);
        }

        [Test(Description = "Check if user is able to add Certificate with No Year Certified ")]
        public void AddCertificateNoYear()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(6);
        }

        [Test(Description = "Check if user is able to add Certificate All Required fields empty ")]
        public void AddCertificateAllFieldsEmpty()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateAddCertificateInput(7);
        }

        [Test(Description = "Check if user is able to update an existing Certificate with valid data--> Updated Certificate")]
        public void EditCertificateWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Input
            SetUpAndValidateEditCertificateInput(9);
        }

        [Test(Description = "Check if user is able to delete an existing Skill --> First Row in the list")]

        public void DeleteExistingCertificate()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            SetUpAndValidateDeleteExistingCertificate();
        }

        private static void SetUpAndValidateDeleteExistingCertificate()
        {
            try
            {
                // Delete and Existing Certificate   
                ProfileCertificates certificateObj = new ProfileCertificates();
                certificateObj.DeleteCertificate();

                // Validation
                string message = certificateObj.GetNotificationMessage();
                certificateObj.ValidateDeleteCertificateResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndValidateAddCertificateInput(int rowNumber)
        {
            try
            {
                // Add new Certificate   
                ProfileCertificates certificateObj = new ProfileCertificates();
                string certicateName = ReadData(rowNumber, "CertificateName");
                string certifiedFrom = ReadData(rowNumber, "CertifiedFrom");
                string yearCertified = ReadData(rowNumber, "YearCertified");
                string expectedAction = ReadData(rowNumber, "AddCertificateAction");
                certificateObj.AddNewCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = certificateObj.GetNotificationMessage();
                certificateObj.ValidateAddCertificateResult(message, certicateName, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndValidateEditCertificateInput(int rowNumber)
        {
            try
            {
                // Edit an existing Certificate   
                ProfileCertificates certificateObj = new ProfileCertificates();
                string certicateName = ReadData(rowNumber, "CertificateName");
                string certifiedFrom = ReadData(rowNumber, "CertifiedFrom");
                string yearCertified = ReadData(rowNumber, "YearCertified");
                string expectedAction = ReadData(rowNumber, "AddCertificateAction");
                certificateObj.EditCertificate(certicateName, certifiedFrom, yearCertified, expectedAction);

                // Validation
                string message = certificateObj.GetNotificationMessage();
                certificateObj.ValidateEditCertificateResult(message, certicateName, test);
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
