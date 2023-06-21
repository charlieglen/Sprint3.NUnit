﻿using OpenQA.Selenium;
using static MarsFramework.Global.GlobalDefinitions;
using MarsFramework.Global;

namespace MarsFramework.Pages
{
    public class ManageRequestsPage : Base
    {
        IWebElement manageRequestsDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
        IWebElement receivedRequestPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
        IWebElement sentRequestPage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[2]"));
        IWebElement showRequestDetails => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[last()]/td[1]"));
        IWebElement starRating => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[last()]/td[3]/div/i[5]"));
        IWebElement acceptRequest => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]"));
        IWebElement declineRequest => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]"));
        IWebElement withdrawRequest => driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button"));
        IWebElement getStatus => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        IWebElement serviceTitle => driver.FindElement(By.XPath("//*[@class=\"skill-title\"]"));
        IWebElement requestTitle => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[2]"));
        IWebElement serviceDetail => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));
        IWebElement senderProfile => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[4]"));
        IWebElement sortByCategory => driver.FindElement(By.XPath("//*[@class=\"two wide\" and contains(text(), \"Category\")]"));
        IWebElement sortByTitle => driver.FindElement(By.XPath("//*[@class=\"three wide\" and contains(text(), \"Title\")]"));
        IWebElement sortByMessage => driver.FindElement(By.XPath("//*[@class=\"four wide\" and contains(text(), \"Message\")]"));
        IWebElement sortBySender => driver.FindElement(By.XPath("//*[@class=\"one wide\" and contains(text(), \"Sender\")]"));
        IWebElement sortByRecepient => driver.FindElement(By.XPath("//*[@class=\"two wide\" and contains(text(), \"Recipient\")]"));
        IWebElement sortByStatus => driver.FindElement(By.XPath("//*[@class=\"two wide\" and contains(text(), \"Status\")]"));
        IWebElement sortByType => driver.FindElement(By.XPath("//*[@class=\"one wide\" and contains(text(), \"Type\")]"));
        IWebElement sortByDate => driver.FindElement(By.XPath("//*/div[2]/div[1]/table/thead/tr/th[7]"));
        IWebElement viewRequestedTitle => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));
        IWebElement senderDetails => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[4]"));
        IWebElement senderURL => driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[4]/a"));


        List<IWebElement> categoryList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[1]")));
        List<IWebElement> titleList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[2]")));
        List<IWebElement> messageList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[3]")));
        List<IWebElement> senderList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[4]")));
        List<IWebElement> statusList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[5]")));
        List<IWebElement> typeList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[6]")));
        List<IWebElement> dateList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[7]")));
        List<IWebElement> recepientList => new List<IWebElement>(driver.FindElements(By.XPath("//*/div[2]/div[1]/table/tbody/tr/td[4]")));


        public void ReceivedRequestsPage()
        {
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]", 5);
            manageRequestsDropdown.Click();
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]", 5);
            receivedRequestPage.Click();
        }

        public void SentRequestsPage()
        {
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]", 5);
            manageRequestsDropdown.Click();
            Wait.WaitToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[2]", 5);
            sentRequestPage.Click();
        }
        public void WithdrawRequest()
        {
            withdrawRequest.Click();
        }

        public void RequestDetailAndRating()
        {
            showRequestDetails.Click();
            starRating.Click();
            showRequestDetails.Click();
        }

        public void AcceptRequest()
        {
            Wait.WaitToBeVisible("XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]", 5);
            acceptRequest.Click();
        }

        public void DeclineRequest()
        {
            Wait.WaitToBeVisible("XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]", 5);
            declineRequest.Click();
        }

        public string GetStatus()
        {
            Wait.WaitToBeVisible("XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[5]", 5);
            return getStatus.Text;
        }

        public string RequestsTitle()
        {
            Wait.WaitToBeClickable("XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[2]", 5);
            return requestTitle.Text;
        }

        public void ViewServiceDetail()
        {
            Wait.WaitToBeClickable("XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[2]/a", 5);
            serviceDetail.Click();
        }

        public string ServiceDetailTitle()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"skill-title\"]", 5);
            return serviceTitle.Text;
        }


        public void ViewSenderProfile()
        {
            senderProfile.Click();
        }

        public string GetSenderURL()
        {
            Wait.WaitToBeClickable("XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[4]/a", 5);
            string urlSender = (senderURL.GetAttribute("href")).Substring(21);
            return urlSender;

        }
        public string GetPageURL()
        {
            string currentURL = driver.Url;
            string senderID = currentURL.Substring(21);
            return senderID;

        }
        // Sort by Category
        public void SortByCategory()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"two wide\" and contains(text(), \"Category\")]", 5);
            sortByCategory.Click();
        }

        public List<String> BeforeSortingCategory()
        {
            Wait.WaitToBeClickable("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[1]", 5);
            List<String> actualCategoryList = new List<string>();

            foreach (IWebElement categoryItem in categoryList)
            {
                actualCategoryList.Add(categoryItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualCategoryList));
            return actualCategoryList;
        }

        public List<String> AfterSortingCategory()
        {
            List<String> sortedCategoryList = new List<string>();

            foreach (IWebElement categoryItem in categoryList)
            {

                sortedCategoryList.Add(categoryItem.Text);
                sortedCategoryList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedCategoryList));
            return sortedCategoryList;
        }

        // Sort by Title
        public void SortByTitle()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"three wide\" and contains(text(), \"Title\")]", 5);
            sortByTitle.Click();
        }

        public List<String> BeforeSortingTitle()
        {
            Wait.WaitToBeVisible("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[2]", 5);
            List<String> actualTitleList = new List<string>();

            foreach (IWebElement titleItem in titleList)
            {
                actualTitleList.Add(titleItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualTitleList));
            return actualTitleList;
        }

        public List<String> AfterSortingTitle()
        {
            List<String> sortedTitleList = new List<string>();

            foreach (IWebElement titleItem in titleList)
            {
                sortedTitleList.Add(titleItem.Text);
                sortedTitleList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedTitleList));
            return sortedTitleList;
        }

        // Sort by Message
        public void SortByMessage()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"four wide\" and contains(text(), \"Message\")]", 5);
            sortByMessage.Click();
        }

        public List<String> BeforeSortingMessage()
        {
            Wait.WaitToBeVisible("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[3]", 5);
            List<String> actualMessageList = new List<string>();

            foreach (IWebElement messageItem in messageList)
            {
                actualMessageList.Add(messageItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualMessageList));
            return actualMessageList;
        }
        public List<String> AfterSortingMessage()
        {
            List<String> sortedMessageList = new List<string>();

            foreach (IWebElement messageItem in messageList)
            {
                sortedMessageList.Add(messageItem.Text);
                sortedMessageList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedMessageList));
            return sortedMessageList;
        }

        // Sort by Sender
        public void SortBySender()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"one wide\" and contains(text(), \"Sender\")]", 5);
            sortBySender.Click();
        }

        public List<String> BeforeSortingSender()
        {
            Wait.WaitToBeVisible("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[4]", 5);
            List<String> actualSenderList = new List<string>();

            foreach (IWebElement senderItem in senderList)
            {
                actualSenderList.Add(senderItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualSenderList));
            return actualSenderList;
        }

        public List<String> AfterSortingSender()
        {
            List<String> sortedSenderList = new List<string>();

            foreach (IWebElement senderItem in senderList)
            {
                sortedSenderList.Add(senderItem.Text);
                sortedSenderList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedSenderList));
            return sortedSenderList;
        }

        // Sort by Recepient
        public void SortByRecepient()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"two wide\" and contains(text(), \"Recipient\")]", 5);
            sortByRecepient.Click();
        }

        public List<String> BeforeSortingRecepient()
        {
            Wait.WaitToBeClickable("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[4]", 5);
            List<String> actualRecepientList = new List<string>();

            foreach (IWebElement senderItem in recepientList)
            {
                actualRecepientList.Add(senderItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualRecepientList));
            return actualRecepientList;
        }

        public List<String> AfterSortingRecepient()
        {
            List<String> sortedRecepientList = new List<string>();

            foreach (IWebElement senderItem in recepientList)
            {
                sortedRecepientList.Add(senderItem.Text);
                sortedRecepientList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedRecepientList));
            return sortedRecepientList;
        }

        // Sort by Status
        public void SortByStatus()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"two wide\" and contains(text(), \"Status\")]", 5);
            sortByStatus.Click();
        }

        public List<String> BeforeSortingStatus()
        {
            Wait.WaitToBeClickable("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[5]", 5);
            List<String> actualStatusList = new List<string>();

            foreach (IWebElement statusItem in statusList)
            {
                actualStatusList.Add(statusItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualStatusList));
            return actualStatusList;
        }

        public List<String> AfterSortingStatus()
        {
            List<String> sortedStatusList = new List<string>();
            //{
            //    "Pending" , "Accepted", "Declined", "Completed"
            //};

            foreach (IWebElement statusItem in statusList)
            {
                //sortedStatusList.Add(statusItem.Text);
                sortedStatusList.Sort();
                //sortedStatusList.Reverse();
                //sortedStatusList.Add(statusItem.Text);
                //orderedlist = sortedStatusList.OrderBy("Pending", "Accepted", "Declined", "Completed").ToList();
                //sortedStatusList = sortedStatusList.OrderBy(x => x, new ReversedComparer()).ToList();
            }

            Console.WriteLine(string.Join(" | ", sortedStatusList));
            return sortedStatusList;
        }

        // Sort by Type
        public void SortByType()
        {
            Wait.WaitToBeClickable("XPath", "//*[@class=\"one wide\" and contains(text(), \"Type\")]", 5);
            sortByType.Click();
        }

        public List<String> BeforeSortingType()
        {
            Wait.WaitToBeClickable("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[6]", 5);
            List<String> actualTypeList = new List<string>();

            foreach (IWebElement typeItem in typeList)
            {
                actualTypeList.Add(typeItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualTypeList));
            return actualTypeList;
        }

        public List<String> AfterSortingType()
        {
            List<String> sortedTypeList = new List<string>();

            foreach (IWebElement typeItem in typeList)
            {
                sortedTypeList.Add(typeItem.Text);
                sortedTypeList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedTypeList));
            return sortedTypeList;
        }


        // Sort by Date
        public void SortByDate()
        {
            Wait.WaitToBeClickable("XPath", "//*/div[2]/div[1]/table/thead/tr/th[7]", 5);
            sortByDate.Click();
        }

        public List<String> BeforeSortingDate()
        {
            Wait.WaitToBeClickable("XPath", "//*/div[2]/div[1]/table/tbody/tr/td[7]", 5);
            List<String> actualDateList = new List<string>();

            foreach (IWebElement dateItem in dateList)
            {
                actualDateList.Add(dateItem.Text);
            }
            Console.WriteLine(string.Join(" | ", actualDateList));
            return actualDateList;
        }

        public List<String> AfterSortingDate()
        {
            List<String> sortedDateList = new List<string>();

            foreach (IWebElement dateItem in dateList)
            {
                sortedDateList.Add(dateItem.Text);
                sortedDateList.Sort();
            }
            Console.WriteLine(string.Join(" | ", sortedDateList));
            return sortedDateList;
        }


        public void ViewRequestedTitle()
        {
            viewRequestedTitle.Click();
        }

        public void ViewRequesterDetails()
        {
            senderDetails.Click();

        }








        //IWebElement nextPageIcon = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/div/button[4]"));
        //IWebElement previousPageIcon = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/div/button[1]"));
        //IWebElement lastRequest = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[last()]/td[1]"));


        /* Create dummy accounts
         * test in multiple browsers
         * check how to verify sorting
         * assert using a different browser or account
         */



    }
}
