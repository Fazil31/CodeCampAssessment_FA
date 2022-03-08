using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using CodeCampAssessment.Base;

namespace CodeCampAssessment.Tests
{
    [TestClass]
    public class LoginTest: BastTest
    {
        [TestMethod]
        public void PizzaHQ_VerifyUnsuccessfulLogin()
        {
            string alertMessage;
            //act
            Login();
            alertMessage = driver.FindElement(By.CssSelector("div.v-alert__content")).Text;
            
            //assert
            Assert.AreEqual("Your login was unsuccessful - please try again", alertMessage);
        }

        [TestMethod]
        public void PizzaHQ_VerifyAlertNotDisplayed()
        {
            bool isAlertPresent;
            //act
            Login();
            driver.FindElement(By.CssSelector("[aria-label=\"Close\"]")).Click();
            isAlertPresent = driver.FindElement(By.CssSelector("div.v-alert__content")).Displayed;

            //assert
            Assert.IsFalse(isAlertPresent, "Alert message is present");
        }

        private void Login()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(6)).Until(d => driver.FindElement(By.CssSelector("[aria-label=\"login or signup\"]")).Displayed);
            driver.FindElement(By.CssSelector("[aria-label=\"login or signup\"]")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(6)).Until(d => driver.FindElement(By.CssSelector("[aria-label=\"login\"]")).Displayed);
            driver.FindElement(By.CssSelector("[aria-label=\"login\"]")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(d => driver.FindElement(By.CssSelector("div.v-alert__content")).Displayed);
        }

    }
}