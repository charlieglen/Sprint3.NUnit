using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_DescriptionTest : Base
    {
        [Test, Order(1)]
        public void AddDescription()
        {
            //Description = "Valid Description Input, starts with a digit or letter, Less than or equal to 600 characters"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set Up and validate profile description
            SetUpAndValidateAddProfileDecription(2);
        }

        [Test, Order(2)]
        public void EditDescriptionMoreThanMaxLength()
        {
            //Description = "InValid Length of Input, More than 600 characters"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set Up and validate profile description
            SetUpAndValidateAddProfileDecription(3);
        }

        [Test, Order(3)]
        public void EditDescriptionInvalidCharacters()
        {
            //Description = "Invalid Input, All invalid characters = !@#$%^&*()_+<>,.?~`"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set Up and validate profile description
            SetUpAndValidateAddProfileDecription(4);
        }

        [Test, Order(4)]
        public void EditDescriptionStartsWithASpace()
        {
            //Description = "Input starts with a space"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set Up and validate profile description
            SetUpAndValidateAddProfileDecription(5);
        }

        [Test, Order(5)]
        public void EditDescriptionExtraSpacesAfterValidInput()
        {
            //Description = "Heaps of unwanted spaces after a valid text. Total of 236 characters including spaces"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set Up and validate profile description
            SetUpAndValidateAddProfileDecription(6);
        }

        [Test, Order(6)]
        public void EditDescriptionEmptyText()
        {
            //Description = "Empty Text"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set Up and validate profile description
            SetUpAndValidateAddProfileDecription(7);
        }
        private static void SetUpAndValidateAddProfileDecription(int rowNumber)
        {
            try
            {
                // Add new profile description
                ProfileDescription descriptionObj = new ProfileDescription();

                string expectedDescription = ReadData(rowNumber, "Description");
                descriptionObj.AddDescription(expectedDescription);

                string currentNotification = descriptionObj.GetNotificationMessage();
                string currentDescription = descriptionObj.GetDescriptionValue();

                // Validation
                descriptionObj.ValidateDescription(currentNotification, currentDescription, expectedDescription, test);
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
