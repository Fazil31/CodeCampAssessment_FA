using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace CodeCampAssessment.Base
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://d2ju5vf8ca0qio.cloudfront.net/#/";
            driver.Manage().Window.Maximize();

            // Does this do anything? Wouldn't you want to save into a protected field?
            new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [TestCleanup]
        public void Cleanup()
        {
            // You probably left this commented out for debugging. Don't forget to re-enable when checking in!
            // To avoid this, I'd suggest just relying on breakpoints so you don't make this mistake.
            driver.Quit();
        }


    }
}
