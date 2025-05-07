
using OpenQA.Selenium;

namespace OrangeHRMTests.Pages {
    public class LoginPage {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver) => this.driver = driver;

        private IWebElement Username => driver.FindElement(By.Name("username"));
        private IWebElement Password => driver.FindElement(By.Name("password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("button[type='submit']"));

        public void Login(string username, string password) {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}
