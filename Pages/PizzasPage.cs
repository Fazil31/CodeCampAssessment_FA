using CodeCampAssessment.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampAssessment.Pages
{
    public class PizzasPage
    {
        private IWebDriver driver;

        public PizzasPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private ReadOnlyCollection<IWebElement> AllPizzas => driver.FindElements(By.CssSelector(".menuItem.pizza"));

        public IEnumerable<Pizza> GetPizzas()
        {
            foreach (var pizza in AllPizzas)
            {
                yield return new Pizza(pizza);
            }
        }

        public Pizza GetPizza(Predicate<Pizza> match)
        {
            foreach (var pizza in GetPizzas())
            {
                if (match.Invoke(pizza))
                {
                    return pizza;
                }
            }
            throw new NotFoundException($"Could not find the Pizza.");
        }

    }
}
