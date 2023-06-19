using AventStack.ExtentReports;
using MarsFramework.Pages;
using NUnit.Framework;
using System.Reflection;
using MarsFramework.Global;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Tests
{
    [TestFixture]
    public class SearchSkillTest : Base
    {
        [Test, Order(1)]
        public void SearchSkill()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //try
            //{
            testRow = 2;
            SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();

            searchSkillPageObj.SearchSkillsHomePage();
            //searchSkillPageObj.SearchSkillsFromResults();
            searchSkillPageObj.ViewCategory();
            searchSkillPageObj.ViewSubCategory();
            //searchSkillPageObj.ViewHighestMatchCategory();
            //searchSkillPageObj.ViewHighestMatchSubCategory();


            //int number = searchSkillPageObj.ViewResultsByCategory();
            //Console.WriteLine(number);
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
        public void SearchUserFromResult()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                searchSkillPageObj.ViewCategory();
                searchSkillPageObj.SearchUserFromResult();
                string sellerNameResult = searchSkillPageObj.GetSellerName();
                Assert.IsTrue(string.Equals(sellerNameResult, (ExcelLib.ReadData(testRow, "SearchUser")), StringComparison.OrdinalIgnoreCase));
                Console.WriteLine(sellerNameResult);
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(3)]
        public void SearchSkillFromResult()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                searchSkillPageObj.ViewCategory();
                searchSkillPageObj.SearchSkillsFromResults();
                searchSkillPageObj.OpenSellerDetails();
                bool searchSkillMatch = searchSkillPageObj.GetSkillTitleAndDescription();
                Assert.That(searchSkillMatch == true);
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(4)]
        public void FilterLocationsOnline()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                searchSkillPageObj.ViewCategory();
                searchSkillPageObj.FilterOnline();
                searchSkillPageObj.OpenSellerDetails();
                string locationType = searchSkillPageObj.GetLocationType();
                Console.WriteLine(locationType);
                Assert.That(locationType == "Online");
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(5)]
        public void FilterLocationsOnsite()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                searchSkillPageObj.ViewCategory();
                searchSkillPageObj.FilterOnsite();
                searchSkillPageObj.OpenSellerDetails();
                string locationType = searchSkillPageObj.GetLocationType();
                Console.WriteLine(locationType);
                Assert.That(locationType == "On-Site");
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(6)]
        public void FilterLocationsShowAll()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();
                searchSkillPageObj.SearchSkillsHomePage();
                int actualNumberOfResults = searchSkillPageObj.GetActualNumberOfResults();
                searchSkillPageObj.FilterOnsite();
                searchSkillPageObj.FilterShowAll();
                int expectedNumberOfResults = searchSkillPageObj.GetExpectedNumberOfResults();
                Console.WriteLine("The expected number of results is: " + expectedNumberOfResults);
                Console.WriteLine("The actual number of results is: " + actualNumberOfResults);
                Assert.That(expectedNumberOfResults == actualNumberOfResults);
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        //[Test, Order(7)]
        //public void NumberOfSearchResults()
        //{
        //    test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

        //    testRow = 2;
        //    SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();

        //    searchSkillPageObj.SearchSkillsHomePage();
        //    searchSkillPageObj.ViewCategory();
        //    int resultsNumber = searchSkillPageObj.GetNumberOfResults();
        //    searchSkillPageObj.GetNumberOfResults();
        //    Console.WriteLine(resultsNumber);

        //}
        [Test, Order(8)]
        public void NumberOfResultsPerPage()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {
                test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

                testRow = 2;
                SearchSkillsPage searchSkillPageObj = new SearchSkillsPage();

                searchSkillPageObj.SearchSkillsHomePage();
                searchSkillPageObj.ResultsPerPage();
                int resultsPerPage = searchSkillPageObj.GetNumberOfResultsPerPage();
                Console.WriteLine(resultsPerPage);

                Assert.That(resultsPerPage == 18);
                test.Log(Status.Pass, "Passed, action successfull.");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        // search using numbers
        // searh using special characters -- Should not be successful or 0 results as you can't use special characters in skill title or description
        //search an empty user/skill
        //search an empty char - must result to 0 search results -- can't be refined
        //user try to go to previous page when they are on page 1
        //user try to go to next page when they are on the last page

    }
}
