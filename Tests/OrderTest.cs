using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using CodeCampAssessment.Base;

namespace CodeCampAssessment.Tests
{
    [TestClass]
    public class OrderTest : BastTest
    {
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
