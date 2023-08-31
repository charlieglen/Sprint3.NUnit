using AventStack.ExtentReports;
using MarsFramework.Global;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;
using MarsFramework.Pages.ProfilePages;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_AvailabilityTest : Base
    {
        [Test(Description = "Check if user is able to assign initial Availability as Full Time")]
        public void SelectAvailability()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Availability Selected
            SetUpAndValidateAvailabiltyselected(2);
        }

        [Test(Description = "Check if user is able to update Availability as Part Time")]
        public void EditAvailability()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Availability Selected
            SetUpAndValidateAvailabiltyselected(3);
        }

        private static void SetUpAndValidateAvailabiltyselected(int rowNumber)
        {
            try
            {
                // Select Availability     
                ProfileAvailability availabilityObj = new ProfileAvailability();
                string expectedResult = ReadData(rowNumber, "AvailableTime");
                availabilityObj.SelectAvailability(expectedResult);

                // Assertion
                string result = availabilityObj.GetAvailabilityValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Availability successfully selected.");
                test.Log(Status.Info, "Availability Selected " + result);
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
