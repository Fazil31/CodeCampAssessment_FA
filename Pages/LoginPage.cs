using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CodeCampAssessment.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LoginButton => driver.FindElement(By.CssSelector("[aria-label=\"login\"]"));

        private IWebElement AlertMessage => driver.FindElement(By.CssSelector("div.v-alert__content"));

        private IWebElement CloseAlertButton => driver.FindElement(By.CssSelector("[aria-label=\"Close\"]"));

        public void ClickLoginButton()
        {
            // I would have this after inside ToolBarPage.NavigateToLogin method, after clicking. It tends
            // to be more effective to wait *after* and action, rather than just before.
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(d => LoginButton.Displayed);
            LoginButton.Click();
        }

        public string GetAlertMessage()
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(d => AlertMessage.Displayed);
            return AlertMessage.Text;
        }

        public void CloseAlertMessage()
        {
            CloseAlertButton.Click();
        }

        public bool IsAlertMessagePresent()
        {
            return AlertMessage.Displayed;
        }

    }
}
