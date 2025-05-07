
using OpenQA.Selenium;

namespace OrangeHRMTests.Pages {
    public class PIMPage {
        private readonly IWebDriver driver;
        public PIMPage(IWebDriver driver) => this.driver = driver;

        public void GoToPIM() => driver.FindElement(By.LinkText("PIM")).Click();

        public void SearchAndEditEmployee(string name) {
            driver.FindElement(By.XPath("//input[@placeholder='Type for hints...']")).SendKeys(name);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//div[@class='oxd-table-body']//i[@class='oxd-icon bi-pencil-fill']")).Click();
        }

        public void EditLastName(string newLastName) {
            var lastName = driver.FindElement(By.Name("lastName"));
            lastName.Clear();
            lastName.SendKeys(newLastName);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }
    }
}
