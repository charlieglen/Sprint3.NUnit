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

namespace MarsFramework.Tests
{
    public class Profile_DescriptionTest : Base
    {
        [Test(Description = "Valid Description Input, starts with a digit or letter, Less than or equal to 600 characters")]
        public void AddDescription()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);           
            
            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(2, "Description");                
                ProfileObj.AddDescription(expectedDescription);
                                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription,test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Valid Description Input, starts with a digit or letter, Less than or equal to 600 characters")]
        public void EditDescriptionValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            
            

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();
                
                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(2, "Description");                
                ProfileObj.AddDescription(expectedDescription);
                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "InValid Length of Input, More than 600 characters")]
        public void EditDescriptionMoreThanMaxLength()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);          

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(3, "Description");
                ProfileObj.AddDescription(expectedDescription);
                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Invalid Input, All invalid characters = !@#$%^&*()_+<>,.?~`")]
        public void EditDescriptionInvalidCharacters()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);         

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(4, "Description");
                ProfileObj.AddDescription(expectedDescription);
                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Input starts with a space")]
        public void EditDescriptionStartsWithASpace()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);           

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(5, "Description");
                ProfileObj.AddDescription(expectedDescription);
                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Heaps of unwanted spaces after a valid text. Total of 236 characters including spaces")]
        public void EditDescriptionExtraSpacesAfterValidInput()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {                
                ProfilePage ProfileObj = new ProfilePage();

                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(6, "Description");
                ProfileObj.AddDescription(expectedDescription);
                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Empty Text")]
        public void EditDescriptionEmptyText()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);           

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(7, "Description");
                ProfileObj.AddDescription(expectedDescription);
                
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                // Validation
                ProfileValidation.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        } 
    }
}
