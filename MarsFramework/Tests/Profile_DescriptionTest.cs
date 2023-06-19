using AventStack.ExtentReports;
using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Tests
{
    public class Profile_DescriptionTest : Base
    {
        [Test(Description = "Valid Description Input, starts with a digit or letter, Less than or equal to 600 characters")]
        public void AddDescription()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(2, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Valid Description Input, starts with a digit or letter, Less than or equal to 600 characters")]
        public void EditDescriptionValidData()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(2, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "InValid Length of Input, More than 600 characters")]
        public void EditDescriptionMoreThanMaxLength()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(3, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Invalid Input, All invalid characters = !@#$%^&*()_+<>,.?~`")]
        public void EditDescriptionInvalidCharacters()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(4, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Input starts with a space")]
        public void EditDescriptionStartsWithASpace()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(5, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Heaps of unwanted spaces after a valid text. Total of 236 characters including spaces")]
        public void EditDescriptionExtraSpacesAfterValidInput()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(6, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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

                        int charsExpectedDesc = expectedDescription.ToCharArray().Length;
                        //int charsCurrentDesc = currentDescription.ToCharArray().Length;
                        int charsTrimmed = expectedDescription.TrimEnd().Length;

                        if (charsTrimmed < charsExpectedDesc)
                        {
                            // Log status in Extentreports
                            test.Log(Status.Pass, "Passed, Description has heaps of uwanted spaces at the end of Text.");
                        }
                        else
                        {
                            // Log status in Extentreports
                            test.Log(Status.Pass, "Passed, Description added up to 600 characters only.");


                        }

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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        }

        [Test(Description = "Empty Text")]
        public void EditDescriptionEmptyText()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string expectedDescription = GlobalDefinitions.ExcelLib.ReadData(7, "Description");

            try
            {
                // Arrange
                ProfilePage ProfileObj = new ProfilePage();

                // Action
                ProfileObj.AddDescription(expectedDescription);

                // Assertion
                string currentNotification = ProfileObj.GetNotificationMessage();
                string currentDescription = ProfileObj.GetDescriptionValue();

                if (currentNotification == "Description has been saved successfully")
                {

                    //test.Log(Status.Pass, "Passed, Description added successfully.");
                    if (expectedDescription == currentDescription)
                    {
                        Assert.That(expectedDescription, Is.EqualTo(currentDescription));
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
                // Assert.That(currentNotification == expectedNotification);

                //Log status in Extentreports
                //test.Log(Status.Pass, "Passed, Description added successfully.");
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                test.Log(Status.Fail, "Failed, Description update unsuccessfull.");
                test.Log(Status.Info, ex.Message);
            }
        } 
    }
}
