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

namespace MarsFramework.Tests
{
    public class ProfileValidation
    {
        private static Boolean success = false;
        private static string successMessage="";
        
        public static Boolean ValidateAddLanguageResult(string message, string expectedLanguage)
        {
            if ((message == (expectedLanguage + " has been added to your languages")) ||            
            (message == "List is full. Only 4 languages are required.") ||
            (message == "This language is already exist in your language list.") ||
            (message == "Duplicated data") ||
            (message == "This language is already added to your language list.") ||
            (message == "Please enter language and level"))
            {
                success = true;   
                successMessage = message;
            }                        
                return success;            
        }
        public static string GetSuccessMessage()
        {
            return successMessage;
        }






    }
}
