using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_EarnTargetTest : Base
    {
        [Test, Order(1)]
        public void SelectEarnTarget()
        {
            //Description = "Check if user is able to assign initial Salary as - Less than $500 per month"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Salary selected
            SetUpAndValidateEarnTargetSelected(2);
        }
       
        [Test, Order(2)]
        public void EditEarnTarget()
        {
            //Description = "Check if user is able to update current Salary as - More than $1000 per month"

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and Validate Salary selected
            SetUpAndValidateEarnTargetSelected(4);
        }
        private static void SetUpAndValidateEarnTargetSelected(int rowNumber)
        {
            try
            {
                // Select Salary     
                ProfileEarnTarget earnTargetObj = new ProfileEarnTarget();
                string expectedResult = ReadData(rowNumber, "EarnTarget");
                earnTargetObj.EarnTarget(expectedResult);

                // Assertion
                string result = earnTargetObj.GetEarnTargetValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Earn Target successfully selected.");
                test.Log(Status.Info, "Salary Selected " + result);
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
