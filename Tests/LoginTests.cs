
using NUnit.Framework;
using OrangeHRMTests.Pages;

namespace OrangeHRMTests.Tests {
    public class LoginTests : BaseTest {
        [Test]
        public void Login_ShouldSucceed() {
            var loginPage = new LoginPage(driver);
            loginPage.Login("Admin", "admin123");

            Assert.That(driver.Url, Does.Contain("dashboard"));
        }
    }
}
