using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Global;
using System.Reflection;
using AventStack.ExtentReports;

namespace MarsFramework.Tests
{
    [TestFixture]
    public class ReceivedRequestsTest : Base
    {
        [Test, Order(1)]
        public void ViewRequestedService()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                //manageRequestsObj.RequestDetailAndRating();
                string ReceivedRequestTitle = manageRequestsObj.RequestsTitle();
                manageRequestsObj.ViewServiceDetail();
                string ServicePageTitle = manageRequestsObj.ServiceDetailTitle();
                Assert.That(ReceivedRequestTitle == ServicePageTitle);
                Console.WriteLine(ReceivedRequestTitle);
                Console.WriteLine(ServicePageTitle);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(2)]
        public void ViewSenderProfile()
        {

            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                //manageRequestsObj.RequestDetailAndRating();
                //manageRequestsObj.AcceptRequest();
                string senderURL = manageRequestsObj.GetSenderURL();
                manageRequestsObj.ViewSenderProfile();

                //string status = manageRequestsObj.GetStatus();
                //Assert.That(status == "Accepted");
                string currentURL = manageRequestsObj.GetPageURL();
                Console.WriteLine(senderURL);
                Console.WriteLine(currentURL);
                Assert.That(senderURL == currentURL);

                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(3)]
        public void ViewRateAndAcceptRequest()
        {

            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.RequestDetailAndRating();
                manageRequestsObj.AcceptRequest();
                string status = manageRequestsObj.GetStatus();
                Assert.That(status == "Accepted");
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(4)]
        public void DeclineRequest()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                //manageRequestsObj.SortByStatus();
                manageRequestsObj.DeclineRequest();
                string status = manageRequestsObj.GetStatus();
                Assert.That(status == "Declined");
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");

            }
        }

        [Test, Order(5)]
        public void SortByCategory()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualCategory = manageRequestsObj.BeforeSortingCategory();
                manageRequestsObj.SortByCategory();
                List<String> afterCategory = manageRequestsObj.AfterSortingCategory();
                Assert.AreNotEqual(actualCategory, afterCategory);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(6)]
        public void SortByTitle()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualTitle = manageRequestsObj.BeforeSortingTitle();
                manageRequestsObj.SortByTitle();
                List<String> afterTitle = manageRequestsObj.AfterSortingTitle();
                Assert.AreNotEqual(actualTitle, afterTitle);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test, Order(7)]
        public void SortByMessage()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualMessage = manageRequestsObj.BeforeSortingMessage();
                manageRequestsObj.SortByMessage();
                List<String> afterMessage = manageRequestsObj.AfterSortingMessage();
                Assert.AreNotEqual(actualMessage, afterMessage);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(8)]
        public void SortBySender()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualSender = manageRequestsObj.BeforeSortingSender();
                manageRequestsObj.SortBySender();
                List<String> afterSender = manageRequestsObj.AfterSortingSender();
                Assert.AreNotEqual(actualSender, afterSender);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(9)]
        public void SortByStatus()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualStatus = manageRequestsObj.BeforeSortingStatus();
                manageRequestsObj.SortByStatus();
                List<String> afterStatus = manageRequestsObj.AfterSortingStatus();
                Assert.AreNotEqual(actualStatus, afterStatus);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(10)]
        public void SortByType()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualType = manageRequestsObj.BeforeSortingType();
                manageRequestsObj.SortByType();
                List<String> afterType = manageRequestsObj.AfterSortingType();
                Assert.AreNotEqual(actualType, afterType);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }
        [Test, Order(11)]
        public void SortByDate()
        {
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            try
            {
                ManageRequestsPage manageRequestsObj = new ManageRequestsPage();
                manageRequestsObj.ReceivedRequestsPage();
                List<String> actualDate = manageRequestsObj.BeforeSortingDate();
                manageRequestsObj.SortByDate();
                List<String> afterDate = manageRequestsObj.AfterSortingDate();
                Assert.AreNotEqual(actualDate, afterDate);
                test.Log(Status.Pass, "Passed, action successfull.");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Failed, Actual and Expected result did not match");
                test.Log(Status.Info, ex.Message);
            }

        }

    }
}
