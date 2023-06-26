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
            // must display all the registered skills. If All Categories = 0 and skills are showing in the results, it means it's showing all the registered skills for trade
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 3;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                int expectedNumberOfResults = searchSkillPageObj.GetExpectedNumberOfResults();
                int actualNumberOfResults = searchSkillPageObj.GetActualNumberOfResults();
                Console.WriteLine("The number of refinable result is: " + expectedNumberOfResults);
                Console.WriteLine("The total number of registered skills for trade is: " + actualNumberOfResults);
                Assert.That(expectedNumberOfResults == 0 && actualNumberOfResults != 0);
                test.Log(Status.Pass, "Passed, action successfull. No refinable results and all skills are displayed.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(2)]
        public void SearchSkillWithSpace()
        {   
            // must display all the registered skills. If All Categories = 0 and skills are showing in the results, it means it's showing all the registered skills for trade
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 4;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                int expectedNumberOfResults = searchSkillPageObj.GetExpectedNumberOfResults();
                int actualNumberOfResults = searchSkillPageObj.GetActualNumberOfResults();
                Console.WriteLine("The number of refinable result is: " + expectedNumberOfResults);
                Console.WriteLine("The total number of registered skills for trade is: " + actualNumberOfResults);
                Assert.That(expectedNumberOfResults == 0 && actualNumberOfResults != 0);
                test.Log(Status.Pass, "Passed, action successfull. No refinable results and all skills are displayed.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }

        [Test, Order(3)]
        public void SearchBlankSkillFromResult()
        {
            // no changes in the result pages
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 4;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                int actualNumberOfResults = searchSkillPageObj.GetActualNumberOfResults();
                int expectedNumberOfResults = searchSkillPageObj.GetExpectedNumberOfResults();
                Console.WriteLine("The expected number of results is: " + expectedNumberOfResults);
                Console.WriteLine("The actual number of results is: " + actualNumberOfResults);
                Assert.That(expectedNumberOfResults == actualNumberOfResults);
                test.Log(Status.Pass, "Passed, action successfull. No changes in the search results displayed.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(4)]
        public void SearchBlankUserFromResult()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 5;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                string resultPanelIsVisible = searchSkillPageObj.LocateSearchUserResultPanel();
                Console.WriteLine("Class name " + resultPanelIsVisible+" is visible which means no results to show.");
                Assert.That(resultPanelIsVisible == "results transition");
                test.Log(Status.Pass, "Passed, action successfull. No search results to show.");

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
                testRow = 7;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                string searchNotice = searchSkillPageObj.GetNotWorkingNotice();
                Console.WriteLine(searchNotice);
                Assert.That(searchNotice == "This page isn’t working");

                test.Log(Status.Pass, "Passed, action successfull. Search keyword exceeds the number of characters allowed - 8152.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
    }
}
