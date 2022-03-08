using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Models
{
    public class Pizza
    {
        private IWebElement pizza;

        public Pizza(IWebElement pizza)
        {
            this.pizza = pizza;
        }

        private IWebElement PizzaName => this.pizza.FindElement(By.ClassName("name"));

        private IWebElement OrderButton => this.pizza.FindElement(By.TagName("button"));

        public string GetPizzaName()
        {
            return PizzaName.Text;
        }

        public void ClickOrderButton(int numOfTimes)
        {
            for(int i = 0; i < numOfTimes; i++)
            {
                OrderButton.Click();
            }
        }
    }
}
