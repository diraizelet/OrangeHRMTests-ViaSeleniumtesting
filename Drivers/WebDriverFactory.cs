
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeHRMTests.Drivers {
    public static class WebDriverFactory {
        public static IWebDriver CreateWebDriver() {
            var options = new ChromeOptions();
            // options.AddArgument("--headless");
            return new ChromeDriver(options);
        }
    }
}
