using CodeCampAssessment.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CodeCampAssessment.Pages
{
    public class DrinksPage
    {
        private IWebDriver driver;

        public DrinksPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        private ReadOnlyCollection<IWebElement> AllDrinks => driver.FindElements(By.CssSelector(".menuItem.drink"));

        public IEnumerable<Drink> GetDrinks()
        {
            foreach (var drink in AllDrinks) 
            {
                yield return new Drink(driver, drink);
            }
        }

        public Drink GetDrink(Predicate<Drink> match)
        {
            foreach (var drink in GetDrinks())
            {
                if (match.Invoke(drink))
                {
                    return drink;
                }
            }
            throw new NotFoundException($"Could not find the Drink.");
        }

    }
}
