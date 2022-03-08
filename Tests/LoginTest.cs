using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using CodeCampAssessment.Base;
using CodeCampAssessment.Pages;

namespace CodeCampAssessment.Tests
{
    [TestClass]
    public class LoginTest: BastTest
    {
        [TestMethod]
        public void PizzaHQ_VerifyUnsuccessfulLogin()
        {
            //arrange
            new ToolBarPage(driver).NavigateToLogin();
            LoginPage loginPage = new LoginPage(driver);
            //act
            loginPage.ClickLoginButton();

            //assert
            Assert.AreEqual("Your login was unsuccessful - please try again", loginPage.GetAlertMessage());
        }

        [TestMethod]
        public void PizzaHQ_VerifyAlertNotDisplayed()
        {
            //arrange
            new ToolBarPage(driver).NavigateToLogin();
            LoginPage loginPage = new(driver);
            //act
            loginPage.ClickLoginButton();
            loginPage.CloseAlertMessage();

            //assert
            Assert.IsFalse(loginPage.IsAlertMessagePresent(), "Alert message is present");
        }
    }
}