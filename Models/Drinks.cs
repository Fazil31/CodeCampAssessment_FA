using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Models
{
    public class Drinks
    {
        private IWebElement drink;

        public Drinks(IWebElement drink)
        {
            this.drink = drink;
        }

        public string DrinkName => this.drink.FindElement(By.ClassName("name")).Text;
    }
}
