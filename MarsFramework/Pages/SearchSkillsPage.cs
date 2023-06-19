using OpenQA.Selenium;
using MarsFramework.Global;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    public class SearchSkillsPage : Base
    {
        public SearchSkillsPage()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill");
        }

        IWebElement searchSkillTextArea => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/input"));
        IWebElement searchIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
        IWebElement searchUserTextArea => driver.FindElement(By.XPath("//*[@class=\"ui icon input fluid\"]/input"));
        IWebElement search => driver.FindElement(By.XPath("//span[text()='" + ExcelLib.ReadData(testRow, "SearchUser") + "']"));
        IWebElement getSellerName => driver.FindElement(By.XPath("//*[@class=\"seller-info\"]"));
        IWebElement searchSkillsFromResults => driver.FindElement(By.XPath("//*[@class=\"four wide column\"]/div[2]/input"));
        IWebElement searchIconFromResults => driver.FindElement(By.XPath("//*[@class=\"four wide column\"]/div[2]/i"));
        IWebElement openSellerDetails => driver.FindElement(By.XPath("//*[@class=\"ui stackable three cards\"]/div[1]/a[1]/img[1]"));
        IWebElement skillTitle => driver.FindElement(By.XPath("//*[@class=\"skill-title\"]"));
        IWebElement skillDescription => driver.FindElement(By.XPath("//*[@class=\"sixteen wide column\"]/div[1]/div/div/div[2]"));
        IWebElement searchCategory => driver.FindElement(By.XPath("//*[@class=\"item category\" and contains(text(), '" + ExcelLib.ReadData(testRow, "Category") + "')]"));
        IWebElement searchSubcategory => driver.FindElement(By.XPath("//*[@class=\"item subcategory\" and contains(text(), '" + ExcelLib.ReadData(testRow, "SubCategory") + "' )]"));

        IWebElement filterOnline => driver.FindElement(By.XPath("//*[@class=\"ui button\" and contains(text(), \"Online\")]"));
        IWebElement filterOnsite => driver.FindElement(By.XPath("//*[@class=\"ui button\" and contains(text(), \"Onsite\")]"));
        IWebElement filterShowAll => driver.FindElement(By.XPath("//*[@class=\"ui button\" and contains(text(), \"ShowAll\")]"));
        IWebElement getLocationType => driver.FindElement(By.XPath("//*[@class=\"ui grid\"]/div[3]/div[1]/div[3]/div/div[2]"));
        IWebElement resultsPerPage18 => driver.FindElement(By.XPath("//*[@class=\"right floated column \"]/button[3]"));
        IWebElement searchResults => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[1]/span"));
        IWebElement SecondTolastPage => driver.FindElement(By.XPath("//*[@class=\"ui buttons semantic-ui-react-button-pagination\"]/button[last()-2]"));
        IWebElement lastPage => driver.FindElement(By.XPath("//*[@class=\"ui buttons semantic-ui-react-button-pagination\"]/button[last()-1]"));

        List<IWebElement> resultsAsAString => new List<IWebElement>(driver.FindElements(By.XPath("//*[@class='item category']/*[@class='right-floated']")));
        List<IWebElement> resultsAsAStringSubcategory => new List<IWebElement>(driver.FindElements(By.XPath("//*[@class='item subcategory']/*[@class='right-floated']")));
        List<IWebElement> numberOfResults => new List<IWebElement>(driver.FindElements(By.XPath("//*[@class=\"seller-info\"]")));
        List<IWebElement> numberOfResultsLastPage => new List<IWebElement>(driver.FindElements(By.XPath("//*[@class=\"seller-info\"]")));
        List<IWebElement> numberOfResultsPerPage => new List<IWebElement>(driver.FindElements(By.XPath("//*[@class=\"seller-info\"]")));


        public void SearchSkillsHomePage()
        {
            searchSkillTextArea.SendKeys(ExcelLib.ReadData(testRow, "SearchSkill"));
            searchIcon.Click();

        }

        public void SearchUserFromResult()
        {
            searchUserTextArea.SendKeys(ExcelLib.ReadData(testRow, "SearchUser"));
            Wait.WaitToBeClickable(driver, "XPath", "//span[text()='" + ExcelLib.ReadData(testRow, "SearchUser") + "']", 5);
            search.Click();
        }

        public string GetSellerName()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class=\"seller-info\"]", 5);
            return getSellerName.Text;
        }

        public void SearchSkillsFromResults()
        {
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@class=\"four wide column\"]/div[2]/input", 5);
            Thread.Sleep(2000);
            searchSkillsFromResults.SendKeys(ExcelLib.ReadData(testRow, "SearchBySkill"));
            searchIconFromResults.Click();
        }

        public void OpenSellerDetails()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class=\"ui stackable three cards\"]/div[1]/a[1]/img[1]", 5);
            openSellerDetails.Click();
        }
        public bool GetSkillTitleAndDescription()
        {

            if (skillTitle.Text.Contains(ExcelLib.ReadData(testRow, "SearchBySkill"), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(skillTitle.Text);
                if (skillDescription.Text.Contains(ExcelLib.ReadData(testRow, "SearchBySkill"), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(skillDescription.Text);
                    return true;
                }
            }
            return false;
        }

        public void ViewCategory()
        {
            searchCategory.Click();
        }

        public void ViewSubCategory()
        {
            Thread.Sleep(1000);
            searchSubcategory.Click();
        }

        public void ViewHighestMatchCategory()
        {
            Thread.Sleep(1000);
            List<int> resultNumbers = new List<int>();

            foreach (IWebElement result in resultsAsAString)
            {
                int number;
                if (int.TryParse(result.Text, out number))
                {
                    resultNumbers.Add(number);
                }
            }
            // if resultNumbers.Count is true, execute resultNumbers.Max else return 0.
            int highestValue = resultNumbers.Count > 0 ? resultNumbers.Max() : 0;
            Console.WriteLine(string.Join(" | ", highestValue));
            IWebElement highestResult = driver.FindElement(By.XPath("//*[@class=\"right-floated\" and contains(text(), " + highestValue + ")]"));
            highestResult.Click();

        }

        public void ViewHighestMatchSubCategory()
        {
            Thread.Sleep(1000);
            List<int> resultNumbers = new List<int>();

            foreach (IWebElement result in resultsAsAStringSubcategory)
            {
                int number;
                if (int.TryParse(result.Text, out number))
                {
                    resultNumbers.Add(number);
                }
            }
            // if resultNumbers.Count is true, execute resultNumbers.Max else return 0.
            int highestValueSubCategory = resultNumbers.Count > 0 ? resultNumbers.Max() : 0;
            IWebElement highestResultSubcategory = driver.FindElement(By.XPath("//*[@class='item subcategory']/*[@class='right-floated' and contains(text(), " + highestValueSubCategory + ")]"));

            Console.WriteLine(string.Join(" | ", highestValueSubCategory));
            highestResultSubcategory.Click();
        }

        //Filter
        public void FilterOnline()
        {
            filterOnline.Click();
        }

        public void FilterOnsite()
        {
            filterOnsite.Click();
        }

        public void FilterShowAll()
        {
            filterShowAll.Click();
        }

        public string GetLocationType()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class=\"ui grid\"]/div[3]/div[1]/div[3]/div/div[2]", 5);
            return getLocationType.Text;
        }

        public void ResultsPerPage()
        {
            resultsPerPage18.Click();
        }
        // verify total number of results
        public int GetActualNumberOfResults()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class=\"ui buttons semantic-ui-react-button-pagination\"]/button[last()-2]", 5);
            int SecondTolastPageNumber;
            int.TryParse(SecondTolastPage.Text, out SecondTolastPageNumber);
            Console.WriteLine("Number of Pages with max number of displayed results: " + SecondTolastPageNumber);

            int totalCount = 0;
            for (int page = 1; page <= SecondTolastPageNumber; page++)
            {
                //totalcount = totalcount + numberofresults
                totalCount += numberOfResults.Count;
            }

            lastPage.Click();
            Task.Delay(1000).Wait();
            Console.WriteLine(numberOfResultsLastPage.Count);
            return totalCount + numberOfResultsLastPage.Count;

        }

        public int GetExpectedNumberOfResults()
        {
            //Thread.Sleep(1000);
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[1]/span", 5);
            int searchResultInt;
            int.TryParse(searchResults.Text, out searchResultInt);
            Console.WriteLine(searchResultInt);
            return searchResultInt;
        }

        public int GetNumberOfResultsPerPage()
        {
            //Wait.WaitToBeVisible(driver, "XPath", "//*[@class='seller-info']", 5);
            Thread.Sleep(1500);
            return numberOfResultsPerPage.Count;

        }

        public string GetSearchResultAlert()
        {
            IWebElement searchResultAlert = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/h3"));
            return searchResultAlert.Text;
        }

    }
}
