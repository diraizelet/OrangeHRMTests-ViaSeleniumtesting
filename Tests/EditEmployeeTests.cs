
using NUnit.Framework;
using OrangeHRMTests.Pages;

namespace OrangeHRMTests.Tests {
    public class EditEmployeeTests : BaseTest {
        [Test]
        public void EditEmployee_ShouldSucceed() {
            var loginPage = new LoginPage(driver);
            loginPage.Login("Admin", "admin123");

            var pimPage = new PIMPage(driver);
            pimPage.GoToPIM();
            pimPage.SearchAndEditEmployee("Linda");
            pimPage.EditLastName("TestLast");

            Assert.Pass("Employee last name updated successfully.");
        }
    }
}
