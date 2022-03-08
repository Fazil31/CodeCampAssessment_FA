using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Models
{
    public class Drink
    {
        private IWebDriver driver;
        private IWebElement drink;

        public Drink(IWebDriver driver,IWebElement drink)
        {
            this.driver = driver;
            this.drink = drink;
        }

        private IWebElement DrinkName => this.drink.FindElement(By.ClassName("name"));

        private IWebElement OrderButton => this.drink.FindElement(By.TagName("button"));

        public string GetDrinkName()
        {
            return DrinkName.Text;
        }

        public void ClickOrderButton(int numOfTimes)
        {
            for (int i = 0; i < numOfTimes; i++)
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(d => OrderButton.Displayed);
                OrderButton.Click();
            }
        }
    }
}
