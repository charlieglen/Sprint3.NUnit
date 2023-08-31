using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;


namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_HoursTest : Base
    {
        [Test(Description = "Check if user is able to assign initial Hours as - Less than 30hours a week")]
        public void SelectHours()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate hours selected
            SetUpAndValidateHoursSelected(2);
        }

        [Test(Description = "Check if user is able to update current Hours as - As needed")]
        public void EditHours()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate hours selected
            SetUpAndValidateHoursSelected(4);
        }

        private static void SetUpAndValidateHoursSelected(int rowNumber)
        {
            try
            {
                // Select Availability     
                ProfileHours hoursObj = new ProfileHours();
                string expectedResult = ReadData(rowNumber, "AvailableHours");
                hoursObj.SelectHours(expectedResult);

                // Assertion
                string result = hoursObj.GetHoursValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Hours successfully selected.");
                test.Log(Status.Info, "Hours Selected " + result);
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
