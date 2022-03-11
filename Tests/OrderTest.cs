using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeCampAssessment.Base;
using CodeCampAssessment.Pages;

namespace CodeCampAssessment.Tests
{
    [TestClass]
    public class OrderTest : BaseTest
    {
        [TestMethod]
        public void PizzaHQ_VerifyOrderCount()
        {
            //arrange
            ToolBarPage toolBarPage = new ToolBarPage(driver);
            MenuBarPage menuBarPage = new MenuBarPage(driver);
            DrinksPage drinksPage = new DrinksPage(driver);
            PizzasPage pizzasPage = new PizzasPage(driver);
            //act
            toolBarPage.NavigateToMenu();
            menuBarPage.ClickMenuItem("DRINKS");
            drinksPage.GetDrink(d => d.GetDrinkName() == "Espresso Thickshake").ClickOrderButton(1);
            menuBarPage.ClickMenuItem("PIZZAS");
            pizzasPage.GetPizza(d => d.GetPizzaName() == "Margherita").ClickOrderButton(2);

            //assert
            Assert.AreEqual(3, toolBarPage.GetOrderCount());
        }
    }
}
