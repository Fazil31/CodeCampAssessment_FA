using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Pages
{
    public class ToolBarPage
    {
        private IWebDriver driver;

        public ToolBarPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Login
        {
            get => driver.FindElement(By.CssSelector("[aria-label=\"login or signup\"]"));
        }

        private IWebElement Menu 
        {
            get => driver.FindElement(By.CssSelector("[aria-label=\"menu\"]"));
        }

        private IWebElement Order
        {
            get => driver.FindElement(By.CssSelector("[aria-label=\"your order\"]"));
        }

        private IWebElement OrderCount
        {
            get => driver.FindElement(By.CssSelector(".order-count"));
        }

        public void NavigateToLogin()
        {
            Login.Click();
        }

        public void NavigateToMenu()
        {
            Menu.Click();
        }

        public void NavigateToOrder()
        {
            Order.Click();
        }

        public int GetOrderCount()
        {
            return Int32.Parse(OrderCount.Text);
        }
    }
}
