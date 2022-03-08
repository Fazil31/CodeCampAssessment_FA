using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Tests
{
    [TestClass]
    public class OrderTest
    {
        IWebDriver driver;
        WebDriverWait wait;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://d2ju5vf8ca0qio.cloudfront.net/#/";
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        [TestCleanup]
        public void Cleanup()
        {
            //driver.Quit();
        }

        [TestMethod]
        public void PizzaHQ_VerifyOrderCount()
        {
            //act
            driver.FindElement(By.CssSelector("[aria-label=\"menu\"]")).Click();
            ClickMenuItem("DRINKS");

            //assert

        }

        private void ClickMenuItem(string item)
        {
            ReadOnlyCollection<IWebElement> menuItems = driver.FindElements(By.ClassName("v-tab"));

            foreach (IWebElement element in menuItems)
            {
                if (element.Text.StartsWith(item))
                {
                    element.Click();
                    break;
                }
            }
        }
    }
}
