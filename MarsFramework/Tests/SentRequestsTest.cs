using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System.Reflection;

namespace MarsFramework.Tests
{
    [TestFixture]
    public class SentRequestsTest : Base
    {
        [Test, Order(1)]
        public void ViewRateAndAcceptRequest()
        {

            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            try
            {

                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                //manageRequestsObj.RequestDetailAndRating();
                //manageRequestsObj.AcceptRequest();
                string status = manageRequestsObj.GetStatus();
                Assert.That(status == "Accepted");
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(2)]
        public void WithdrawRequest()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                manageRequestsObj.WithdrawRequest();
                string status = manageRequestsObj.GetStatus();
                Assert.That(status == "Withdrawn");
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test, Order(3)]
        public void SortByCategory()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualCategory = manageRequestsObj.BeforeSortingCategory();
                manageRequestsObj.SortByCategory();
                List<String> afterCategory = manageRequestsObj.AfterSortingCategory();
                Assert.AreNotEqual(actualCategory, afterCategory);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(4)]
        public void SortByTitle()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualTitle = manageRequestsObj.BeforeSortingTitle();
                manageRequestsObj.SortByTitle();
                List<String> afterTitle = manageRequestsObj.AfterSortingTitle();
                Assert.AreNotEqual(actualTitle, afterTitle);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }

        [Test, Order(5)]
        public void SortByMessage()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualMessage = manageRequestsObj.BeforeSortingMessage();
                manageRequestsObj.SortByMessage();
                List<String> afterMessage = manageRequestsObj.AfterSortingMessage();
                Assert.AreNotEqual(actualMessage, afterMessage);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(6)]
        public void SortByRecepient()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualRecepient = manageRequestsObj.BeforeSortingRecepient();
                manageRequestsObj.SortByRecepient();
                List<String> afterRecepient = manageRequestsObj.AfterSortingRecepient();
                Assert.AreNotEqual(actualRecepient, afterRecepient);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(7)]
        public void SortByStatus()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualStatus = manageRequestsObj.BeforeSortingStatus();
                manageRequestsObj.SortByStatus();
                List<String> afterStatus = manageRequestsObj.AfterSortingStatus();
                Assert.AreNotEqual(actualStatus, afterStatus);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(7)]
        public void SortByType()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualType = manageRequestsObj.BeforeSortingType();
                manageRequestsObj.SortByType();
                List<String> afterType = manageRequestsObj.AfterSortingType();
                Assert.AreNotEqual(actualType, afterType);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(8)]
        public void SortByDate()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.SentRequestsPage();
                List<String> actualDate = manageRequestsObj.BeforeSortingDate();
                manageRequestsObj.SortByDate();
                List<String> afterDate = manageRequestsObj.AfterSortingDate();
                Assert.AreNotEqual(actualDate, afterDate);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, action unsuccessfull. Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }

    }
}