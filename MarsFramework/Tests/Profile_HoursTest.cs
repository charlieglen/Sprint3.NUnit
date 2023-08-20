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
    public class Profile_HoursTest : Base
    {
        [Test(Description = "Check if user is able to assign initial Hours as - Less than 30hours a week")]
        public void SelectHours()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            
            try
            {
                // Select Availability     
                ProfilePage ProfileObj = new ProfilePage();
                string expectedResult = ReadData(2, "AvailableHours");
                ProfileObj.SelectHours(expectedResult);

                // Assertion
                string result = ProfileObj.GetHoursValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Hours successfully selected.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to update current Hours as - As needed")]
        public void EditHours()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Edit Availability     
                ProfilePage ProfileObj = new ProfilePage();
                string expectedResult = ReadData(4, "AvailableHours");
                ProfileObj.SelectHours(expectedResult);

                // Assertion
                string result = ProfileObj.GetHoursValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Hours successfully updated.");
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
