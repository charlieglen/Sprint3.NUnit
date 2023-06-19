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
    public class Profile_EarnTargetTest : Base
    {
        [Test(Description = "Check if user is able to assign initial Salary as - Less than $500 per month")]
        public void SelectEarnTarget()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Select Availability     
                ProfilePage ProfileObj = new ProfilePage();
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(2, "EarnTarget");
                ProfileObj.EarnTarget(expectedResult);

                // Assertion
                string result = ProfileObj.GetEarnTargetValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Earn Target successfully selected.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to update current Salary as - More than $1000 per month")]
        public void EditEarnTarget()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Edit Availability     
                ProfilePage ProfileObj = new ProfilePage();
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(4, "EarnTarget");
                ProfileObj.EarnTarget(expectedResult);

                // Assertion
                string result = ProfileObj.GetEarnTargetValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Earn Target successfully updated.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Update Unsuccessful.");
                test.Log(Status.Info, ex.Message);
            }
        }

    }
}
