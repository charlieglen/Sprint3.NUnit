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
    public class Profile_SkillsTest : Base
    {
        [Test(Description = "Check if user is able to add new Skill with valid data--> Automation Testing")]
        public void AddNewSkillWithValidData()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedSkill = ReadData(2, "Skill");
                string expectedSkillLevel = ReadData(2, "SkillLevel");
                string expectedAction = ReadData(2, "AddSkillAction");
                ProfilePageObj.AddNewSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }
                
        [Test(Description = "Check if user is able to add duplicate Skill--> Automation Testing")]
        public void AddDuplicateSkill()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedSkill = ReadData(2, "Skill");
                string expectedSkillLevel = ReadData(2, "SkillLevel");
                string expectedAction = ReadData(2, "AddSkillAction");
                ProfilePageObj.AddNewSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Skill all in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddSkillInSpecialCharacters()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedSkill = ReadData(3, "Skill");
                string expectedSkillLevel = ReadData(3, "SkillLevel");
                string expectedAction = ReadData(3, "AddSkillAction");
                ProfilePageObj.AddNewSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add Skill with no Skill level selected")]
        public void AddSkillWithOutLevel()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedSkill = ReadData(4, "Skill");
                string expectedSkillLevel = ReadData(4, "SkillLevel");
                string expectedAction = ReadData(4, "AddSkillAction");
                ProfilePageObj.AddNewSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to add empty text for Skill")]
        public void AddSkillEmptyText()
        {

            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedSkill = ReadData(5, "Skill");
                string expectedSkillLevel = ReadData(5, "SkillLevel");
                string expectedAction = ReadData(5, "AddSkillAction");
                ProfilePageObj.AddNewSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateAddSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to update an existing Skill with valid data--> Updated Skill")]
        public void EditSkillWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                string expectedSkill = ReadData(10, "Skill");
                string expectedSkillLevel = ReadData(10, "SkillLevel");
                string expectedAction = ReadData(10, "AddSkillAction");
                ProfilePageObj.EditSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                ProfileValidation.ValidateEditSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Check if user is able to delete an existing Skill --> First Row in the list")]

        public void DeleteExistingSkill()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                // Add new Skill   
                ProfilePage ProfilePageObj = new ProfilePage();
                ProfilePageObj.DeleteSkill();

                // Validation
                string message = ProfilePageObj.GetNotificationMessage();
                if (message.Contains("has been deleted from your Skills"))
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
