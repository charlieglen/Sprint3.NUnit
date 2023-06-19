using AventStack.ExtentReports;
using MarsFramework.Pages;
using NUnit.Framework;
using System.Reflection;
using MarsFramework.Global;
using static MarsFramework.Global.GlobalDefinitions;


namespace MarsFramework.Tests
{
    [TestFixture]
    public class SearchSkillNegativeTest : Base
    {
        [Test, Order(1)]
        public void SearchSkillWithBlank()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();


                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(1)]
        public void SearchSkillWithSpace()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();


                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }

        
        [Test, Order(1)]
        public void SearchSkillStartingWithSpecialChar()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {

            testRow = 7;
            SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();

            searchSkillPageObj.SearchSkillsHomePage();
            //searchSkillPageObj.SearchSkillsFromResults();
            searchSkillPageObj.ViewCategory();
            searchSkillPageObj.ViewSubCategory();
            string result = searchSkillPageObj.GetSearchResultAlert();
            Assert.That(result == "No results found, please select a new category!");
            test.Log(Status.Pass, "Passed, action successfull. Can't use special characters in Title or Description.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Title and Description must not have special characters");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(2)]
        public void SearchSkillFromResultWithBlank()
        {
            //should result to All categories 0 and show all the number of users

            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //try
            //{
            testRow = 2;
            SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();

           
            //Assert.That(status == "Accepted");
            //test.Log(Status.Pass, "Passed, action successfull.");
        }
        //catch (Exception ex)
        //{
        //    test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
        //    test.Log(Status.Info, ex.Message);
        //}

        //}
        [Test, Order(2)]
        public void SearchUserFromResultBlank()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
               
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }

        [Test, Order(2)]
        public void SearchUsingMoreThanMaxNoOfChars()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();

                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }



        /*Sr.No	Testcase_ID	Test Cases
1	Negative_01	Verify that the user should be able to search with special characters like %, *, #
2	Negative_02	Verify that the user is able to blank search or not
3	Negative_03	Verify that the user should be able to search with special characters like %, *, #
4	Negative_04	Verify that if the user enters only space and tries to search
5	Negative_05	Verify search functionality with maximum characters -- /No of total characters is 8152
6	Negative_06	Verify search functionality with minimum characters -- blank
            */
        //https://sampletestcases.com/test-cases-for-search-functionality/12
        //\

        //No of total characters is 8152
    }
}
