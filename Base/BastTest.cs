using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Base
{
    [TestClass]
    public class BastTest
    {
        public IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://d2ju5vf8ca0qio.cloudfront.net/#/";
            driver.Manage().Window.Maximize();
            new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [TestCleanup]
        public void Cleanup()
        {
            //driver.Quit();
        }


    }
}
