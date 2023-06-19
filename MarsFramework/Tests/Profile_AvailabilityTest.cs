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
    public class Profile_AvailabilityTest : Base
    {
        [Test(Description = "Check if user is able to assign initial Availability as Full Time")]
        public void SelectAvailability()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            try
            {
                // Select Availability     
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime");
                ProfilePageObj.SelectAvailability(expectedResult);

                // Assertion
                string result = ProfilePageObj.GetAvailabilityValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Availability successfully selected.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to update Availability as Part Time")]
        public void EditAvailability()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            try
            {
                // Edit Availability     
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedResult = GlobalDefinitions.ExcelLib.ReadData(3, "AvailableTime");
                ProfilePageObj.SelectAvailability(expectedResult);

                // Assertion
                string result = ProfilePageObj.GetAvailabilityValue();
                Assert.That(result, Is.EqualTo(expectedResult));

                // Log status in Extentreports
                test.Log(Status.Pass, "Passed, Availability successfully updated.");
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
