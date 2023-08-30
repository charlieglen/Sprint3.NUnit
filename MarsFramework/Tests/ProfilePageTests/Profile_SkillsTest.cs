using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;
using static MarsFramework.Global.GlobalDefinitions.ExcelLib;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_SkillsTest : Base
    {
        [Test(Description = "Check if user is able to add new Skill with valid data--> Automation Testing")]
        public void AddNewSkillWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Skill Input
            SetUpAndValidateAddSkillInput(2);
        }


        [Test(Description = "Check if user is able to add duplicate Skill--> Automation Testing")]
        public void AddDuplicateSkill()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Skill Input
            SetUpAndValidateAddSkillInput(2);
        }

        [Test(Description = "Check if user is able to add Skill all in special characters--> ~`!@#$%^&*()_+-={}|[]\\:\";'<>?,./ ")]
        public void AddSkillInSpecialCharacters()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Skill Input
            SetUpAndValidateAddSkillInput(3);
        }

        [Test(Description = "Check if user is able to add Skill with no Skill level selected")]
        public void AddSkillWithOutLevel()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Skill Input
            SetUpAndValidateAddSkillInput(4);
        }

        [Test(Description = "Check if user is able to add empty text for Skill")]
        public void AddSkillEmptyText()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Skill Input
            SetUpAndValidateAddSkillInput(5);
        }

        [Test(Description = "Check if user is able to update an existing Skill with valid data--> Updated Skill")]
        public void EditSkillWithValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Edit Skill 
            SetUpAndValidateEditSkill(10);
        }

        [Test(Description = "Check if user is able to delete an existing Skill --> First Row in the list")]

        public void DeleteExistingSkill()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Set up and validate Delete Skill 
            SetAndValidateDeleteExistingSkill();
        }

        private static void SetAndValidateDeleteExistingSkill()
        {
            try
            {
                // Delete an existing Skill   
                ProfileSkills skillsObj = new ProfileSkills();
                skillsObj.DeleteSkill();

                // Validation
                string message = skillsObj.GetNotificationMessage();
                skillsObj.ValidateDeleteSkillResult(message, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndValidateAddSkillInput(int rowNumber)
        {
            try
            {
                // Add new Skill   
                ProfileSkills skillsObj = new ProfileSkills();
                string expectedSkill = ReadData(rowNumber, "Skill");
                string expectedSkillLevel = ReadData(rowNumber, "SkillLevel");
                string expectedAction = ReadData(rowNumber, "AddSkillAction");
                skillsObj.AddNewSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = skillsObj.GetNotificationMessage();
                skillsObj.ValidateAddSkillResult(message, expectedSkill, test);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Select action unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        private static void SetUpAndValidateEditSkill(int rowNumber)
        {
            try
            {
                // Update an Existing Skill   
                ProfileSkills skillsObj = new ProfileSkills();
                string expectedSkill = ReadData(rowNumber, "Skill");
                string expectedSkillLevel = ReadData(rowNumber, "SkillLevel");
                string expectedAction = ReadData(rowNumber, "AddSkillAction");
                skillsObj.EditSkill(expectedSkill, expectedSkillLevel, expectedAction);

                // Validation
                string message = skillsObj.GetNotificationMessage();
                skillsObj.ValidateEditSkillResult(message, expectedSkill, test);
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
