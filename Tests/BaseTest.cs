using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OrangeHRMTests.Drivers;

namespace OrangeHRMTests.Tests {
    public class BaseTest {
        protected IWebDriver driver;

        [SetUp]
        public void Setup() {
            driver = WebDriverFactory.CreateWebDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [TearDown]
        public void Teardown() {
            driver.Quit();
        }
    }
}
