using MarsFramework.Global;
using MarsFramework.Pages.ProfilePages;
using NUnit.Framework;
using System.Reflection;

namespace MarsFramework.Tests.ProfilePageTests
{
    public class Profile_FullNameTest : Base
    {
        [Test(Description = "Check if user is able to update name using valid Inputs")]
        public void EditProfileFullName()
        {
            //Create Extent Report
            test = extent.CreateTest(MethodBase.GetCurrentMethod()!.Name);

            // Edit Profile Full Name     
            ProfileFullName fullNameobj = new ProfileFullName();
            fullNameobj.EditFullName();
        }

    }
}
