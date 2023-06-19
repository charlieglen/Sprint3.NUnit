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
    public class Profile_FullNameTest : Base
    {
        [Test(Description = "Check if user is able to update name using valid Inputs")]
        public void EditProfileFullName()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);
                        
            // Edit Profile Full Name     
            ProfilePage Profileobj = new ProfilePage();
            Profileobj.EditFullName();
        }

    }
}
