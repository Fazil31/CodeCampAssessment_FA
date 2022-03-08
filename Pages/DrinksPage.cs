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
    public class DrinksPage
    {
        private IWebDriver driver;

        public DrinksPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement OrderButton => driver.FindElement(By.CssSelector("[aria-label=\"Add to order\"]"));
        private ReadOnlyCollection<IWebElement> AllDrinks => driver.FindElements(By.CssSelector(""));


    }
}
