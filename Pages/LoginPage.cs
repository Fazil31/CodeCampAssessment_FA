using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
