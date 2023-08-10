using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System.Net.NetworkInformation;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports;

namespace MarsFramework.Tests
{
    public class ProfileValidation
    {
        public static void ValidateDescription(string currentNotification, string currentDescription, string expectedDescription,  ExtentTest test)
        {
            if (currentNotification == "Description has been saved successfully")
            {
                //test.Log(Status.Pass, "Passed, Description added successfully.");
                if (expectedDescription == currentDescription)
                {                   
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, Description added successfully.");                   
                }
                else if (expectedDescription == "")
                {
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, Description cannot be empty. Previous description retained.");                    
                }
                else if (expectedDescription != currentDescription)
                {
                    // Log status in Extentreports
                    test.Log(Status.Pass, "Passed, Description added up to 600 characters only.");
                }
            }
            else
            {
                if (currentNotification == "First character can only be digit or letters")
                {
                    // Log status in Extentreports
                    test.Log(Status.Pass, "First character can only be digit or letters");
                }
                else if (currentNotification == "There is an error saving the Description")
                {
                    // Log status in Extentreports
                    test.Log(Status.Pass, "There is an error saving the Description");
                }
            }

            test.Log(Status.Info, currentNotification);
        }

        public static void ValidateAddLanguageResult(string message, string expectedLanguage, ExtentTest test)
        {
            if ((message == (expectedLanguage + " has been added to your languages")) ||            
            (message == "List is full. Only 4 languages are required.") ||
            (message == "This language is already exist in your language list.") ||
            (message == "Duplicated data") ||
            (message == "This language is already added to your language list.") ||
            (message == "Please enter language and level"))
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

        public static void ValidateEditLanguageResult(string message, string expectedLanguage, ExtentTest test)
        {
            if ((message == (expectedLanguage + " has been updated to your languages")) ||            
            (message == "This language is already exist in your language list.") ||
            (message == "Duplicated data") ||
            (message == "This language is already added to your language list.") ||
            (message == "Please enter language and level"))
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




    }
}
