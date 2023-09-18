using MarsFramework.Global;
using OpenQA.Selenium;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{

    public class LoginPage : Base
    {
        public LoginPage()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "LogIn");
        }

        
        IWebElement signinButton => driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        //IWebElement signinButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        IWebElement emailTextbox => driver.FindElement(By.Name("email"));
        IWebElement passwordTextbox => driver.FindElement(By.Name("password"));
        IWebElement rememberMeCheckbox => driver.FindElement(By.Name("rememberDetails"));
        IWebElement loginButton => driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));

        public void LogInActions()
        {
            //Thread.Sleep(100);
            Wait.WaitToBeVisible(driver,"XPath", "//A[@class='item'][text()='Sign In']", 30);
            signinButton.Click();
            emailTextbox.SendKeys(ExcelLib.ReadData(4, "UserEmail"));
            passwordTextbox.SendKeys(ExcelLib.ReadData(4, "Password"));
            rememberMeCheckbox.Click();
            loginButton.Click();
            
        }
    }
}

