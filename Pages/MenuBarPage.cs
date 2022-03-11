using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace CodeCampAssessment.Pages
{
    public class MenuBarPage
    {
        private IWebDriver driver;

        public MenuBarPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private ReadOnlyCollection<IWebElement> MenuItems => driver.FindElements(By.ClassName("v-tab"));

        public void ClickMenuItem(string itemName)
        {
            foreach (IWebElement item in MenuItems)
            {
                if (item.Text.StartsWith(itemName))
                {
                    item.Click();
                    break;
                }
            }
        }
    }
}
